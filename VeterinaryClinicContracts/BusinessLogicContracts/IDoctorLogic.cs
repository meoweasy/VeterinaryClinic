using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.BusinessLogicContracts
{
    public interface IDoctorLogic
    {
        List<DoctorViewModel> Read(DoctorBindingModel model);
        void CreateOrUpdate(DoctorBindingModel model);
        void Delete(DoctorBindingModel model);
    }
}
