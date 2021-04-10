using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace I4DAB___Assignment_2
{
    public class FourHoursRestRoom
    {
        [ForeignKey("RoomID")]
        public Room FourHourRestRoom { get; set; }
    }
}
