using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.BindingModels
{
    public class MedicalSuppliesBindingModel
    {
        /// <summary>
        /// Медикамент
        /// </summary>
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string MedicalSuppliesName { get; set; }
        public string MedicalSuppliesDescription { get; set; }
    }
}
