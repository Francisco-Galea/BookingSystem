﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Dtos.CoreDataBooking
{
    public class BookingCoreDataDto
    {
        public DateTime initBooking {  get; set; }
        public DateTime endBooking { get; set; }
        public string paymentMethod { get; set; }
        public bool isPaid { get; set; }
    }
}
