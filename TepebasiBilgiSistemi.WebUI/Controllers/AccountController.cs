using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TepebasiBilgiSistemi.Business.Abstract;
using TepebasiBilgiSistemi.Entities.Concrete;
using TepebasiBilgiSistemi.WebUI.Models.AccountViewModel;

namespace TepebasiBilgiSistemi.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private SignInManager<User> _signInManager;
        private IMudurlukService _mudurlukService;

        public AccountController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager, IMudurlukService mudurlukService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mudurlukService = mudurlukService;
        }
        //[Authorize(Roles = "Admin")]
        public IActionResult RoleList()
        {

            var model = new RoleListViewModel
            {
                Roles = _roleManager.Roles.ToList()
            };

            return View(model);

        }
        //[Authorize(Roles = "Admin")]
        public IActionResult RoleAdd()
        {

            var model = new RoleAddViewModel
            {
                IdentityRole = new IdentityRole()
            };


            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> RoleAdd(IdentityRole identityRole)
        {
            if (ModelState.IsValid)
            {
                await _roleManager.CreateAsync(identityRole);
            }

            return RedirectToAction("RoleList");
        }
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> RoleUpdate(string Id)
        {

            var model = new RoleUpdateViewModel
            {
                IdentityRole = await _roleManager.FindByIdAsync(Id)
            };


            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> RoleUpdate(IdentityRole identityRole)
        {
            if (ModelState.IsValid)
            {
                await _roleManager.UpdateAsync(identityRole);
            }

            return RedirectToAction("RoleList");
        }


        public IActionResult Register()
        {
            List<SelectListItem> RoleList = new List<SelectListItem>();
            foreach (var role in _roleManager.Roles)
                RoleList.Add(new SelectListItem() { Value = role.Name, Text = role.Name });

            ViewBag.Roles = RoleList;

            List<SelectListItem> MudurlukList = new List<SelectListItem>();
            foreach (var mudurluk in _mudurlukService.GetAll())
                MudurlukList.Add(new SelectListItem() { Value = mudurluk.Id.ToString(), Text = mudurluk.Name });

            ViewBag.Roles = RoleList;
            ViewBag.Mudurluk = MudurlukList;
            return View();
        }


        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = registerViewModel.UserName,
                    Email = "asd@tepebasi.bel.tr",
                    Name = registerViewModel.Name,
                    PhoneNumber = "1111",
                    Mudurluk_Id = registerViewModel.Mudurluk_Id
                };

                IdentityResult result = _userManager.CreateAsync(user, registerViewModel.Password).Result;

                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, registerViewModel.RoleName).Wait();
                    return RedirectToAction("UserList", "Account");
                }

            }

            return View(registerViewModel);
        }
        //[Authorize(Roles = "Admin")]
        public IActionResult UserList()
        {
            var model = new UserListViewModel
            {
                User = _userManager.Users.ToList()
            };

            return View(model);
        }
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken, AllowAnonymous]
        public IActionResult Login(LoginViewModel loginViewModel, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {

                var user = _userManager.Users.Where(p => p.UserName == loginViewModel.UserName);

                var result = _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, false, false).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(loginViewModel);
                }



            }
            return View(loginViewModel);
        }


        public IActionResult ChangePassword()
        {
            var model = new PassViewModel();
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken, AllowAnonymous]
        public async Task<IActionResult> ChangePassword(PassViewModel passViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.GetUserAsync(HttpContext.User);
                var removePassword = _userManager.RemovePasswordAsync(user);
                if (passViewModel.Password == passViewModel.ConfirmPassword)
                {
                    if (removePassword.Result.Succeeded)
                    {
                        //Removed Password Success
                        var AddPassword = _userManager.AddPasswordAsync(user, passViewModel.Password);
                        if (AddPassword.Result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                ModelState.AddModelError("", "Şifre ve tekrarı uyumsuz");
                return View(passViewModel);
            }
            return View();
        }


        public ActionResult LogOff()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UserUpdate(string Id)
        {

            UserUpdateViewModel model = new UserUpdateViewModel();
            model.ApRoles = _roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Id
            }).ToList();

            if (!String.IsNullOrEmpty(Id))
            {
                User user = await _userManager.FindByIdAsync(Id);
                if (user != null)
                {
                    model.Name = user.Name;
                    model.UserName = user.UserName;
                    model.ApRoleName = _roleManager.Roles.Single(r => r.Name == _userManager.GetRolesAsync(user).Result.Single()).Id;
                }
            }


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UserUpdate(string id, UserUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    user.Name = model.Name;
                    user.UserName = model.UserName;
                    string existingRole = _userManager.GetRolesAsync(user).Result.Single();
                    string existingRoleId = _roleManager.Roles.Single(r => r.Name == existingRole).Id;
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        if (existingRoleId != model.ApRoleName)
                        {
                            IdentityResult roleResult = await _userManager.RemoveFromRoleAsync(user, existingRole);
                            if (roleResult.Succeeded)
                            {
                                IdentityRole applicationRole = await _roleManager.FindByIdAsync(model.ApRoleName);
                                if (applicationRole != null)
                                {
                                    IdentityResult newRoleResult = await _userManager.AddToRoleAsync(user, applicationRole.Name);
                                    if (newRoleResult.Succeeded)
                                    {
                                        return RedirectToAction("Index", "Users");
                                    }
                                }
                            }
                        }
                    }

                }
            }
            return RedirectToAction("UserUpdate", "Account", model);
        }



    }
}