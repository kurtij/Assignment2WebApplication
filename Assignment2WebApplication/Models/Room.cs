using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2WebApplication.Models
{
    public class Room
    {
        //RoomId
        [Key]
        public int RoomId { get; set; }
        //SuiteId
        [ForeignKey("Suite")]
        public int SuiteId { get; set; }
        //SuiteNumber
        [Column(TypeName = "nvarchar(999)")]
        [Required(ErrorMessage = "Required")]
        [DisplayName("Suite Number")]
        private int _SuiteNumber;
        public int SuiteNumber
        {
            get { return _SuiteNumber; }
            set
            {
                if (value <= 0) throw new InvalidOperationException();
                _SuiteNumber = value;
            }
        }
        //RoomNumber
        [Column(TypeName = "nvarchar(999)")]
        [DisplayName("Room Number")]
        private int _RoomNumber;
        public int RoomNumber
        {
            get { return _RoomNumber; }
            set
            {
                if (value <= 0) throw new InvalidOperationException();
                _RoomNumber = value;
            }
        }
        //RentAmount
        [Column(TypeName = "nvarchar(999)")]
        [DisplayName("Rent Amount($)")]
        private int _RentAmount;
        public int RentAmount
        {
            get { return _RentAmount; }
            set
            {
                if (value <= 0) throw new InvalidOperationException();
                _RentAmount = value;
            }
        }
        //Occupied
        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Occupied (Yes/No)")]
        private int OccupiedYesNo;
        private String _Occupied;
        public String Occupied
        {
            get { return _Occupied; }
            set
            {
                if (value.Equals("yes"))
                {
                    OccupiedYesNo = 1;
                }
                if (value.Equals("no"))
                {
                    OccupiedYesNo = 1;
                }
                if (OccupiedYesNo != 1) throw new Exception();
                _Occupied = value;
            }
        }
        //Window
        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Window (Yes/No)")]
        private int WindowYesNo;
        private String _Window;
        public String Window
        {
            get { return _Window; }
            set
            {
                if (value.Equals("yes"))
                {
                    WindowYesNo = 1;
                }
                if (value.Equals("no"))
                {
                    WindowYesNo = 1;
                }
                if (WindowYesNo != 1) throw new Exception();
                _Window = value;
            }
        }
        //Closit
        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Closit (Yes/No)")]
        private int ClositYesNo;
        private String _Closit;
        public String Closit
        {
            get { return _Closit; }
            set
            {
                if (value.Equals("yes"))
                {
                    ClositYesNo = 1;
                }
                if (value.Equals("no"))
                {
                    ClositYesNo = 1;
                }
                if (ClositYesNo != 1) throw new Exception();
                _Closit = value;
            }
        }
        //Bathroom
        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Private Bathroom (Yes/No)")]
        private int BathroomYesNo;
        private String _Bathroom;
        public String Bathroom
        {
            get { return _Bathroom; }
            set
            {
                if (value.Equals("yes"))
                {
                    BathroomYesNo = 1;
                }
                if (value.Equals("no"))
                {
                    BathroomYesNo = 1;
                }
                if (BathroomYesNo != 1) throw new Exception();
                _Bathroom = value;
            }
        }
        //Suite
        public Suite Suite { get; set; }
    }
}