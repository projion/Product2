using System.ComponentModel.DataAnnotations;

namespace Product2.Models
{
    public class UnitInfo
    {
        [Key]
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

	    //UnitId varchar(10) primary key,
	    //UnitName varchar(50),
	    //Description varchar(300),
	    //Status varchar(10),
	    //CreateDate datetime,
	    //UpdateDate datetime,
    }
}
