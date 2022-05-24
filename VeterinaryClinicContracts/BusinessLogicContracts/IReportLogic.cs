using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.BusinessLogicContracts
{
    public interface IReportLogic
    {
        // Получение списка покупок по выбранным медикаментам
        List<ReportViewModel> GetBuy();

        // Сохранение в файл-Word
        void SaveBuyToWordFile(ReportBindingModel model);

        // Сохранение в файл-Excel
        void SaveBuyToExcelFile(ReportBindingModel model);
    }
}
