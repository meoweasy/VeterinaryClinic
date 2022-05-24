using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.BindingModels
{
    /// <summary>
    /// Питомник
    /// </summary>
    public class NurseryBindingModel
    {
        public int Id { get; set; }
        public string NurseryName { get; set; }
        public string NurseryLogin { get; set; }
        public string NurseryPassword { get; set; }
    }
}
