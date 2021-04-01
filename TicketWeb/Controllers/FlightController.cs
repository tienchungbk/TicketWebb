﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketWeb.Data;

namespace TicketWeb.Controllers
{
    public class FlightController : Controller
    {
        // GET: FlightController
        public ActionResult Index()
        {
            var listFlight = new TicketWebContext().ChuyenBays.ToList();
            return View(listFlight);
        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ChuyenBay collection)
        {
            try
            {
                var context = new TicketWebContext();
                context.ChuyenBays.Add(collection);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new TicketWebContext();
            var editing = context.ChuyenBays.Find(id);
            return View(editing);
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChuyenBay model)
        {
            try
            {
                var context = new TicketWebContext();
                var oldItem = context.ChuyenBays.Find(model.ID);
                oldItem.MaChuyenBay = model.MaChuyenBay;
                oldItem.MayBayID = model.MayBayID;
                oldItem.SanBayDen_ID = model.SanBayDen_ID;
                oldItem.SanBayDi_ID = model.SanBayDi_ID;
                oldItem.SoGhe_Hang1 = model.SoGhe_Hang1;
                oldItem.SoGhe_Hang2 = model.SoGhe_Hang2;
                oldItem.ThoiGianDuKienBay = model.ThoiGianDuKienBay;
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new TicketWebContext();
            var deleting = context.ChuyenBays.Find(id);
            return View(deleting);
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id ,FormCollection collection)
        {
            try
            {
                var context = new TicketWebContext();
                var deleting = context.ChuyenBays.Find(id);
                context.ChuyenBays.Remove(deleting);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
