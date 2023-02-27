using Product2.Models;

namespace Product2.ViewModels
{
    public class StockDetailsVM2
    {
        public List<StockDetails> StockDetails { get; set; }
        //public List<StockDetails> stockDetailsList { get; set; }
        //public List<StockDetails2> stockDetailsList2 { get; set; }


        public IEnumerable<UnitInfo> UnitInfo { get; set; }
        public IEnumerable<SupplierInfo> SupplierInfo { get; set; }
        public IEnumerable<ProductInfo> ProductInfo { get; set; }
        //public List<StockDetailsVM> customStockDetailsVM { get; set; }
    }
}
