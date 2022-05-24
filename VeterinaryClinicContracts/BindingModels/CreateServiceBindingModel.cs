using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.BindingModels
{
    /// <summary>
    /// Данные от врача для создания услуги
    /// </summary>
    public class CreateServiceBindingModel
    {
        public int DoctorId { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
        public Dictionary<int, (string, int)> ServiceMedicalSupplies { get; set; }
    }
}
