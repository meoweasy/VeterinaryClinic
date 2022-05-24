using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.BindingModels
{
    /// <summary>
    /// Посещение
    /// </summary>
    public class VisitingBindingModel
    {
        public int Id { get; set; }
        public int NurseryId { get; set; }
        public int AnimalId { get; set; }
        public string VisitingName { get; set; }
    }
}
