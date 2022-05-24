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
    public class NurseryLogic : INurseryLogic
    {
        private readonly INurseryStorage _nurseryStorage;
        public NurseryLogic(INurseryStorage nurseryStorage)
        {
            _nurseryStorage = nurseryStorage;
        }
        public List<NurseryViewModel> Read(NurseryBindingModel model)
        {
            if (model == null)
            {
                return _nurseryStorage.GetFullList();
            }
            if (model.Id > 0)
            {
                return new List<NurseryViewModel> { _nurseryStorage.GetElement(model) };
            }
            return _nurseryStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(NurseryBindingModel model)
        {
            var element = _nurseryStorage.GetElement(new NurseryBindingModel
            {
                NurseryName = model.NurseryName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть питомник с таким названием");
            }
            if (model.Id > 0)
            {
                _nurseryStorage.Update(model);
            }
            else
            {
                _nurseryStorage.Insert(model);
            }
        }
        public void Delete(NurseryBindingModel model)
        {
            var element = _nurseryStorage.GetElement(new NurseryBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Удаляемый питомник не найден");
            }
            _nurseryStorage.Delete(model);
        }
    }
}
