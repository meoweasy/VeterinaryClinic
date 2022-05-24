using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VeterinaryClinicContracts.ViewModels
{
    /// <summary>
    /// Медикамент
    /// </summary>
    public class MedicalSuppliesViewModel
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        [DisplayName("Название")]
        public string MedicalSuppliesName { get; set; }
        [DisplayName("Описание")]
        public string MedicalSuppliesDescription { get; set; }
        public Dictionary<int, string> MedicalSuppliesBuyDrugForAnimal { get; set; }
    }
}
