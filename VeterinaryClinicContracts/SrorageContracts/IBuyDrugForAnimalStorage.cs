using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.SrorageContracts
{
    public interface IBuyDrugForAnimalStorage
    {
        List<BuyDrugForAnimalViewModel> GetFullList();

        List<BuyDrugForAnimalViewModel> GetFilteredList(BuyDrugForAnimalBindingModel model);

        BuyDrugForAnimalViewModel GetElement(BuyDrugForAnimalBindingModel model);

        void Insert(BuyDrugForAnimalBindingModel model);

        void Update(BuyDrugForAnimalBindingModel model);

        void Delete(BuyDrugForAnimalBindingModel model);
    }
}
