using PromotionEngine.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.BusinessLogicFacade.Interface
{
    public interface IPromotionEngineBusiness
    {
        List<SKU_Unit_Price_ViewModel> GetProductList();
        decimal CalculateNetPrice(string product, int unit);
        void AddNewProduct(string product, int unitPrice);
    }
}
