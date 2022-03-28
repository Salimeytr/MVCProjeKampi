using BusisnessLayer.Concrate;
using BusisnessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


    namespace MVCProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryvalidator = new CategoryValidator();
            ValidationResult results = categoryvalidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
        public ActionResult DeleteCategory(int id)
        {

            var categoryvalue=cm.GetById(id);
            cm.CategoryDelete(categoryvalue); //categoryvalue dan gelen değişken silinecek.

            return RedirectToAction("Index"); //Silme işlemi bittiğinde tekrar Index e yönlendir
        }

    }
}