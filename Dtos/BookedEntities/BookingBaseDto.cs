﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boocking.Models.Entities;

namespace Booking.Dtos.BookedEntities
{
    public class BookingBaseDTO
    {
        public int bookingId { get; set; } 

        public DateTime initBooking { get; set; } 

        public DateTime endBooking { get; set; }

        #pragma warning disable CS8618 
        public ClientEntity oClient {  get; set; }

        public int daysBooked { get; set; } 

        public string paymentMethod { get; set; }

        public decimal totalPrice { get; set; } 

        public bool isPaid { get; set; }

        public int rentableId { get; set; } 

        public string rentableName { get; set; }
        #pragma warning restore CS8618 

    }
}
