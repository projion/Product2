using Product2.Models;

namespace Product2.ViewModels
{
    public class StockDetailsVM
    {
        public StockDetails StockDetails { get; set; }
        //public List<StockDetails> stockDetailsList { get; set; }
        //public List<StockDetails2> stockDetailsList2 { get; set; }


        public UnitInfo UnitInfo { get; set; }
        public SupplierInfo SupplierInfo { get; set; }
        public ProductInfo ProductInfo { get; set; }
        //public List<StockDetailsVM> customStockDetailsVM { get; set; }
    }
}
