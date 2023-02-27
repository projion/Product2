using Product2.Models;

namespace Product2.Services
{
    public interface IRepoSupplierInfo_RepoSupplierInfo
    {
        List<SupplierInfo> GetAll();
        SupplierInfo GetByID(string id);
        public string AddObj(SupplierInfo info);
        public string UpdateObj(SupplierInfo info);
        public string DeleteObj(string id);
    }
    public class RepoSupplierInfo : IRepoSupplierInfo_RepoSupplierInfo
    {
        #region Codes of Implementation
        private readonly AppDbContext _appDbContext;

        public RepoSupplierInfo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string AddObj(SupplierInfo SupplierInfo)
        {
            _appDbContext.SupplierInfo.Add(SupplierInfo);
            _appDbContext.SaveChanges();
            return "Success";
        }

        public string UpdateObj(SupplierInfo info)
        {
            _appDbContext.SaveChanges();
            return "Success";
        }

        public List<SupplierInfo> GetAll()
        {
            return _appDbContext.SupplierInfo.ToList();
        }

        public SupplierInfo GetByID(string id)
        {
            foreach (var element in _appDbContext.SupplierInfo)
            {
                if (element.SupplierId == id)
                {
                    return element;
                }
            }
            string var = "False";
            SupplierInfo productInfo = new SupplierInfo();
            productInfo.SupplierId = var;
            return productInfo;
        }

        public string DeleteObj(string id)
        {
            var productInfo = GetByID(id);
            string result = "Something Error!";
            if (productInfo.SupplierId == "False")
            {
                return result;
            }
            else
            {
                _appDbContext.SupplierInfo.Remove(productInfo);
                _appDbContext.SaveChanges();
                result = "Success";
            }
            return result;
        }
        #endregion
    }
}
