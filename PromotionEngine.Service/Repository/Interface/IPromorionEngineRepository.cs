using PromotionEngine.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.Repository.Interface
{
    public interface IPromorionEngineRepository
    {
        List<SKU_UNIT_PRICE> GetProductList();
    }
}
