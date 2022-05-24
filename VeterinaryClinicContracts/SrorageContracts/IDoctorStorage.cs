using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.SrorageContracts
{
    public interface IDoctorStorage
    {
        List<DoctorViewModel> GetFullList();

        List<DoctorViewModel> GetFilteredList(DoctorBindingModel model);

        DoctorViewModel GetElement(DoctorBindingModel model);

        void Insert(DoctorBindingModel model);

        void Update(DoctorBindingModel model);

        void Delete(DoctorBindingModel model);
    }
}
