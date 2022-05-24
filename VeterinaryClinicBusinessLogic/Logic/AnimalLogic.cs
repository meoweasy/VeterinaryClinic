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
    public class AnimalLogic : IAnimalLogic
    {
        private readonly IAnimalStorage _animalStorage;
        public AnimalLogic(IAnimalStorage animalStorage)
        {
            _animalStorage = animalStorage;
        }
        public List<AnimalViewModel> Read(AnimalBindingModel model)
        {
            if (model == null)
            {
                return _animalStorage.GetFullList();
            }
            if (model.Id > 0)
            {
                return new List<AnimalViewModel> { _animalStorage.GetElement(model) };
            }
            return _animalStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(AnimalBindingModel model)
        {
            var element = _animalStorage.GetElement(new AnimalBindingModel
            {
                AnimalName = model.AnimalName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть животное с таким названием");
            }
            if (model.Id > 0)
            {
                _animalStorage.Update(model);
            }
            else
            {
                _animalStorage.Insert(model);
            }
        }
        public void Delete(AnimalBindingModel model)
        {
            var element = _animalStorage.GetElement(new AnimalBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Удаляемое животное не найдено");
            }
            _animalStorage.Delete(model);
        }
    }
}
