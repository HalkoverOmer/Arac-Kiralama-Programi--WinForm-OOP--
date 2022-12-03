using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arac_Kiralama_Programi__WinForm_OOP__
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int KM { get; set; }
        public int Year { get; set; }
        public decimal DailyPrice { get; set; }
        public bool IsRent { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year})";
        }
    }
}
