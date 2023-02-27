using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product2.Models;
using Product2.ViewModels;
using System.Xml.Linq;

namespace Product2.Services
{
    public class RepoProductInfo : IRepoProductInfo
    {
        #region Codes of Implementation
        private readonly AppDbContext _appDbContext;

        public RepoProductInfo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string AddObj(ProductInfo ProductInfo)
        {
            _appDbContext.ProductInfo.Add(ProductInfo);
            _appDbContext.SaveChanges();
            return "Success";
        }

        public string UpdateObj(ProductInfo info)
        {
            _appDbContext.SaveChanges();
            return "Success";
        }

        public List<ProductInfo> GetAll()
        {
            return _appDbContext.ProductInfo.ToList();
        }

        public ProductInfo GetByID(string id)
        {
            foreach (var element in _appDbContext.ProductInfo)
            {
                if (element.ProductId == id)
                {
                    return element;
                }
            }
            string var = "False";
            ProductInfo productInfo = new ProductInfo();
            productInfo.ProductId = var;
            return productInfo;
        }

        public string DeleteObj(string id)
        {
            var productInfo = GetByID(id);
            string result = "Something Error!";
            if (productInfo.ProductId == "False")
            {
                return result;
            }
            else
            {
                _appDbContext.ProductInfo.Remove(productInfo);
                _appDbContext.SaveChanges();
                result = "Success";
            }
            return result;
        }
        #endregion
    }
}
