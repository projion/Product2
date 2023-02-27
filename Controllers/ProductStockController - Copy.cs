//using Microsoft.AspNetCore.Mvc;
//using Product2.Models;
//using Product2.Services;
//using Product2.ViewModels;

//namespace Product2.Controllers
//{
//    public class ProductStockController : Controller
//    {
//        private readonly IRepoProductInfo repoProductInfo;
//        private readonly IRepoStatusInfo_RepoStatusInfo repoStatusInfo;
//        private readonly IRepoUnitInfo_RepoUnitInfo repoUnitInfo;
//        private readonly IRepoSupplierInfo_RepoSupplierInfo repoSupplierInfo;
//        private readonly IRepoStockDetails_RepoStockDetails repoStockDetails;
//        private readonly IRepoStockMaster_RepoStockMaster repoStockMaster;

//        //public ProductStockController(IRepoProductInfo repoProductInfo, IRepoStatusInfo_RepoStatusInfo repoStatusInfo,
//        //    IRepoUnitInfo_RepoUnitInfo repoUnitInfo, IRepoSupplierInfo_RepoSupplierInfo repoSupplierInfo,
//        //    IRepoStockDetails_RepoStockDetails repoStockDetails, IRepoStockMaster_RepoStockMaster repoStockMaster)
//        public ProductStockController(IRepoProductInfo repoProductInfo, IRepoStatusInfo_RepoStatusInfo repoStatusInfo,
//            IRepoUnitInfo_RepoUnitInfo repoUnitInfo, IRepoSupplierInfo_RepoSupplierInfo repoSupplierInfo,
//            IRepoStockDetails_RepoStockDetails repoStockDetails)
//        {
//            this.repoProductInfo = repoProductInfo;
//            this.repoStatusInfo = repoStatusInfo;
//            this.repoUnitInfo = repoUnitInfo;
//            this.repoSupplierInfo = repoSupplierInfo;
//            this.repoStockDetails = repoStockDetails;
//            this.repoStockMaster = repoStockMaster;
//        }
//        //public IActionResult Index()
//        //{
//        //    return View();
//        //}
//        #region All functionality of ProductInfo Model
//        public IActionResult ProductInfo()
//        {
//            ProductInfoVM model = new ProductInfoVM();
//            model.productInfoList = repoProductInfo.GetAll();
//            return View(model);
//        }
//        [HttpPost]
//        public IActionResult AddUpdate(ProductInfo ProductInfo)
//        {
//            string url = Request.Headers["Referer"].ToString();
//            //if (ModelState.IsValid)

//            var info = repoProductInfo.GetByID(ProductInfo.ProductId);
//            string result = "Something Error";
//            #region Code for create object
//            if (info.ProductId == "False")
//            {
//                var element = repoProductInfo.GetAll();
//                var lastItem = element.Last();
//                var lastItemStr = lastItem.ProductId.ToString();
//                int lastID = Convert.ToInt32(lastItemStr) + 1;

//                info.ProductId = lastID.ToString();
//                info.ProductName = ProductInfo.ProductName;
//                info.CurrentPrice = ProductInfo.CurrentPrice;
//                info.Status = ProductInfo.Status;
//                info.SetupDate = DateTime.Now;
//                info.UpdateDate = DateTime.Now;
//                result = repoProductInfo.AddObj(info);
//                //Console.WriteLine(result);
//                //ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
//                //return View(element);
//            }
//            #endregion
//            #region Code of Update Object
//            else if (info.ProductId != null)
//            {
//                //info.ProductId = ProductInfo.ProductId;
//                info.ProductName = ProductInfo.ProductName;
//                info.CurrentPrice = ProductInfo.CurrentPrice;
//                info.Status = ProductInfo.Status;
//                //info.SetupDate = ProductInfo.UpdateDate;
//                info.UpdateDate = DateTime.Now;
//                result = repoProductInfo.UpdateObj(info);
//                //return Redirect(url);
//            }
//            #endregion
//            if (result == "Save Successfully")
//            {
//                TempData["SuccessMsg"] = "Save Successfully";
//                return Redirect(url);
//            }
//            else
//            {
//                TempData["ErrorMsg"] = result;
//                return Redirect(url);
//            }
//        }
//        [HttpPost]
//        public IActionResult Delete(string ProductId)
//        {
//            //string url = Request.Headers["Referer"].ToString();
//            string result = repoProductInfo.DeleteObj(ProductId);
//            if (result == "Success")
//            { return Json(new { message = "Delete Successfully" }); }
//            else { return Json(new { message = "Error Occured" }); }
//            //return Redirect(url);
//        }
//        #endregion

//        #region All functionality of UnitInfo Model
//        public IActionResult UnitInfo()
//        {
//            UnitInfoVM model = new UnitInfoVM();
//            model.unitInfoList = repoUnitInfo.GetAll();
//            return View(model);
//        }
//        [HttpPost]
//        public IActionResult AddUpdateUnitInfo(UnitInfo UnitInfo)
//        {
//            string url = Request.Headers["Referer"].ToString();
//            //if (ModelState.IsValid)

//            var info = repoUnitInfo.GetByID(UnitInfo.UnitId);
//            string result = "Something Error";
//            #region Code for create object
//            if (info.UnitId == "False")
//            {
//                var element = repoUnitInfo.GetAll();
//                var lastItem = element.Last();
//                var lastItemStr = lastItem.UnitId.ToString();
//                int lastID = Convert.ToInt32(lastItemStr) + 1;

//                info.UnitId = lastID.ToString();
//                info.UnitName = UnitInfo.UnitName;
//                info.Description = UnitInfo.Description;
//                info.CreateDate = DateTime.Now;
//                info.UpdateDate = DateTime.Now;
//                result = repoUnitInfo.AddObj(info);
//                //Console.WriteLine(result);
//                //ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
//                //return View(element);
//            }
//            #endregion
//            #region Code of Update Object
//            else if (info.UnitId != null)
//            {
//                //info.UnitId = UnitInfo.UnitId;
//                info.UnitName = UnitInfo.UnitName;
//                info.Description = UnitInfo.Description;
//                //info.CreateDate = UnitInfo.UpdateDate;
//                info.UpdateDate = DateTime.Now;
//                result = repoUnitInfo.UpdateObj(info);
//                //return Redirect(url);
//            }
//            #endregion
//            if (result == "Save Successfully")
//            {
//                TempData["SuccessMsg"] = "Save Successfully";
//                return Redirect(url);
//            }
//            else
//            {
//                TempData["ErrorMsg"] = result;
//                return Redirect(url);
//            }
//        }
//        [HttpPost]
//        public IActionResult DeleteUnitInfo(string UnitId)
//        {
//            //string url = Request.Headers["Referer"].ToString();
//            string result = repoUnitInfo.DeleteObj(UnitId);
//            if (result == "Success")
//            { return Json(new { message = "Delete Successfully" }); }
//            else { return Json(new { message = "Error Occured" }); }
//            //return Redirect(url);
//        }

//        #endregion

//        #region All functionality of StatusInfo Model
//        public IActionResult StatusInfo()
//        {
//            StatusInfoVM model = new StatusInfoVM();
//            model.StatusInfoList = repoStatusInfo.GetAll();
//            return View(model);
//        }
//        [HttpPost]
//        public IActionResult AddUpdateStatusInfo(StatusInfo StatusInfo)
//        {
//            string url = Request.Headers["Referer"].ToString();
//            //if (ModelState.IsValid)

//            var info = repoStatusInfo.GetByID(StatusInfo.StatusId);
//            string result = "Something Error";
//            #region Code for create object
//            if (info.StatusId == "False")
//            {
//                var element = repoStatusInfo.GetAll();
//                var lastItem = element.Last();
//                var lastItemStr = lastItem.StatusId.ToString();
//                int lastID = Convert.ToInt32(lastItemStr) + 1;

//                info.StatusId = lastID.ToString();
//                info.StatusName = StatusInfo.StatusName;
//                info.Description = StatusInfo.Description;
//                info.CreateDate = DateTime.Now;
//                info.UpdateDate = DateTime.Now;
//                result = repoStatusInfo.AddObj(info);

//            }
//            #endregion
//            #region Code of Update Object
//            else if (info.StatusId != null)
//            {
//                //info.StatusId = StatusInfo.StatusId;
//                info.StatusName = StatusInfo.StatusName;
//                info.Description = StatusInfo.Description;
//                //info.CreateDate = StatusInfo.UpdateDate;
//                info.UpdateDate = DateTime.Now;
//                result = repoStatusInfo.UpdateObj(info);
//                //return Redirect(url);
//            }
//            #endregion
//            if (result == "Save Successfully")
//            {
//                TempData["SuccessMsg"] = "Save Successfully";
//                return Redirect(url);
//            }
//            else
//            {
//                TempData["ErrorMsg"] = result;
//                return Redirect(url);
//            }
//        }
//        [HttpPost]
//        public IActionResult DeleteStatusInfo(string StatusId)
//        {
//            //string url = Request.Headers["Referer"].ToString();
//            string result = repoStatusInfo.DeleteObj(StatusId);
//            if (result == "Success")
//            { return Json(new { message = "Delete Successfully" }); }
//            else { return Json(new { message = "Error Occured" }); }
//            //return Redirect(url);
//        }
//        #endregion

//        #region All functionality of SupplierInfo Model
//        public IActionResult SupplierInfo()
//        {
//            SupplierInfoVM model = new SupplierInfoVM();
//            model.SupplierInfoList = repoSupplierInfo.GetAll();
//            return View(model);
//        }
//        [HttpPost]
//        public IActionResult AddUpdateSupplierInfo(SupplierInfo SupplierInfo)
//        {
//            string url = Request.Headers["Referer"].ToString();
//            //if (ModelState.IsValid)

//            var info = repoSupplierInfo.GetByID(SupplierInfo.SupplierId);
//            string result = "Something Error";
//            #region Code for create object
//            if (info.SupplierId == "False")
//            {
//                var element = repoSupplierInfo.GetAll();
//                var lastItem = element.Last();
//                var lastItemStr = lastItem.SupplierId.ToString();
//                int lastID = Convert.ToInt32(lastItemStr) + 1;

//                info.SupplierId = lastID.ToString();
//                info.SupplierName = SupplierInfo.SupplierName;
//                info.Address = SupplierInfo.Address;
//                info.Phone = SupplierInfo.Phone;
//                result = repoSupplierInfo.AddObj(info);
//                //Console.WriteLine(result);
//                //ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
//                //return View(element);
//            }
//            #endregion
//            #region Code of Update Object
//            else if (info.SupplierId != null)
//            {
//                //info.SupplierId = SupplierInfo.SupplierId;
//                info.SupplierName = SupplierInfo.SupplierName;
//                info.Address = SupplierInfo.Address;
//                info.Phone = SupplierInfo.Phone;
//                //info.SetupDate = SupplierInfo.UpdateDate;
//                result = repoSupplierInfo.UpdateObj(info);
//                //return Redirect(url);
//            }
//            #endregion
//            if (result == "Save Successfully")
//            {
//                TempData["SuccessMsg"] = "Save Successfully";
//                return Redirect(url);
//            }
//            else
//            {
//                TempData["ErrorMsg"] = result;
//                return Redirect(url);
//            }
//        }
//        [HttpPost]
//        public IActionResult DeleteSupplierInfo(string SupplierId)
//        {
//            //string url = Request.Headers["Referer"].ToString();
//            string result = repoSupplierInfo.DeleteObj(SupplierId);
//            if (result == "Success")
//            { return Json(new { message = "Delete Successfully" }); }
//            else { return Json(new { message = "Error Occured" }); }
//            //return Redirect(url);
//        }
//        #endregion

//        #region All functionality of StockDetails Model
//        public IActionResult StockDetails()
//        {
//            //StockDetailsVM modelzz = new StockDetailsVM();
//            var model = repoStockDetails.GetAllCustom3();
//            return View(model);
//        }
//        [HttpPost]
//        public IActionResult AddUpdateStockDetails(StockDetails StockDetails)
//        {
//            string url = Request.Headers["Referer"].ToString();
//            //if (ModelState.IsValid)

//            var info = repoStockDetails.GetByID(StockDetails.StockId);
//            string result = "Something Error";
//            #region Code for create object
//            if (info.StockId == "False")
//            {
//                var element = repoStockDetails.GetAll();
//                var lastItem = element.Last();
//                var lastItemStr = lastItem.StockId.ToString();
//                int lastID = Convert.ToInt32(lastItemStr) + 1;

//                info.StockId = lastID.ToString();
//                info.SupplierId = StockDetails.SupplierId;
//                info.ProductId = StockDetails.ProductId;
//                info.Price = StockDetails.Price;
//                info.Quantity = StockDetails.Quantity;
//                info.Unit = StockDetails.Unit;
//                info.Status = StockDetails.Status;
//                info.CreateDate = DateTime.Now;
//                info.UpdateDate = DateTime.Now;
//                result = repoStockDetails.AddObj(info);
//                //Console.WriteLine(result);
//                //ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
//                //return View(element);
//            }
//            #endregion
//            #region Code of Update Object
//            else if (info.StockId != null)
//            {
//                //info.StockId = StockDetails.StockId;
//                info.SupplierId = StockDetails.SupplierId;
//                info.ProductId = StockDetails.ProductId;
//                info.Price = StockDetails.Price;
//                info.Quantity = StockDetails.Quantity;
//                info.Unit = StockDetails.Unit;
//                info.Status = StockDetails.Status;
//                info.UpdateDate = DateTime.Now;
//                result = repoStockDetails.UpdateObj(info);
//                //return Redirect(url);
//            }
//            #endregion
//            if (result == "Save Successfully")
//            {
//                TempData["SuccessMsg"] = "Save Successfully";
//                return Redirect(url);
//            }
//            else
//            {
//                TempData["ErrorMsg"] = result;
//                return Redirect(url);
//            }
//        }
//        [HttpPost]
//        public IActionResult DeleteStockDetails(string StockId)
//        {
//            //string url = Request.Headers["Referer"].ToString();
//            string result = repoStockDetails.DeleteObj(StockId);
//            if (result == "Success")
//            { return Json(new { message = "Delete Successfully" }); }
//            else { return Json(new { message = "Error Occured" }); }
//            //return Redirect(url);
//        }
//        #endregion

//        #region All functionality of StockMaster Model
//        //public IActionResult StockMaster()
//        //{
//        //    StockMasterVM model = new StockMasterVM();
//        //    model.stockMasterList = repoStockMaster.GetAll();
//        //    return View(model);
//        //}
//        //[HttpPost]
//        //public IActionResult AddUpdateStockMaster(StockMaster StockMaster)
//        //{
//        //    string url = Request.Headers["Referer"].ToString();
//        //    //if (ModelState.IsValid)

//        //    var info = repoStockMaster.GetByID(StockMaster.TransactionId);
//        //    string result = "Something Error";
//        //    #region Code for create object
//        //    if (info.TransactionId == "False")
//        //    {
//        //        var element = repoStockMaster.GetAll();
//        //        var lastItem = element.Last();
//        //        var lastItemStr = lastItem.TransactionId.ToString();
//        //        int lastID = Convert.ToInt32(lastItemStr) + 1;

//        //        info.TransactionId= lastID.ToString();
//        //        info.SupplierId= StockMaster.SupplierId;
//        //        info.TotalAmount= StockMaster.TotalAmount;
//        //        info.Status= StockMaster.Status;
//        //        info.SetupDate= DateTime.Now; 
//        //        info.UpdateDate= DateTime.Now;
//        //        info.CreatedBy = StockMaster.CreatedBy;
//        //        result = repoStockMaster.AddObj(info);
//        //        //Console.WriteLine(result);
//        //        //ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
//        //        //return View(element);
//        //    }
//        //    #endregion
//        //    #region Code of Update Object
//        //    else if (info.TransactionId != null)
//        //    {
//        //        //info.TransactionId = StockMaster.TransactionId;
//        //        info.SupplierId = StockMaster.SupplierId;
//        //        info.TotalAmount = StockMaster.TotalAmount;
//        //        info.Status = StockMaster.Status;
//        //        info.CreatedBy= StockMaster.CreatedBy;
//        //        //info.SetupDate = StockMaster.UpdateDate;
//        //        info.UpdateDate = DateTime.Now;
//        //        result = repoStockMaster.UpdateObj(info);
//        //        //return Redirect(url);
//        //    }
//        //    #endregion
//        //    if (result == "Save Successfully")
//        //    {
//        //        TempData["SuccessMsg"] = "Save Successfully";
//        //        return Redirect(url);
//        //    }
//        //    else
//        //    {
//        //        TempData["ErrorMsg"] = result;
//        //        return Redirect(url);
//        //    }
//        //}
//        //[HttpPost]
//        //public IActionResult DeleteStockMaster(string TransactionId)
//        //{
//        //    //string url = Request.Headers["Referer"].ToString();
//        //    string result = repoStockMaster.DeleteObj(TransactionId);
//        //    if (result == "Success")
//        //    { return Json(new { message = "Delete Successfully" }); }
//        //    else { return Json(new { message = "Error Occured" }); }
//        //    //return Redirect(url);
//        //}
//        #endregion

//    }
//}
