using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.BindingModels
{
    /// <summary>
    /// Животное
    /// </summary>
    public class AnimalBindingModel
    {
        public int Id { get; set; }
        public int NurseryId { get; set; }
        public string AnimalName { get; set; }
    }
}
