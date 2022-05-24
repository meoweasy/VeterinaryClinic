using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VeterinaryClinicContracts.ViewModels
{
    public class AnimalViewModel
    {
        public int Id { get; set; }
        public int NurseryId { get; set; }
        [DisplayName("Название животного")]
        public string AnimalName { get; set; }
    }
}
