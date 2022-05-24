using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.SrorageContracts;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;
using VeterinaryClinicDatabaseImplement.Models;

namespace VeterinaryClinicDatabaseImplement.Implements
{
    public class DoctorStorage : IDoctorStorage
    {
        public List<DoctorViewModel> GetFullList()
        {
            using var context = new VeterinaryClinicDatabase();
            return context.Doctors
            .Include(rec => rec.DoctorDrugs)
            .ThenInclude(rec => rec.Drug)
            .Include(rec => rec.DoctorMedicalSupplies)
            .ThenInclude(rec => rec.MedicalSupplies)
            .Select(CreateModel)
            .ToList();
        }
        public List<DoctorViewModel> GetFilteredList(DoctorBindingModel model)
        {

        }
        public DoctorViewModel GetElement(DoctorBindingModel model)
        {

        }
        public void Insert(DoctorBindingModel model)
        {

        }
        public void Update(DoctorBindingModel model)
        {

        }
        public void Delete(DoctorBindingModel model)
        {

        }
        private static Doctor CreateModel(DoctorBindingModel model, Doctor doctor, VeterinaryClinicDatabase context)
        {
            
        }
        private static DoctorViewModel CreateModel(Doctor doctor)
        {
            
        }
    }
}
