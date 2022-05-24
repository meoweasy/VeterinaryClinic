using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinicContracts.ViewModels
{
    public class ReportViewModel
    {
        public string DrugName { get; set; }
        public string MedicalSuppliesName { get; set; }
        public List<Tuple<string>> buy { get; set; }
    }
}
