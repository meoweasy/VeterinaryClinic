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
    public class DoctorLogic : IDoctorLogic
    {
        private readonly IDoctorStorage _doctorStorage;
        public DoctorLogic(IDoctorStorage doctorStorage)
        {
            _doctorStorage = doctorStorage;
        }
        public List<DoctorViewModel> Read(DoctorBindingModel model)
        {
            if (model == null)
            {
                return _doctorStorage.GetFullList();
            }
            if (model.Id >0)
            {
                return new List<DoctorViewModel> { _doctorStorage.GetElement(model) };
            }
            return _doctorStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(DoctorBindingModel model)
        {
            var element = _doctorStorage.GetElement(new DoctorBindingModel
            {
                DoctorLogin = model.DoctorLogin
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть врач с таким логином");
            }
            if (model.Id >0)
            {
                _doctorStorage.Update(model);
            }
            else
            {
                _doctorStorage.Insert(model);
            }
        }
        public void Delete(DoctorBindingModel model)
        {
            var element = _doctorStorage.GetElement(new DoctorBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Удаляемый элемент не найден");
            }
            _doctorStorage.Delete(model);
        }
    }
}
