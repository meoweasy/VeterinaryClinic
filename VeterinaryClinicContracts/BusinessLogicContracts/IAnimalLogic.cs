using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.BusinessLogicContracts
{
    public interface IAnimalLogic
    {
        List<AnimalViewModel> Read(AnimalBindingModel model);
        void CreateOrUpdate(AnimalBindingModel model);
        void Delete(AnimalBindingModel model);
    }
}
