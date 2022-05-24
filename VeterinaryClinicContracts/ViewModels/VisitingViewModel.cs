using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VeterinaryClinicContracts.ViewModels
{
    public class VisitingViewModel
    {
        public int Id { get; set; }
        public int NurseryId { get; set; }
        public int AnimalId { get; set; }
        [DisplayName("Название")]
        public string VisitingName { get; set; }
    }
}
