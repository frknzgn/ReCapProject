using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Car : IVehicle
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Type { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
