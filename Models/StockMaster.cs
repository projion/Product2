using System.ComponentModel.DataAnnotations;

namespace Product2.Models
{
    public class StockMaster
    {
        [Key]
        public string? TransactionId { get; set; }
        public string? SupplierId { get; set; }
        public decimal TotalAmount { get; set; }
        public bool Status { get; set; }
        public DateTime SetupDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? CreatedBy { get; set; }

	//TransactionId varchar(10) primary key,
	//SupplierId varchar(10),
	//TotalAmount varchar(10),
	//Status BIT,
	//SetupDate datetime,
	//UpdateDate datetime,
	//CreatedBy varchar(30)
    }
}
