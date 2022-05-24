﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinicContracts.ViewModels;
using VeterinaryClinicContracts.BindingModels;

namespace VeterinaryClinicContracts.BusinessLogicContracts
{
    public interface IMedicalSuppliesLogic
    {
        List<MedicalSuppliesViewModel> Read(MedicalSuppliesBindingModel model);
        void CreateOrUpdate(MedicalSuppliesBindingModel model);
        void Delete(MedicalSuppliesBindingModel model);
    }
}
