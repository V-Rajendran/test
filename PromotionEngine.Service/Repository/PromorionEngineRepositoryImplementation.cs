using PromotionEngine.Model.DataModel;
using PromotionEngine.Service.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.Repository
{
    public class PromorionEngineRepositoryImplementation : IPromorionEngineRepository
    {
        public void AddNewProduct(string product, int unitPrice)
        {
            SKU_UNIT_PRICE dataModel = new SKU_UNIT_PRICE();

            dataModel.Sku = product;
            dataModel.Price = unitPrice;
            using (var context = new SKUDataModel())
            {
                context.SKU_UNIT_PRICE.Add(dataModel);
                context.SaveChanges();
            }

        }

        public List<SKU_UNIT_PRICE> GetProductList()
        {
            
           using(var context = new SKUDataModel())
            {
                return context.SKU_UNIT_PRICE.ToList();
            }
        }
    }
}
