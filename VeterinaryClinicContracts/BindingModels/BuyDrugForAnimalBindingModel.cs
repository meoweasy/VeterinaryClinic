using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.BindingModels
{
    /// <summary>
    /// Покупка лекарств для животных
    /// </summary>
    public class BuyDrugForAnimalBindingModel
    {
        public int Id { get; set; }
        public int NurseryId { get; set; }
        public int AnimalId { get; set; }
        public int DrugId { get; set; }
        public string AnimalName { get; set; }
        public string DrugName { get; set; }
    }
}
