using Product2.Models;

namespace Product2.Services
{
    public interface IRepoStockMaster_RepoStockMaster
    {
        List<StockMaster> GetAll();
        StockMaster GetByID(string id);
        public string AddObj(StockMaster info);
        public string UpdateObj(StockMaster info);
        public string DeleteObj(string id);
    }
    public class RepoStockMaster : IRepoStockMaster_RepoStockMaster
    {
        #region Codes of Implementation
        private readonly AppDbContext _appDbContext;

        public RepoStockMaster(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string AddObj(StockMaster StockMaster)
        {
            _appDbContext.StockMaster.Add(StockMaster);
            _appDbContext.SaveChanges();
            return "Success";
        }

        public string UpdateObj(StockMaster info)
        {
            _appDbContext.SaveChanges();
            return "Success";
        }

        public List<StockMaster> GetAll()
        {
            return _appDbContext.StockMaster.ToList();
        }

        public StockMaster GetByID(string id)
        {
            foreach (var element in _appDbContext.StockMaster)
            {
                if (element.TransactionId == id)
                {
                    return element;
                }
            }
            string var = "False";
            StockMaster productInfo = new StockMaster();
            productInfo.TransactionId = var;
            return productInfo;
        }

        public string DeleteObj(string id)
        {
            var productInfo = GetByID(id);
            string result = "Something Error!";
            if (productInfo.TransactionId == "False")
            {
                return result;
            }
            else
            {
                _appDbContext.StockMaster.Remove(productInfo);
                _appDbContext.SaveChanges();
                result = "Success";
            }
            return result;
        }
        #endregion
    }
}
