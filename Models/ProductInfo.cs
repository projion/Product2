using System.ComponentModel.DataAnnotations;

namespace Product2.Models
{
    public class ProductInfo
    {
        [Key]  //USED FOR INDICATING PK
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal CurrentPrice { get; set; }
        public string? Status { get; set; }
        public DateTime SetupDate { get; set; }
        public DateTime UpdateDate { get; set; }

	    //ProductId varchar(10) primary key,
	    //ProductName varchar(50),
	    //CurrentPrice decimal(12,2),
	    //--Status BIT,
	    //Status varchar(10),
	    //SetupDate datetime,
	    //UpdateDate datetime,
    }
}
