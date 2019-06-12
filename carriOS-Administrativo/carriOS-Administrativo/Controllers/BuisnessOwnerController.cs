using carriOS_Administrativo.Models.Entitties;
using carriOS_Administrativo.Models.Service;
using carriOS_Administrativo.Models.ServiceImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace carriOS_Administrativo.Controllers
{
    public class BuisnessOwnerController : Controller
    {

        private BuisnessOwnerService buisnessOwnerService;

        public BuisnessOwnerController(BuisnessOwnerService bos)
        {
            buisnessOwnerService = bos;
        }

        public BuisnessOwnerController()
        {
            buisnessOwnerService = new BuisnessOwnerServiceImpl();
        }
        // GET: BuisnessOwner
        public ActionResult Index()
        {
            var buisnessOwner = buisnessOwnerService.FindAll();
            return View(buisnessOwner);
        }

        // GET: BuisnessOwner/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuisnessOwner buisnessOwner = buisnessOwnerService.FindById(id);
            if (buisnessOwner == null)
            {
                return HttpNotFound();
            }
            return View(buisnessOwner);
        }

        // GET: BuisnessOwner/Create
        public ActionResult Create()
        {
            return View(new BuisnessOwner());
        }

        // POST: BuisnessOwner/Create
        [HttpPost]
        public ActionResult Create(BuisnessOwner buisnessOwner)
        {
            try
            {
                // TODO: Add insert logic here
                if(!ModelState.IsValid)
                {
                    return View();
                }

                buisnessOwnerService.Save(buisnessOwner);
                return RedirectToAction("Index", "BuisnessOwner");
                
            }
            catch
            {
                return View();
            }
        }

        // GET: BuisnessOwner/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuisnessOwner buisnessOwner = buisnessOwnerService.FindById(id);
            if (buisnessOwner == null)
            {
                return HttpNotFound();
            }
            return View(buisnessOwner);
        }

        // POST: BuisnessOwner/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, BuisnessOwner buisnessOwner)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View();
                }

                buisnessOwnerService.Save(buisnessOwner);
                return RedirectToAction("Index", "BuisnessOwner");
            }
            catch
            {
                return View();
            }
        }

        // GET: BuisnessOwner/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuisnessOwner buisnessOwner = buisnessOwnerService.FindById(id);
            if (buisnessOwner == null)
            {
                return HttpNotFound();
            }
            return View(buisnessOwner);
        }

        // POST: BuisnessOwner/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                BuisnessOwner buisnessOwner = buisnessOwnerService.FindById(id);
                buisnessOwnerService.Delete(buisnessOwner);
                return RedirectToAction("Index", "BuisnessOwner");
            }
            catch
            {
                return View();
            }
        }
    }
}
