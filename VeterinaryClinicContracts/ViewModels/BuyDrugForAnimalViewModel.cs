using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VeterinaryClinicContracts.ViewModels
{
    public class BuyDrugForAnimalViewModel
    {
        public int Id { get; set; }
        public int NurseryId { get; set; }
        public int AnimalId { get; set; }
        public int DrugId { get; set; }
        [DisplayName("Название животного")]
        public string AnimalName { get; set; }
        [DisplayName("Название лекарства")]
        public string DrugName { get; set; }
    }
}
