using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.BindingModels
{
    /// <summary>
    /// Данные для смены статуса услуги
    /// </summary>
    public class ChangeStatusBindingModel
    {
        public int ServiceId { get; set; }
    }
}
