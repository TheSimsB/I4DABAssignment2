using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace I4DAB___Assignment_2
{
    public class Birth
    {
		public int BirthID { get; set; }

		[ForeignKey("RoomID")]
		public Room Room { get; set; }

		[ForeignKey("ParentID")]
		public Parent Parent { get; set; }

		[ForeignKey("ScheduleID")]
		public Schedule Schedule { get; set; }
	}
}
