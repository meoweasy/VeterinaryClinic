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
    public class MedicalSuppliesLogic : IMedicalSuppliesLogic
    {
        private readonly IMedicalSuppliesStorage _medicalSuppliesStorage;
        public MedicalSuppliesLogic(IMedicalSuppliesStorage medicalSuppliesStorage)
        {
            _medicalSuppliesStorage = medicalSuppliesStorage;
        }
        public List<MedicalSuppliesViewModel> Read(MedicalSuppliesBindingModel model)
        {
            if (model == null)
            {
                return _medicalSuppliesStorage.GetFullList();
            }
            if (model.Id > 0)
            {
                return new List<MedicalSuppliesViewModel> { _medicalSuppliesStorage.GetElement(model) };
            }
            return _medicalSuppliesStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(MedicalSuppliesBindingModel model)
        {
            var element = _medicalSuppliesStorage.GetElement(new MedicalSuppliesBindingModel
            {
                MedicalSuppliesName = model.MedicalSuppliesName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть медикамент с таким названием");
            }
            if (model.Id > 0)
            {
                _medicalSuppliesStorage.Update(model);
            }
            else
            {
                _medicalSuppliesStorage.Insert(model);
            }
        }
        public void Delete(MedicalSuppliesBindingModel model)
        {
            var element = _medicalSuppliesStorage.GetElement(new MedicalSuppliesBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Удаляемый медикамент не найден");
            }
            _medicalSuppliesStorage.Delete(model);
        }
    }
}
