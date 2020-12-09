using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmigoInvisible.Models
{
    public class AttendeesGroupModel : AttendeeModel
    {
        public List<AttendeeModel> Attendees { get; set; }
    }
}