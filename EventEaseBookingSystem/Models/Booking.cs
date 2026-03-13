using System;

namespace EventEaseBookingSystem.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int VenueID { get; set; }

        public int EventID { get; set; }

        public DateTime BookingDate { get; set; }
    }
}