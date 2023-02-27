using System.ComponentModel.DataAnnotations;

namespace Product2.Models
{
    public class StatusInfo
    {
        [Key]
        public string? StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

	//StatusId varchar(10) primary key,
	//StatusName varchar(50),
	//Description varchar(300),
	//CreateDate datetime,
	//UpdateDate datetime
    }
}
