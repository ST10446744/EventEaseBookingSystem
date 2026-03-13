using System.ComponentModel.DataAnnotations;

namespace EventEaseBookingSystem.Models
{
    public class Venue
    {
        public int VenueID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }

        public int Capacity { get; set; }

        public string ImageUrl { get; set; }
    }
}