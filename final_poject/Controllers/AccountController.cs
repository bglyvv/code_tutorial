﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_poject.DAL;
using final_poject.Models;
using final_poject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace final_poject.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(AppDbContext db, UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register(Register _register)
        {
            User user = new User
            {
                Fullname = _register.Fullname,
                Email = _register.Email,
                UserName = _register.Username
            };

            IdentityResult identityResult = await _userManager.CreateAsync(user, _register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                    
                }
                return View(_register);

            }
            await _userManager.AddToRoleAsync(user, Helpers.Helper.Roles.Member.ToString());
            await _signInManager.SignInAsync(user, true);
            if (Request.Cookies["subject"] != null)
            {
                List<Subject> subjects = JsonConvert.DeserializeObject<List<Models.Subject>>(Request.Cookies["subject"]);
                foreach (Subject cookieSubject in subjects)
                {
                    if (!_db.SavedSubjects.Any(s => s.Subject == cookieSubject))
                    {
                        _db.SavedSubjects.Add(new SavedSubject
                        {
                            User = user,
                            SubjectId = cookieSubject.Id
                        });
                        await _db.SaveChangesAsync();

                    }
                }
            }
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login _login)
        {
            if (!ModelState.IsValid) return View(_login);
            User active_user = await _userManager.FindByNameAsync(_login.Username);
            if (active_user == null)
            {
                ModelState.AddModelError(string.Empty, "İstifadəçi adı və yaxud Şifrə yanlışdır!!!");
                return View(_login);
            }
            if (active_user.isDeleted == true)
            {
                ModelState.AddModelError(string.Empty, "Bu hesab ya silinib ya da blok olunub.");
                return View(_login);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult;
            if (_login.isChecked == true)
            {
                signInResult = await _signInManager.PasswordSignInAsync(active_user, _login.Password, true, true);
            }
            else
            {
                signInResult = await _signInManager.PasswordSignInAsync(active_user, _login.Password, false, true);
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "İstifadəçi adı və yaxud Şifrə yanlışdır!!!");
                return View(_login);
            }
            if (Request.Cookies["subject"] != null)
            {
                List<Subject> subjects = JsonConvert.DeserializeObject<List<Models.Subject>>(Request.Cookies["subject"]);
                foreach (Subject cookieSubject in subjects)
                {
                    if (!_db.SavedSubjects.Any(s => s.Subject == cookieSubject))
                    {
                        _db.SavedSubjects.Add(new SavedSubject
                        {
                            User = active_user,
                            SubjectId = cookieSubject.Id
                        });
                        await _db.SaveChangesAsync();

                    }
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> MyAccount() 
        {
            User user = await _userManager.GetUserAsync(User);
            Register reg = new Register
            {
                Fullname = user.Fullname,
                Username = user.UserName,
                Email = user.Email
            };
            return View(reg);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeBasics(Register reg,string pass)
        {
            TempData["basicError"] = "";

            User user = await _userManager.GetUserAsync(User);
            PasswordVerificationResult passresult = _userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, pass);

            if (passresult == PasswordVerificationResult.Failed) 
            {
                TempData["basicError"] = "Xahiş edirik şifrəni doğru daxil edin";
                return RedirectToAction("MyAccount",user);
            }

            user.Fullname = reg.Fullname;
            user.Email = reg.Email;
            user.UserName = reg.Username;

            await _db.SaveChangesAsync();

            return RedirectToAction("MyAccount");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(Register reg, string pass)
        {
            List<string> errors = new List<string>();
            TempData["passError"] = "";

            User user = await _userManager.GetUserAsync(User);
            //PasswordVerificationResult passresult = _userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, reg.Password);

            //if (passresult == PasswordVerificationResult.Failed)
            //{
            //    TempData["passError"] = "Xahiş edirik şifrəni doğru daxil edin";
            //    return RedirectToAction("MyAccount", user);
            //}

            var passwordValidator = new PasswordValidator<User>();
            var result = await passwordValidator.ValidateAsync(_userManager, null, pass);

            if (!result.Succeeded) 
            {
                foreach (var error in result.Errors)
                {
                    errors.Add(error.Description);

                }
                TempData["passError"] = errors;
                return RedirectToAction("MyAccount",reg);
            }


            await _db.SaveChangesAsync();

            return RedirectToAction("MyAccount");
        }

        public async Task CreateRole()
        {

            if (!await _roleManager.RoleExistsAsync(Helpers.Helper.Roles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Roles.Admin.ToString()));
            }

            if (!await _roleManager.RoleExistsAsync(Helpers.Helper.Roles.Moderator.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Roles.Moderator.ToString()));
            }

            if (!await _roleManager.RoleExistsAsync(Helpers.Helper.Roles.Teacher.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Roles.Teacher.ToString()));
            }

            if (!await _roleManager.RoleExistsAsync(Helpers.Helper.Roles.Member.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Roles.Member.ToString()));
            }


        }
    }
}