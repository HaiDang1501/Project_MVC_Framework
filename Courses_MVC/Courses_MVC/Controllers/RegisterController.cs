﻿using System;
using OfficeOpenXml;
using System.Data;
using System.IO;
using System.Web;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courses_MVC.Data;
using Courses_MVC.Models;
using Microsoft.AspNetCore.Http;

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
            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> DanhSachDangKi(string? search)
        {
            var list = from rg in _context.Registers select rg;
            if (!string.IsNullOrEmpty(search))
            {
                list = list.Where(x => x.AppUser.UserName.Contains(search)).Include(x => x.Course).Include(x => x.AppUser);
            }
            else
                list = list.Include(x => x.Course).Include(x => x.AppUser);
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChiTietDangKi(int? id, Register register)
        {
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
                return View();
            }
        }

        public IActionResult ConfirmCart(List<int> courseId)
        {
            foreach( var item in courseId)
            {
                _context.Registers.Add(new Register()
                {
                    userId = "264b663a-54c4-48e9-8c90-5672caa3be2c",
                    courseId = item,
                    timeReg = DateTime.UtcNow
                }) ;
                _context.SaveChanges();
                           
            }
            StatusMessage = $"Đăng ký thành công";
            int registerStatus = 1;
            return RedirectToAction("ClearAfterRegister", "Courses", new { status= registerStatus });
        }

        public void Export(string file, string? userId,int? courseId)
        {
            var listReg = _context.Registers.Select(r => new
            {
                ID = r.registerId,
                Name = r.AppUser.UserName,
                Course = r.Course.courseName,
                Time = r.timeReg.ToString()
            }).OrderBy(r => r.ID).ToList();
            if (userId == null && courseId == null)
            {
                listReg = listReg;
            }
            else if (courseId == null)
            {
                listReg = _context.Registers.Where(r => r.userId == userId).Select(r => new
                {
                    ID = r.registerId,
                    Name = r.AppUser.UserName,
                    Course = r.Course.courseName,
                    Time = r.timeReg.ToString()
                }).OrderBy(r => r.ID).ToList();
            }
            else if (userId == null)
            {
                listReg = _context.Registers.Where(r => r.courseId == courseId).Select(r => new
                {
                    ID = r.registerId,
                    Name = r.AppUser.UserName,
                    Course = r.Course.courseName,
                    Time = r.timeReg.ToString()
                }).OrderBy(r => r.ID).ToList();
            }
            else
            {
                listReg = _context.Registers.Where(r => r.courseId == courseId).Where(r => r.userId == userId).Select(r => new
                {
                    ID = r.registerId,
                    Name = r.AppUser.UserName,
                    Course = r.Course.courseName,
                    Time = r.timeReg.ToString()
                }).OrderBy(r => r.ID).ToList();
            }    
 
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using(ExcelPackage pck = new ExcelPackage())
            {
                //pck.Workbook.Worksheets.Add("Dang ky").Cells["A1"].LoadFromCollection(listReg, true);
                var worksheet = pck.Workbook.Worksheets.Add("Dang ky");
                worksheet.Cells["A1"].LoadFromCollection(listReg, true);
                worksheet.Cells["A1:AN1"].Style.Font.Bold = true;
                worksheet.DefaultRowHeight = 18;
                worksheet.Column(2).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                worksheet.Column(6).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Column(7).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.DefaultColWidth = 20;
                worksheet.Column(2).AutoFit();
                worksheet.Column(3).AutoFit();
                pck.SaveAs(new FileInfo(file));

            } 
        }
        public IActionResult ExportExcel( string filename, string? userId, int? courseId)
        {
            string newExcelFile = @"D:\giaodien_frame\" + filename +".xlsx";
            Export(newExcelFile, userId, courseId);
            StatusMessage = $"Xuất file excel thành công";
            return RedirectToAction(nameof(DanhSachDangKi));

        }
    }
}
