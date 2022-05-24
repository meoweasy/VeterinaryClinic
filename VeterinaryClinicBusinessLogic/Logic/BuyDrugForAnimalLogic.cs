using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.BindingModels;
using VeterinaryClinicContracts.BusinessLogicContracts;
using VeterinaryClinicContracts.SrorageContracts;
using VeterinaryClinicContracts.ViewModels;

namespace VeterinaryClinicBusinessLogic.Logic
{
    public class BuyDrugForAnimalLogic : IBuyDrugForAnimalLogic
    {
        private readonly IBuyDrugForAnimalStorage _buyDrugForAnimalStorage;
        public BuyDrugForAnimalLogic(IBuyDrugForAnimalStorage buyDrugForAnimalStorage)
        {
            _buyDrugForAnimalStorage = buyDrugForAnimalStorage;
        }
        public List<BuyDrugForAnimalViewModel> Read(BuyDrugForAnimalBindingModel model)
        {
            if (model == null)
            {
                return _buyDrugForAnimalStorage.GetFullList();
            }
            if (model.Id > 0)
            {
                return new List<BuyDrugForAnimalViewModel> { _buyDrugForAnimalStorage.GetElement(model) };
            }
            return _buyDrugForAnimalStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(BuyDrugForAnimalBindingModel model)
        {
            var element = _buyDrugForAnimalStorage.GetElement(new BuyDrugForAnimalBindingModel
            {
                AnimalId = model.AnimalId
            });
            if (element != null && element.DrugId != model.DrugId)
            {
                throw new Exception("Уже куплено такое лекарство для этого животного");
            }
            if (model.Id > 0)
            {
                _buyDrugForAnimalStorage.Update(model);
            }
            else
            {
                _buyDrugForAnimalStorage.Insert(model);
            }
        }
        public void Delete(BuyDrugForAnimalBindingModel model)
        {
            var element = _buyDrugForAnimalStorage.GetElement(new BuyDrugForAnimalBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Удаляемая покупка не найдена");
            }
            _buyDrugForAnimalStorage.Delete(model);
        }
    }
}
