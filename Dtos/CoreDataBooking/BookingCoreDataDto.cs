using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boocking.Models.Entities;

namespace Booking.Dtos.CoreDataBooking
{
    public class BookingCoreDataDto
    {
        public DateTime initBooking {  get; set; }
        public DateTime endBooking { get; set; }

        #pragma warning disable CS8618 
        public string paymentMethod { get; set; }
        #pragma warning restore CS8618 
        
        public bool isPaid { get; set; }

        #pragma warning disable CS8618 
        public ClientEntity oClient { get; set; }
        #pragma warning restore CS8618 

    }
}
