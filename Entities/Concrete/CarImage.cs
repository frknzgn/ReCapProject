﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CarImage:IEntity
    {
        public CarImage()
        {
            CreationDate = DateTime.Now;
        }
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime? CreationDate { get; set; }

    }
}
