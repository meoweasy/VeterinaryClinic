using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.SrorageContracts
{
    public interface IMedicalSuppliesStorage
    {
        List<MedicalSuppliesViewModel> GetFullList();
        List<MedicalSuppliesViewModel> GetFilteredList(MedicalSuppliesBindingModel model);
        MedicalSuppliesViewModel GetElement(MedicalSuppliesBindingModel model);
        void Insert(MedicalSuppliesBindingModel model);
        void Update(MedicalSuppliesBindingModel model);
        void Delete(MedicalSuppliesBindingModel model);
    }
}
