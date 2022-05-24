using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.BindingModels
{
    /// <summary>
    /// Врач
    /// </summary>
    public class DoctorBindingModel
    {
        public int Id { get; set; }
        public int NurseryId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorLogin { get; set; }
        public string DoctorPassword { get; set; }
    }
}
