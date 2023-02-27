using Product2.Models;

namespace Product2.Services
{
    public interface IRepoUnitInfo_RepoUnitInfo
    {
        List<UnitInfo> GetAll();
        UnitInfo GetByID(string id);
        public string AddObj(UnitInfo info);
        public string UpdateObj(UnitInfo info);
        public string DeleteObj(string id);
    }
    public class RepoUnitInfo : IRepoUnitInfo_RepoUnitInfo
    {
        #region Codes of Implementation
        private readonly AppDbContext _appDbContext;

        public RepoUnitInfo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string AddObj(UnitInfo UnitInfo)
        {
            _appDbContext.UnitInfo.Add(UnitInfo);
            _appDbContext.SaveChanges();
            return "Success";
        }

        public string UpdateObj(UnitInfo info)
        {
            _appDbContext.SaveChanges();
            return "Success";
        }

        public List<UnitInfo> GetAll()
        {
            return _appDbContext.UnitInfo.ToList();
        }

        public UnitInfo GetByID(string id)
        {
            foreach (var element in _appDbContext.UnitInfo)
            {
                if (element.UnitId == id)
                {
                    return element;
                }
            }
            string var = "False";
            UnitInfo productInfo = new UnitInfo();
            productInfo.UnitId = var;
            return productInfo;
        }

        public string DeleteObj(string id)
        {
            var productInfo = GetByID(id);
            string result = "Something Error!";
            if (productInfo.UnitId == "False")
            {
                return result;
            }
            else
            {
                _appDbContext.UnitInfo.Remove(productInfo);
                _appDbContext.SaveChanges();
                result = "Success";
            }
            return result;
        }
        #endregion
    }
}
