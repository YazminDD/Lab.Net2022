using EntityFramework.Entities;
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
                return RedirectToAction("Index", "Error");
            }
        }

        // GET: Shippers/Edit/5
        public ActionResult Edit(int id)
        {
            List<Shippers> shippers = shippersLogic.GetAll();
            List<ShippersView> shippersView = shippers.Where(s => s.ShipperID == id)
                                                       .Select(s => new ShippersView
                                                       {
                                                           ShipperID = s.ShipperID,
                                                           ShipperName = s.CompanyName,
                                                           ShipperPhone = s.Phone
                                                       }).ToList();
            ShippersView shipperView = shippersView[0];
            
            return View("Edit");
                                   
        }

        // POST: Shippers/Edit/5
        [HttpPost]
        public ActionResult Edit(ShippersView shippers)
        {
            try
            {
                Shippers shipperEntity = new Shippers
                {
                    ShipperID = shippers.ShipperID,
                    CompanyName = shippers.ShipperName,
                    Phone = shippers.ShipperPhone
                };
                
                shippersLogic.Update(shipperEntity);

                return RedirectToAction("Index");

                
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        // GET: Shippers/Delete/5
        public ActionResult Delete(int id)
        {
            shippersLogic.Delete(id);
            return RedirectToAction("Index");
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
