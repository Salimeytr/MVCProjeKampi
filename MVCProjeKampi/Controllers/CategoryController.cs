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
    public class CategoryController : Controller
    {
        // GET: Category1
        // GET: Category
        //BusinessLayer da oluşturduğumuz sınıfı buraya çağurmamız gerekiyor.
        CategoryManager cm = new CategoryManager(new EfCategoryDal()); //DataAccessLayer ın içinde yer alan klasörden değerleri alıyoruz
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {//yukarıda cm yi tanımladık ki şu aşamad kullanabilelim.
            var categoryvalues = cm.GetList();
            return View(categoryvalues);//view döndürürken categoryvalues isimdeki dğeişkendeki değerleri de getir.Bu değişkene atamış olduğum değerler view e aktarılmış oldu.

        }
        [HttpGet]
        public ActionResult AddCategory()

        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //cm.CategororyAddBl(p);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors) //results dan gelen errorlardan bir döngü oluşturalım.
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }
       
    }
}