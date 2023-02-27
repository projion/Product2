using Product2.Models;

namespace Product2.Services
{
    public interface IRepoStatusInfo_RepoStatusInfo
    {
        List<StatusInfo> GetAll();
        StatusInfo GetByID(string id);
        public string AddObj(StatusInfo info);
        public string UpdateObj(StatusInfo info);
        public string DeleteObj(string id);
    }
    public class RepoStatusInfo : IRepoStatusInfo_RepoStatusInfo
    {
        #region Codes of Implementation
        private readonly AppDbContext _appDbContext;

        public RepoStatusInfo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string AddObj(StatusInfo StatusInfo)
        {
            _appDbContext.StatusInfo.Add(StatusInfo);
            _appDbContext.SaveChanges();
            return "Success";
        }

        public string UpdateObj(StatusInfo info)
        {
            _appDbContext.SaveChanges();
            return "Success";
        }

        public List<StatusInfo> GetAll()
        {
            return _appDbContext.StatusInfo.ToList();
        }

        public StatusInfo GetByID(string id)
        {
            foreach (var element in _appDbContext.StatusInfo)
            {
                if (element.StatusId == id)
                {
                    return element;
                }
            }
            string var = "False";
            StatusInfo productInfo = new StatusInfo();
            productInfo.StatusId = var;
            return productInfo;
        }

        public string DeleteObj(string id)
        {
            var productInfo = GetByID(id);
            string result = "Something Error!";
            if (productInfo.StatusId == "False")
            {
                return result;
            }
            else
            {
                _appDbContext.StatusInfo.Remove(productInfo);
                _appDbContext.SaveChanges();
                result = "Success";
            }
            return result;
        }
        #endregion
    }
}
