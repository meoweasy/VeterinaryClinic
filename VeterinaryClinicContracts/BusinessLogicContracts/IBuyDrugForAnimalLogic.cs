using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.BusinessLogicContracts
{
    public interface IBuyDrugForAnimalLogic
    {
        List<BuyDrugForAnimalViewModel> Read(BuyDrugForAnimalBindingModel model);
        void CreateOrUpdate(BuyDrugForAnimalBindingModel model);
        void Delete(BuyDrugForAnimalBindingModel model);
    }
}
