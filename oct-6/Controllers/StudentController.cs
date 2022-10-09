﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using oct_6.Models;

namespace oct_6.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<ProductModel> prodList = new List<ProductModel>();
            prodList.Add(new ProductModel { Prodid = 1, Prodname = "book", ManufacturingDate = new DateTime(2021, 03, 06) });
            prodList.Add(new ProductModel { Prodid = 2, Prodname = "pen", ManufacturingDate = new DateTime(2022, 04, 07) });
            prodList.Add(new ProductModel { Prodid = 3, Prodname = "pencil", ManufacturingDate = new DateTime(2020, 05, 09) });

            ViewBag.customers = prodList;
            return View();
        }
    }
}