using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinaryClinicDatabaseImplement.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required]
        public string DoctorName { get; set; }
        [Required]
        public string DoctorLogin { get; set; }
        [Required]
        public string DoctorPassword { get; set; }
        [ForeignKey("DoctorId")]
        public virtual List<DoctorMedicalSupplies> DoctorMedicalSupplies { get; set; }

        [ForeignKey("DoctorId")]
        public virtual List<DoctorDrugs> DoctorDrugs { get; set; }
    }
}
