using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.SrorageContracts
{
    public interface INurseryStorage
    {
        List<NurseryViewModel> GetFullList();

        List<NurseryViewModel> GetFilteredList(NurseryBindingModel model);

        NurseryViewModel GetElement(NurseryBindingModel model);

        void Insert(NurseryBindingModel model);

        void Update(NurseryBindingModel model);

        void Delete(NurseryBindingModel model);
    }
}
