using Microsoft.EntityFrameworkCore.Infrastructure;
using Product2.Models;
using Product2.ViewModels;

namespace Product2.Services
{
    public interface IRepoStockDetails_RepoStockDetails
    {
        List<StockDetails> GetAll();
        List<StockDetailsVM> GetAllCustom();
        public StockDetailsVM2 GetAllCustom2();
        public StockDetailsVM3 GetAllCustom3();
        public StockDetails GetByID(string id);
        public string AddObj(StockDetails info);
        public string UpdateObj(StockDetails info);
        public string DeleteObj(string id);
    }
    public class RepoStockDetails : IRepoStockDetails_RepoStockDetails
    {
        #region Codes of Implementation
        private readonly AppDbContext _appDbContext;

        public RepoStockDetails(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public RepoStockDetails()
        {
        }

        public string AddObj(StockDetails StockDetails)
        {
            _appDbContext.StockDetails.Add(StockDetails);
            _appDbContext.SaveChanges();
            return "Success";
        }

        public string UpdateObj(StockDetails info)
        {
            _appDbContext.SaveChanges();
            return "Success";
        }

        public List<StockDetails> GetAll()
        {
            return _appDbContext.StockDetails.ToList();
        }

        public StockDetails GetByID(string id)
        {
            foreach (var element in _appDbContext.StockDetails)
            {
                if (element.StockId == id)
                {
                    return element;
                }
            }
            string var = "False";
            StockDetails productInfo = new StockDetails();
            productInfo.StockId = var;
            return productInfo;
        }

        public string DeleteObj(string id)
        {
            var productInfo = GetByID(id);
            string result = "Something Error!";
            if (productInfo.StockId == "False")
            {
                return result;
            }
            else
            {
                _appDbContext.StockDetails.Remove(productInfo);
                _appDbContext.SaveChanges();
                result = "Success";
            }
            return result;
        }

        public List<StockDetailsVM> GetAllCustom()
        {
            var stockDetailsList = _appDbContext.StockDetails.ToList();

            var unitInfoList = _appDbContext.UnitInfo.ToList();
            var supplierInfoList = _appDbContext.SupplierInfo.ToList();
            var productInfoList = _appDbContext.ProductInfo.ToList();


            var StockDetailsRecord = from sd in stockDetailsList
                                 join si in supplierInfoList on sd.SupplierId equals si.SupplierId into table1
                                 from si in table1.ToList()
                                 join pi in productInfoList on sd.ProductId equals pi.ProductId into table2
                                 from pi in table2.ToList()
                                 join ui in unitInfoList on sd.Unit equals ui.UnitId into table3
                                 from ui in table3.ToList()
                                 select new StockDetailsVM
                                 {
                                     StockDetails = sd,
                                     SupplierInfo = si,
                                     ProductInfo = pi,
                                     UnitInfo = ui,
                                 };
            return StockDetailsRecord.ToList();  //List of single models
        }
        public StockDetailsVM2 GetAllCustom2()
        {
            var stockDetailsList = _appDbContext.StockDetails.ToList();

            var unitInfoList = _appDbContext.UnitInfo.ToList();
            var supplierInfoList = _appDbContext.SupplierInfo.ToList();
            var productInfoList = _appDbContext.ProductInfo.ToList();


            var model = new StockDetailsVM2
            {
                StockDetails = stockDetailsList,
                SupplierInfo = supplierInfoList,
                ProductInfo = productInfoList,
                UnitInfo = unitInfoList
            };

            return model;   //List of list models
        }

        public StockDetailsVM3 GetAllCustom3()
        {
            var model = new StockDetailsVM3();
            model.LVM = GetAllCustom();
            model.VM2 = GetAllCustom2();
            return model;
        }
        #endregion
    }
}
