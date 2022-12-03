using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arac_Kiralama_Programi__WinForm_OOP__
{
    public class Rent
    {
        public string FullName { get; set; }
        public decimal SNNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DownPayment { get; set; }
        public Car car { get; set; }

        public int RentDay
        {
            get
            {
                return EndDate.Subtract(StartDate).Days;
            }
        }

        public decimal Total
        {
            get
            {
                return RentDay * car.DailyPrice;
            }
        }

        public override string ToString()
        {
            return $"{FullName} ({StartDate.ToShortDateString()} - {EndDate.ToShortDateString()}) Gün - {RentDay} - {Total.ToString("C2")}";
        }

    }
}
