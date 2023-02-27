using System.ComponentModel.DataAnnotations;

namespace Product2.Models
{
    public class StockDetails
    {
        [Key]
        public string? StockId { get; set; }
        public string? SupplierId { get; set; }
        public string? ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string? Unit { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

	//StockId varchar(10) primary key,
	//SupplierId varchar(10),
	//ProductId varchar(10),
	//Price decimal(12,2),
	//Quantity decimal(5,2),
	//Unit varchar(10),
	//TotalAmount decimal(12,2),
	//Status varchar(100),
	//CreateDate datetime,
	//UpdateDate datetime,
    }
}
