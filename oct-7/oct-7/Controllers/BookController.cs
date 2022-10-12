using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bal;
using helper;
using oct_7.Models;


namespace oct_7.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        Employee_Helper helper = null;
        public BookController()
        {
            helper = new Employee_Helper();
        }

        public ActionResult Index()
        {
            var emplist = helper.dispEmployeeList();
            List<EmpModel> modelsList = new List<EmpModel>();
            foreach (var item in emplist)
            {
                modelsList.Add(new EmpModel
                {
                    book_id = item.book_id,
                    book_name = item.book_name,
                    book_author = item.book_author
                });
            }

            return View(modelsList);
        }



        public ActionResult Details(int id)
        {
            var data = helper.searchEmployee(id);
            EmpModel emp = new EmpModel();
            emp.book_id = id;
            emp.book_name = data.book_name;
            emp.book_author = data.book_author;

            return View(emp);

        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Employee_BAL bal = new Employee_BAL();
            bal.book_id = Convert.ToInt32(Request["book_id"]);
            bal.book_name = Request["book_name"].ToString();
            bal.book_author = Request["book_author"].ToString();


            bool ans = helper.AddEmployee(bal);
            if (ans)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var emp = helper.searchEmployee(id);
            EmpModel model = new EmpModel();
            model.book_id = id;
            model.book_name = emp.book_name;
            model.book_author = emp.book_author;



            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var emp = helper.searchEmployee(id);
                emp.book_id = Convert.ToInt32(Request["book_id"]);
                emp.book_name = Request["book_name"].ToString();
                emp.book_author = Request["book_author"].ToString();

                bool ans = helper.EditEmployee(emp);


                if (ans)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }


            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            var emp = helper.searchEmployee(id);
            EmpModel model = new EmpModel();
            model.book_id = id;
            model.book_name = emp.book_name;
            model.book_author = emp.book_author;



            return View(model);
        }


        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var dataFound = helper.searchEmployee(id);
                if (dataFound != null)
                {
                    bool ans = helper.removebook(id);
                    if (ans)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View();
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public PartialViewResult greet()
        {
            return PartialView();
        }
    }
}