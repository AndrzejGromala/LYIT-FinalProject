using CarCollectionWithDB.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarCollectionWithDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<CarModel> carList = new List<CarModel>();
            using (CarCollectionEntities db = new CarCollectionEntities())
            {
                var cars = db.tblCarCollections.ToList();
                foreach(var cr in cars)
                {
                    CarModel crModel = new CarModel();
                    crModel.CarId = cr.CarId;
                    crModel.CarMkModel = cr.CarMkModel;
                    crModel.Engine = cr.Engine;
                    crModel.BodyType = cr.BodyType;
                    crModel.Transmission = cr.Transmission;
                    crModel.Year = cr.Year;
                    crModel.Color = cr.Color;
                    crModel.Value = cr.Value;

                    carList.Add(crModel);
                }
            }
            return View(carList);
        }

        public ActionResult CreateCar()
        {
            CarModel crModel = new CarModel();
            return View(crModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult CreateCar(CarModel cr)
        {
            using (CarCollectionEntities db = new CarCollectionEntities())
            {
                tblCarCollection car = new tblCarCollection();
                car.CarMkModel = cr.CarMkModel;
                car.Engine = cr.Engine;
                car.BodyType = cr.BodyType;
                car.Transmission = cr.Transmission;
                car.Year = cr.Year;
                car.Color = cr.Color;
                car.Value = cr.Value;

                db.tblCarCollections.Add(car);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult UpdateCar(int id)
        {
            CarModel crModel = new CarModel();
            using (CarCollectionEntities db = new CarCollectionEntities())
            {
                var cr = db.tblCarCollections.FirstOrDefault(x => x.CarId == id);
                if(cr != null)
                {
                    crModel.CarId = cr.CarId;
                    crModel.CarMkModel = cr.CarMkModel;
                    crModel.Engine = cr.Engine;
                    crModel.BodyType = cr.BodyType;
                    crModel.Transmission = cr.Transmission;
                    crModel.Year = cr.Year;
                    crModel.Color = cr.Color;
                    crModel.Value = cr.Value;
                }
            }
            return View(crModel);
        }

        [HttpPost]
        public ActionResult UpdateCar(CarModel crModel)
        {
            using (CarCollectionEntities db = new CarCollectionEntities())
            {
                var car = db.tblCarCollections.FirstOrDefault(x => x.CarId == crModel.CarId);
                car.CarMkModel = crModel.CarMkModel;
                car.Engine = crModel.Engine;
                car.BodyType = crModel.BodyType;
                car.Transmission = crModel.Transmission;
                car.Year = crModel.Year;
                car.Color = crModel.Color;
                car.Value = crModel.Value;

                db.Entry(car).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }


        public ActionResult Delete(int id)
        {
            CarModel carModel = new CarModel();
            using (CarCollectionEntities db = new CarCollectionEntities()) 
            {
                var car = db.tblCarCollections.FirstOrDefault(x => x.CarId == id);
                if(car != null)
                {
                    carModel.CarId = car.CarId;
                    carModel.CarMkModel = car.CarMkModel;
                    carModel.Engine = car.Engine;
                    carModel.BodyType = car.BodyType;
                    carModel.Transmission = car.Transmission;
                    carModel.Year = car.Year;
                    carModel.Color = car.Color;
                    carModel.Value = car.Value;
                }
            }

            return View(carModel);
        }

        [HttpPost]
        public ActionResult Delete(CarModel model)
        {
            using (CarCollectionEntities db = new CarCollectionEntities())
            {
                var carModel = db.tblCarCollections.FirstOrDefault(x => x.CarId == model.CarId);
                carModel.CarMkModel = model.CarMkModel;
                carModel.Engine = model.Engine;
                carModel.BodyType = model.BodyType;
                carModel.Transmission = model.Transmission;
                carModel.Year = model.Year;
                carModel.Color = model.Color;
                carModel.Value = model.Value;

                db.Entry(carModel).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Details(int id)
        {
            CarModel carModel = new CarModel();
            using (CarCollectionEntities db = new CarCollectionEntities())
            {
                var car = db.tblCarCollections.FirstOrDefault(x => x.CarId == id);
                if(car != null)
                {
                    carModel.CarId = car.CarId;
                    carModel.CarMkModel = car.CarMkModel;
                    carModel.Engine = car.Engine;
                    carModel.BodyType = car.BodyType;
                    carModel.Transmission = car.Transmission;
                    carModel.Year = car.Year;
                    carModel.Color = car.Color;
                    carModel.Value = car.Value;
                }
            }
            return View(carModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}