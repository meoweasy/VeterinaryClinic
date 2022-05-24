using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.SrorageContracts
{
    public interface IVisitingStorage
    {
        List<VisitingViewModel> GetFullList();

        List<VisitingViewModel> GetFilteredList(VisitingBindingModel model);

        VisitingViewModel GetElement(VisitingBindingModel model);

        void Insert(VisitingBindingModel model);

        void Update(VisitingBindingModel model);

        void Delete(VisitingBindingModel model);
    }
}
