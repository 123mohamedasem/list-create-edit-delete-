using list_item.Data;
using list_item.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace list_item.Controllers
{
    public class todoitemsController : Controller
    {

        ApplicationDbContext context = new ApplicationDbContext();


        public IActionResult create()
        {
            return View();
        }

        public IActionResult items()
        {

            var result = context.lists.ToList();

            return View(result);
        }

        public IActionResult createnew()
        {
            return View();
        }




        public IActionResult save(string title, string description, DateTime deadline)
        {
            tasklist tasklist = new tasklist();
            {
                tasklist.Description = description;
                tasklist.Title = title;
                tasklist.Deadline = deadline;

            };

            context.lists.Add(tasklist);
            context.SaveChanges();
            return RedirectToAction("items");
        }

        public IActionResult Edit(int Id)
        {

            var result = context.lists.Find(Id);

            return result!=null? View(result) : NotFound();









        }

        public IActionResult saveedit(tasklist tasklist) {

            context.lists.Update(tasklist);
            context.SaveChanges();

            return RedirectToAction("items");
               
        
        
        
        }

        public IActionResult Delete(int Id) {

            var result = context.lists.Find(Id);
            context.lists.Remove(result);
            context.SaveChanges();
            return RedirectToAction("items");

        

        
        
        }









    }
}

