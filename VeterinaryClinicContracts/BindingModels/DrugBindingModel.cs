using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.BindingModels
{
    public class DrugBindingModel
    {
        /// <summary>
        /// Лекарство
        /// </summary>
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string DrugName { get; set; }
        public decimal Price { get; set; }
        public string DrugDescription { get; set; }
        public Dictionary<int, (string, int)> DrugMedicalSupplies { get; set; }
    }
}
