using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EgyNews.Data;
using EgyNews.Models;
using EgyNews.Areas.Admin.Models;

namespace EgyNews.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public AdminController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        // GET: Admin/Users
        public async Task<IActionResult> Users()
        {
            var users = _userManager.Users.ToList();
            var userRoles = new Dictionary<string, string>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userRoles[user.Id] = roles.FirstOrDefault() ?? "No Role"; // Get the first role or "No Role"
            }

            ViewBag.UserRoles = userRoles;
            return View(users);
        }



        // GET: Admin/EditUserRole/{userId}
        public async Task<IActionResult> EditUserRole(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();

            var userRoles = await _userManager.GetRolesAsync(user);
            var roles = _roleManager.Roles.Select(r => r.Name).ToList();

            var model = new EditUserRoleViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                SelectedRole = userRoles.FirstOrDefault(), // Get the first assigned role
                Roles = roles
            };

            return View(model);
        }

        // POST: Admin/EditUserRole
        [HttpPost]
        public async Task<IActionResult> EditUserRole(EditUserRoleViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null) return NotFound();

            var userRoles = await _userManager.GetRolesAsync(user);

            if (!string.IsNullOrEmpty(model.SelectedRole) && !userRoles.Contains(model.SelectedRole))
            {
                await _userManager.RemoveFromRolesAsync(user, userRoles); // Remove all existing roles
                var result = await _userManager.AddToRoleAsync(user, model.SelectedRole);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Failed to update role.");
                    return View(model);
                }
            }

            return RedirectToAction(nameof(Users));
        }
    }
}