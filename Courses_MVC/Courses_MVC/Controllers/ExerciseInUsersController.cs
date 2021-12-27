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
    public class ExerciseInUsersController : Controller
    {
        private readonly CoursesContext _context;

        public ExerciseInUsersController(CoursesContext context)
        {
            _context = context;
        }

        [TempData]
        public string StatusMessage { get; set; }

        // GET: ExerciseInUsers
        public async Task<IActionResult> DanhSachBTUser()
        {
            
            var exerciseInUser = _context.ExerciseInUsers.Include(e => e.AppUser).Include(e => e.Exercise);
            var count = exerciseInUser.Count();
            ViewData["count"] = count;
            return View(await exerciseInUser.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhSachBTUser(string search)
        {
            var exerciseInUser = from exInUs in _context.ExerciseInUsers select exInUs;
            var count = exerciseInUser.Count();
            
            if (!string.IsNullOrEmpty(search))
            {
                exerciseInUser = exerciseInUser.Where(c => c.AppUser.UserName.Contains(search)).Include(c => c.AppUser).Include(c => c.Exercise);
                count = exerciseInUser.Count();
            }
            else
            {
                exerciseInUser = exerciseInUser.Include(c => c.AppUser).Include(c => c.Exercise);
                count = exerciseInUser.Count();
            }
            ViewData["count"] = count;
            return View(await exerciseInUser.ToListAsync());
        }

        public IActionResult ThemSVBT()
        {
            var user = _context.Users.ToList();
            user.Insert(0, new AppUser() {
                Id = "",
                UserName = ""
            });
            ViewData["userId"] = new SelectList(user, "Id", "UserName");

            var exercise = _context.Exercises.ToList();
            exercise.Insert(0, new Exercise()
            {
                exerciseId = 0,
                exerciseName = ""
            }) ;
            ViewData["exerciseId"] = new SelectList(exercise, "exerciseId", "exerciseName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemSVBT(ExerciseInUser exerciseInUser)
        {
            var user = _context.Users.ToList();
            user.Insert(0, new AppUser()
            {
                Id = "",
                UserName = ""
            });
            ViewData["userId"] = new SelectList(user, "Id", "UserName");

            var exercise = _context.Exercises.ToList();
            exercise.Insert(0, new Exercise()
            {
                exerciseId = 0,
                exerciseName = ""
            });
            ViewData["exerciseId"] = new SelectList(exercise, "exerciseId", "exerciseName");
            if (exerciseInUser == null)
            {
                return NotFound();
            }
            if(exerciseInUser.userId.ToString() == "")
            {
                ModelState.AddModelError(string.Empty, "Phải chọn sinh viên");
            }
            if (exerciseInUser.exerciseId == 0)
            {
                ModelState.AddModelError(string.Empty, "Phải chọn bài học");
            }
            if (ModelState.IsValid)
            {
                _context.ExerciseInUsers.Add(new ExerciseInUser() { 
                    userId = exerciseInUser.userId,
                    exerciseId = exerciseInUser.exerciseId,
                    scores = exerciseInUser.scores,
                    submit = exerciseInUser.submit,
                    content = exerciseInUser.content
                });
                _context.SaveChanges();
                StatusMessage = $"Thêm thành công ";
                return RedirectToAction(nameof(DanhSachBTUser));
            }
            StatusMessage = "Thêm không thành công";
            return View();
        }

        // GET: ExerciseInUsers/Details/5
        public async Task<IActionResult> ChiTietBTUser(int exerciseId, string userId)
        {
            if (exerciseId == 0 && userId == null)
            {
                return NotFound();
            }

            var result = await _context.ExerciseInUsers
                .Where(c => c.userId == userId).Include(e => e.AppUser).Include(e => e.Exercise).Where(c => c.exerciseId == exerciseId).FirstOrDefaultAsync();
            //ViewData["userId"] = new SelectList(_context.Users, "Id", "UserName", result.userId );
            //ViewData["exerciseId"] = new SelectList(_context.Exercises, "exerciseId", "exerciseName", result.exerciseId);
            if (result == null)
            {
                return NotFound();
            }

            return View(result);
        }

        public async Task<IActionResult> CapNhatBTUser(int exerciseId, string userId)
        {
            if (exerciseId == 0 && userId == null)
            {
                return NotFound();
            }

            var result = await _context.ExerciseInUsers
                .Where(c => c.userId == userId).Include(e => e.AppUser).Include(e => e.Exercise).Where(c => c.exerciseId == exerciseId).FirstOrDefaultAsync();
            ViewData["userId"] = new SelectList(_context.Users, "Id", "UserName", result.userId);
            ViewData["exerciseId"] = new SelectList(_context.Exercises, "exerciseId", "exerciseName", result.exerciseId);
            if (result == null)
            {
                return NotFound();
            }

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> CapNhatBTUser(ExerciseInUser exerciseInUser)
        {
            if (exerciseInUser.exerciseId == 0 && exerciseInUser.userId == null)
            {
                return NotFound();
            }
            var result =await _context.ExerciseInUsers
                .Where(c => c.userId == exerciseInUser.userId).Include(e => e.AppUser).Include(e => e.Exercise).Where(c => c.exerciseId == exerciseInUser.exerciseId).FirstOrDefaultAsync();


            if (result == null)
            {
                StatusMessage = "Cập nhật không thành công";
                return RedirectToAction(nameof(DanhSachBTUser));
            }
            else
            {
                //result.userId = exerciseInUser.userId;
                //result.exerciseId = exerciseInUser.exerciseId;
                result.scores = exerciseInUser.scores;
                result.submit = exerciseInUser.submit;
                result.content = exerciseInUser.content;
                _context.SaveChanges();
                StatusMessage = $"Cập nhật thành công ";
                return RedirectToAction(nameof(DanhSachBTUser));

            }


        }

        public IActionResult XoaBTUser(int excerciseId, string userId)
        {
            if(excerciseId == 0 && userId == null)
            {
                return NotFound();
            }
            var topic = _context.ExerciseInUsers.Where(c=>c.userId == userId).Where(c=>c.exerciseId == excerciseId).FirstOrDefault();
            if (topic == null)
            {
                return NotFound();
            }
            _context.Remove(topic);
            _context.SaveChanges();
            StatusMessage = $"Xóa thành công ";
            return RedirectToAction(nameof(DanhSachBTUser));
        }

        
        // POST: ExerciseInUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ChiTietBTUser(string id, [Bind("content,submit,scores")] ExerciseInUser exerciseInUser)
        //{
        //    if (id != exerciseInUser.userId )
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(exerciseInUser);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ExerciseInUserExists(exerciseInUser.userId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["studentId"] = new SelectList(_context.Users, "Id", "Id", exerciseInUser.userId);
        //    ViewData["exerciseId"] = new SelectList(_context.Exercises, "exerciseId", "content", exerciseInUser.exerciseId);
        //    return View(exerciseInUser);
        //}

        

        private bool ExerciseInUserExists(string id)
        {
            return _context.ExerciseInUsers.Any(e => e.userId == id);
        }
    }
}
