using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace I4DAB___Assignment_2
{
    public class Schedule
    {
		public int ScheduleID { get; set; }
		public DateTime BirthRoomReservation { get; set; }
        public DateTime BirthRoomReservationEnded { get; set; }
        public DateTime RestRoomReservation { get; set; }
        public DateTime RestRoomReservationEnded { get; set; }
        public DateTime MaternityRoomReservation { get; set; }
        public DateTime MaternityRoomReservationEnded { get; set; }
		public DateTime PlannedBirthTime { get; set; }

		[ForeignKey("RoomID")]
		public Room Room { get; set; }

	}
}
