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
        public List<SKU_UNIT_PRICE> GetProductList()
        {
            
           using(var context = new SKUDataModel())
            {
                return context.SKU_UNIT_PRICE.ToList();
            }
        }
    }
}
