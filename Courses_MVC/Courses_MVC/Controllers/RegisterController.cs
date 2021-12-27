using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courses_MVC.Data;
using Courses_MVC.Models;

namespace Courses_MVC.Controllers
{
    public class RegisterController : Controller
    {
        private readonly CoursesContext _context;
        public RegisterController(CoursesContext context)
        {
            _context = context;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> DanhSachDangKi()
        {
            var list = await _context.Registers.Include(x => x.Course).Include(x => x.AppUser).ToListAsync();
            var count = list.Count();
            ViewData["count"] = count;
            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> DanhSachDangKi(string? search)
        {
            var list = from rg in _context.Registers select rg;
            var count = list.Count();
            
            if (!string.IsNullOrEmpty(search))
            {
                list = list.Where(x => x.AppUser.UserName.Contains(search)).Include(x => x.Course).Include(x => x.AppUser);
                count = list.Count();
            }
            else
                list = list.Include(x => x.Course).Include(x => x.AppUser);
            ViewData["count"] = count;
            return View(await list.ToListAsync());
        }


        [HttpPost]
        public IActionResult ThemDangKi(Register register)
        {


            var user = _context.Users.ToList();
            user.Insert(0, new AppUser()
            {
                Id = "",
                UserName = ""
            });
            ViewData["user"] = new SelectList(user, "Id", "UserName");

            var course = _context.Courses.ToList();
            course.Insert(0, new Course()
            {
                courseId = -1,
                courseName = ""
            });
            ViewData["course"] = new SelectList(course, "courseId", "courseName");
            if (register.userId.ToString() == "")
            {
                ModelState.AddModelError(string.Empty, "Phải chọn khách hàng");
            }
            if (register.courseId == -1)
            {
                ModelState.AddModelError(string.Empty, "Phải chọn khóa học");
            }
            if (ModelState.IsValid)
            {

                _context.Registers.Add(new Register()
                {
                    registerId = register.registerId,
                    timeReg = register.timeReg,
                    userId = register.userId,
                    courseId = register.courseId

                });
                _context.SaveChanges(); 
                StatusMessage = $"Thêm thành công";
                return RedirectToAction(nameof(DanhSachDangKi));
            }
            StatusMessage = $"Thêm không thành công ";
            return View();
        }

        public IActionResult ThemDangKi()
        {
            var user = _context.Users.ToList();
            user.Insert(0, new AppUser()
            {
                Id = "",
                UserName = ""
            });
            ViewData["user"] = new SelectList(user, "Id", "UserName");

            var course = _context.Courses.ToList();
            course.Insert(0, new Course()
            {
                courseId = -1,
                courseName = ""
            });
            ViewData["course"] = new SelectList(course, "courseId", "courseName");
            return View();
        }

        public IActionResult XoaDangKi(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var result = _context.Registers.Include(c => c.AppUser).Include(c => c.Course).FirstOrDefault(c => c.registerId == id);
            if (result == null)
            {
                return NotFound();
            }
            _context.Registers.Remove(result);
            StatusMessage = $"Đã xóa thành công đơn đăng kí của khách hàng {result.AppUser.UserName} đã đăng kí khóa học {result.Course.courseName}";
            return RedirectToAction(nameof(DanhSachDangKi));
        }

        public IActionResult ChiTietDangKi(int? id)
        {
            var result = _context.Registers.Include(c => c.AppUser).Include(c => c.Course).FirstOrDefault(c => c.registerId == id);
            ViewData["user"] = new SelectList(_context.Users, "Id", "UserName", result.userId);
            ViewData["course"] = new SelectList(_context.Courses, "courseId", "courseName", result.courseId);
            return View(result);
        }

        public IActionResult CapNhatDangKi(int? id)
        {
            var result = _context.Registers.Include(c => c.AppUser).Include(c => c.Course).FirstOrDefault(c => c.registerId == id);
            ViewData["user"] = new SelectList(_context.Users, "Id", "UserName", result.userId);
            ViewData["course"] = new SelectList(_context.Courses, "courseId", "courseName", result.courseId);
            return View(result);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CapNhatDangKi(int?id, Register register)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var result = _context.Registers.FirstOrDefault(c => c.registerId == id);
            if (result != null)
            {
                result.timeReg = register.timeReg;
                result.userId = register.userId;
                result.courseId = register.courseId;
                _context.SaveChanges(); ;
                StatusMessage = $"Cập nhật thành công";
                return RedirectToAction(nameof(DanhSachDangKi));
            }
            else
            {
                StatusMessage = $"Thêm không thành công ";
                return RedirectToAction(nameof(DanhSachDangKi));
            }
        }
    }
}
