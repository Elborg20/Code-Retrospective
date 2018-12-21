using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobPlacementDashboard.Models
{
    public class JPMeetUpAttendee
    {
        [Key]
        public Guid AttendeeId { get; set; }
        public int JPEventId { get; set; }
        public int JPStudentId { get; set; }

        public virtual JPStudent JPStudent { get; set; }
    }
}