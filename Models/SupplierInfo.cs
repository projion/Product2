using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Numerics;

namespace Product2.Models
{
    public class SupplierInfo
    {
        [Key]
        public string? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }

	    //SupplierId varchar(10) primary key,
	    //SupplierName varchar(50),
	    //Address varchar(300),
	    //Phone varchar(15),
    }
}
