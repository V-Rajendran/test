using PromotionEngine.Model.ViewModel;
using PromotionEngine.Service.BusinessLogicFacade;
using PromotionEngine.Service.BusinessLogicFacade.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PromotionEngine.Controllers
{
    public class PromotionEngineController : Controller
    {
        private static IPromotionEngineBusiness _promotionEngineBusiness;

        public PromotionEngineController()
        {
            _promotionEngineBusiness = new PromotionEngineBusinessImplementation();
        }

        // GET: PromotionEngine
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Add New Product
        /// </summary>
        /// <returns>Add New Product View</returns>
        [HttpGet]
        public ActionResult AddNewProduct()
        {
            return View();
        }
        /// <summary>
        /// Add New Product
        /// </summary>
        /// <param name="product"></param>
        /// <param name="unitPrice"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddNewProduct(string product, int unitPrice)
        {
            _promotionEngineBusiness.AddNewProduct(product, unitPrice);
            return View();
        }

        /// <summary>
        /// Promotion View
        /// </summary>
        /// <returns>View</returns>
        [HttpGet]
        public ActionResult Promotions()
        {
            List<SKU_Unit_Price_ViewModel> productList = _promotionEngineBusiness.GetProductList();
            
            if(null != productList)
            {
                ViewBag.Products = productList;
                return View();
            }
            return HttpNotFound();
            
        }

        /// <summary>
        /// Get Net Price
        /// </summary>
        /// <param name="product"></param>
        /// <param name="unit"></param>
        /// <returns>Net Price</returns>
        public decimal GetNetPrice(string product, int unit)
        {
            decimal netPrice = _promotionEngineBusiness.CalculateNetPrice(product, unit);
            return netPrice;
        }
    }
}