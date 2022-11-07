using cw1_0851_view.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw1_0851_view.Controllers
{
    public class RoomsController : Controller
    {
        // GET: RoomsContrller
        public async Task<ActionResult> Index()
        {
            var service = new Services.RoomService();
            return View(await service.FindAll());
        }

        // GET: RoomsContrller/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var service = new Services.RoomService();
            return View(await service.FindOne(id));
        }

        // GET: RoomsContrller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomsContrller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Room collection)
        {
            try
            {
                var service = new Services.RoomService();
                service.Create(collection);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                throw e;
                return View();
            }
        }

        // GET: RoomsContrller/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var service = new Services.RoomService();
            return View(await service.FindOne(id));
        }

        // POST: RoomsContrller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Room collection)
        {
            try
            {
                collection.RoomId = id;
                var service = new Services.RoomService();
                service.Update(collection, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomsContrller/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View();
        }

        // POST: RoomsContrller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Room collection)
        {
            try
            {
                var service = new Services.RoomService();
                service.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
