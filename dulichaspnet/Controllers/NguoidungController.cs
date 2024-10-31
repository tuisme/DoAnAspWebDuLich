using dulichaspnet.Models;
using dulichaspnet.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dulichaspnet.Controllers
{
    public class NguoidungController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NguoidungController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Dangky()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Dangky(DangkyViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new NguoiDung
                {
                    TenDangNhap = model.UserName,
                    MatKhau = model.Password, // Lưu ý: Cần mã hóa mật khẩu trong thực tế
                    Email = model.Email,
                    NgayTao = DateTime.Now
                };

                _context.NguoiDungs.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Dangnhap()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Dangnhap(DangnhapViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.NguoiDungs
                    .FirstOrDefaultAsync(u => u.TenDangNhap == model.UserName && u.MatKhau == model.Password); // Lưu ý: Cần mã hóa mật khẩu trong thực tế

                if (user != null)
                {
                    // Xử lý đăng nhập thành công (ví dụ: tạo cookie xác thực)
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid login attempt.");
            }
            return View(model);
        }
    }
}