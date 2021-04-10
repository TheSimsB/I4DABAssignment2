using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace I4DAB___Assignment_2
{

    public class Clinician
    {
        public int ClinicianID { get; set; }

        public string ClinicianName { get; set; }

        [ForeignKey("ClinicID")]
        public BirthClinic Clinic { get; set; }
        [ForeignKey("ScheduleID")]

        public Schedule Schedule { get; set; }
    }

}
