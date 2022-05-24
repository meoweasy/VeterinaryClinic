using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VeterinaryClinicContracts.ViewModels
{
    /// <summary>
    /// Услуга
    /// </summary>
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        [DisplayName("Название")]
        public string ServiceName { get; set; }
        [DisplayName("Стоимость услуги")]
        public decimal ServicePrice { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        [DisplayName("Дата выполнения")]
        public DateTime? DateImplement { get; set; }
        public Dictionary<int, (string, int)> ServiceMedicalSupplies { get; set; }
    }
}
