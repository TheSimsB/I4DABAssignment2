using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace I4DAB___Assignment_2
{
   public class BirthRoom
    {

        [ForeignKey("RoomID")]
        public Room BirthRoomID { get; set; }
    }
}
