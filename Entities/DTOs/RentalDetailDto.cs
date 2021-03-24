﻿using System;
using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ColorName { get; set; }
        public string CompanyName { get; set; }
        public string UserName { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}