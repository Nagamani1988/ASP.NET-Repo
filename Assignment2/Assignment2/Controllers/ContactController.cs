using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

using Assignment2.Models;
using Assignment2.Repositories;

namespace Assignment2.Controllers
{
    public class ContactController : Controller
    {
        
       private readonly IContactRepository _repository;

        public ContactController()
        {
            _repository = new ContactRepository();
        }

        // GET: Contact
        public async Task<ActionResult> Index()
        {
            var contacts = await _repository.GetAllAsync();
            return View(contacts);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // Post: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                await _repository.CreateAsync(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Contact/Delete/5
        public async Task<ActionResult> Delete(long id)
        {
            await _repository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
