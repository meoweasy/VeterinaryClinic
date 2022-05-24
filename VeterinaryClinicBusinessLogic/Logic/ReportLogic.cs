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
    public class ReportLogic : IReportLogic
    {
        private readonly IDrugStorage _drugStorage;
        private readonly IMedicalSuppliesStorage _medicalSuppliesStorage;

        public ReportLogic(IDrugStorage drugStorage, IMedicalSuppliesStorage medicalSuppliesStorage)
        {
            _drugStorage = drugStorage;
            _medicalSuppliesStorage = medicalSuppliesStorage;
        }

        public List<ReportViewModel> GetBuy()
        {
            var drugs = _drugStorage.GetFullList();
            var list = new List<ReportViewModel>();
            foreach (var drug in drugs)
            {
                var record = new ReportViewModel
                {
                    DrugName = drug.DrugName,
                    buy = new List<Tuple<string>>(),
                    MedicalSuppliesName = string.Empty
                };
                foreach (var d in drug.DrugMedicalSupplies)
                {
                    var model = _medicalSuppliesStorage.GetElement(new MedicalSuppliesBindingModel { Id = d.Key });
                    foreach (var buy in model.MedicalSuppliesBuyDrugForAnimal)
                    {
                        record.buy.Add(new Tuple<string>(buy.Value));
                        record.MedicalSuppliesName = model.MedicalSuppliesName;
                    }
                }
                list.Add(record);
            }
            return list;
        }
        public void SaveBuyToExcelFile(ReportBindingModel model)
        {
            //
        }

        public void SaveBuyToWordFile(ReportBindingModel model)
        {
            //
        }
    }
}
