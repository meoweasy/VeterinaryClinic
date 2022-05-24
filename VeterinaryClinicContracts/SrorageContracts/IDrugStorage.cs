using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.SrorageContracts
{
    public interface IDrugStorage
    {
        List<DrugViewModel> GetFullList();
        List<DrugViewModel> GetFilteredList(DrugBindingModel model);
        DrugViewModel GetElement(DrugBindingModel model);
        void Insert(DrugBindingModel model);
        void Update(DrugBindingModel model);
        void Delete(DrugBindingModel model);
    }
}
