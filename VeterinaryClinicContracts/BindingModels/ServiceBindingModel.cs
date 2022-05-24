using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.Enums;

namespace VeterinaryClinicContracts.BindingModels
{
    /// <summary>
    /// Услуга
    /// </summary>
    public class ServiceBindingModel
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
        public ServiceStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
        public Dictionary<int, (string, int)> ServiceMedicalSupplies { get; set; }
    }
}
