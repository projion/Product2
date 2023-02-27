using Product2.Models;

namespace Product2.Services
{
    public interface IRepoProductInfo
    {
        List<ProductInfo> GetAll();
        ProductInfo GetByID(string id);
        public string AddObj(ProductInfo info);
        public string UpdateObj(ProductInfo info);
        public string DeleteObj(string id);

    }
}
