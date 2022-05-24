using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.SrorageContracts
{
    public interface IAnimalStorage
    {
        List<AnimalViewModel> GetFullList();

        List<AnimalViewModel> GetFilteredList(AnimalBindingModel model);

        AnimalViewModel GetElement(AnimalBindingModel model);

        void Insert(AnimalBindingModel model);

        void Update(AnimalBindingModel model);

        void Delete(AnimalBindingModel model);
    }
}
