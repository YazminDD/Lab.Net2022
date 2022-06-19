﻿using EntityFramework.Entities;
using EntityFramework.Logic;
using EntityFramework.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic shippersLogic;

        public ShippersController()
        {
            shippersLogic = new ShippersLogic();
        }
        

        // GET: Shippers
        public ActionResult Index()
        {
            var shippers = shippersLogic.GetAll();         

            List<ShippersView> shippersViews = shippers.Select(s => new ShippersView
            {
                ShipperID = s.ShipperID,
                ShipperName = s.CompanyName,
                ShipperPhone = s.Phone,
            }).ToList();

            return View(shippersViews);
        }

        // GET: Shippers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shippers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shippers/Create
        [HttpPost]
        public ActionResult Create(ShippersView shippersView)
        {
            try
            {

                Shippers shipperEntity = new Shippers {ShipperID = shippersView.ShipperID, CompanyName= shippersView.ShipperName, Phone= shippersView.ShipperPhone};
                shippersLogic.Add(shipperEntity);


                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: Shippers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shippers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shippers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shippers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
