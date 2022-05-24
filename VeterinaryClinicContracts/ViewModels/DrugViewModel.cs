using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VeterinaryClinicContracts.ViewModels
{
    /// <summary>
    /// Лекарство
    /// </summary>
    public class DrugViewModel
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        [DisplayName("Название")]
        public string DrugName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        [DisplayName("Описание")]
        public string DrugDescription { get; set; }
        public Dictionary<int, (string, decimal)> DrugMedicalSupplies { get; set; }
    }
}
