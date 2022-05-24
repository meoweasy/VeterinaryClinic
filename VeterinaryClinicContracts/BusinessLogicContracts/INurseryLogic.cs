using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.BusinessLogicContracts
{
    public interface INurseryLogic
    {
        List<NurseryViewModel> Read(NurseryBindingModel model);
        void CreateOrUpdate(NurseryBindingModel model);
        void Delete(NurseryBindingModel model);
    }
}
