using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WebApplication.Models
{
    public class Suite
    {
        //SuiteId
        [Key]
        public int SuiteId { get; set; }
        //SuiteNumber
        [Column(TypeName = "nvarchar(999)")]
        [Required(ErrorMessage = "Required")]
        [DisplayName("Suite Number")]
        public int SuiteNumber { get; set; }
        //SuiteBuzzCode
        [Column(TypeName = "nvarchar(999)")]
        [DisplayName("Suite Buzz Code")]
        public int SuiteBuzzCode { get; set; }
        //SqFootage
        [Column(TypeName = "nvarchar(999)")]
        [DisplayName("Square Footage")]
        public int SqFootage { get; set; }
        //NumberOfRooms
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Number of Rooms")]
        public int NumberOfRooms { get; set; }
        //NumberOfBathrooms
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Number of Bathrooms")]
        public int NumberOfBathrooms { get; set; }
        //Rooms collection
        public ICollection<Room> Rooms { get; set; }
    }
}