using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using JobPlacementDashboard.DAL;

namespace JobPlacementDashboard.Models
{
    public class JPMeetupEvent
    {
        [Key]
        [DisplayName("Event Id")]
        public int JPEventId { get; set; }
        [DisplayName("Event Name")]
        public string JPEventName { get; set; }
        [DisplayName("Event Link")]
        public string JPEventLink { get; set; }
        [DisplayName("Event Date")]
        public DateTime JPEventDate { get; set; }
        [DisplayName("Location")]
        public string JPLocation { get; set; }
        [DisplayName("Date Created")]
        public DateTime JPDateCreated { get; set; }

        public virtual ICollection<JPMeetUpAttendee> JPMeetUpAttendees { get; set; }
    }
}