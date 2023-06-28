using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaoCaoBaiTapLonNhom02.Models.Process;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhamThuHa.Models;
using PhamThuHa.Models.Process;

namespace PhamThuHa.Controllers
{
    public class HocSinhController : Controller
    {

 StringProcess strPro = new StringProcess();
        private ExcelProcess _excelProcess = new ExcelProcess();        
        private readonly ApplicationDbContext _context;

        public HocSinhController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HocSinh
        public async Task<IActionResult> Index()
        {
              return _context.HocSinh != null ? 
                          View(await _context.HocSinh.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.HocSinh'  is null.");
        }

        // GET: HocSinh/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HocSinh == null)
            {
                return NotFound();
            }

            var hocSinh = await _context.HocSinh
                .FirstOrDefaultAsync(m => m.MaLopHoc == id);
            if (hocSinh == null)
            {
                return NotFound();
            }

            return View(hocSinh);
        }

        // GET: HocSinh/Create
        
             public IActionResult Create()
        {
             var newMaSV = "";
            if (_context.HocSinh.Count() == 0)
            {
                newMaSV = "CNTT1921001";
            }
            else
            {
                var id = _context.HocSinh.OrderByDescending(m =>m.MaSV).First().MaSV;
                newMaSV = strPro.AutoGenerateKey(id);
            }
            ViewBag.SinhVien = newMaSV;
          
            return View();
        }
           

        // POST: HocSinh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLopHoc,TenLopHoc,DiaLopHoc")] HocSinh hocSinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hocSinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hocSinh);
        }

        // GET: HocSinh/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HocSinh == null)
            {
                return NotFound();
            }

            var hocSinh = await _context.HocSinh.FindAsync(id);
            if (hocSinh == null)
            {
                return NotFound();
            }
            return View(hocSinh);
        }

        // POST: HocSinh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("MaLopHoc,TenLopHoc,DiaLopHoc")] HocSinh hocSinh)
        {
            if (id != hocSinh.MaLopHoc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hocSinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HocSinhExists(hocSinh.MaLopHoc))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hocSinh);
        }

        // GET: HocSinh/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HocSinh == null)
            {
                return NotFound();
            }

            var hocSinh = await _context.HocSinh
                .FirstOrDefaultAsync(m => m.MaLopHoc == id);
            if (hocSinh == null)
            {
                return NotFound();
            }

            return View(hocSinh);
        }

        // POST: HocSinh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.HocSinh == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HocSinh'  is null.");
            }
            var hocSinh = await _context.HocSinh.FindAsync(id);
            if (hocSinh != null)
            {
                _context.HocSinh.Remove(hocSinh);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HocSinhExists(int? id)
        {
          return (_context.HocSinh?.Any(e => e.MaLopHoc == id)).GetValueOrDefault();
        }
    }
    public async Task<IActionResult> Upload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Upload(IFormFile file)
        {
            if (file!=null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (fileExtension != ".xls" && fileExtension != ".xlsx")
                {
                    ModelState.AddModelError("", "Please choose excel file to upload!");
                }
                else
                {
                    //rename file when upload to sever
                    var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", fileName);
                    var fileLocation = new FileInfo(filePath).ToString();
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //save file to server
                        await file.CopyToAsync(stream);
                        //read data from file and write to database
                        var dt = _excelProcess.ExcelToDataTable(fileLocation);
                        //using for loop to read data form dt
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //create a new Person object
                            var ser = new SinhVien();
                            //set values for attribiutes
                            ser.MaSV = dt.Rows[i][0].ToString();
                            ser.TenSV = dt.Rows[i][1].ToString();
                            ser.MaNhom = dt.Rows[i][2].ToString();
                            ser.MaCathi = dt.Rows[i][3].ToString();
                            //add oject to context
                            _context.SinhVien.Add(ser);
                        }
                        //save to database
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View();
        }
    }
}
   

}
