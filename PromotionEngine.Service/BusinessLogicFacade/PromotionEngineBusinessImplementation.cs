using PromotionEngine.Model.DataModel;
using PromotionEngine.Model.ViewModel;
using PromotionEngine.Service.BusinessLogicFacade.Interface;
using PromotionEngine.Service.Repository;
using PromotionEngine.Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.BusinessLogicFacade
{
    public class PromotionEngineBusinessImplementation : IPromotionEngineBusiness
    {
        private static IPromorionEngineRepository promotionEngineRepository;

        public PromotionEngineBusinessImplementation()
        {
            promotionEngineRepository = new PromorionEngineRepositoryImplementation();
        }

        public void AddNewProduct(string product, int unitPrice)
        {
            promotionEngineRepository.AddNewProduct(product, unitPrice);
        }

        public decimal CalculateNetPrice(string product, int unit)
        {
            decimal netPrice = 0;

            if (product.Equals("1"))
            {
                int q = Math.DivRem(unit, 3, out int r);
                netPrice = q * 130 + r * 50;

            }
            else if (product.Equals("2"))
            {
                int q = Math.DivRem(unit, 2, out int r);
                netPrice = q * 45 + r * 30;

            }
            else if (product.Equals("3"))
            {
                netPrice = unit * 20;

            }
            else if (product.Equals("4"))
            {
                netPrice = unit * 15;

            }
            return netPrice;

        }

        public List<SKU_Unit_Price_ViewModel> GetProductList()
        {
            List<SKU_Unit_Price_ViewModel> productListViewModel = null;

            List<SKU_UNIT_PRICE> productListDataModel = promotionEngineRepository.GetProductList();
            
            if(null != productListDataModel)
            {
                productListViewModel = new List<SKU_Unit_Price_ViewModel>();

                foreach (var item in productListDataModel)
                {
                    productListViewModel.Add(new SKU_Unit_Price_ViewModel()
                    {
                        Id = item.Id,
                        Sku = item.Sku,
                        Price = item.Price
                    });
                }
                
            }

            return productListViewModel;

        }
    }
}
