using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.BusinessLogicContracts
{
    public interface IVisitingLogic
    {
        List<VisitingViewModel> Read(VisitingBindingModel model);
        void CreateOrUpdate(VisitingBindingModel model);
        void Delete(VisitingBindingModel model);
    }
}
