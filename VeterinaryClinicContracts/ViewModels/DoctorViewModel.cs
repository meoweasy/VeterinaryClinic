using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VeterinaryClinicContracts.ViewModels
{
    public class DoctorViewModel
    {
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string DoctorName { get; set; }
        [DisplayName("Логин")]
        public string DoctorLogin { get; set; }
        [DisplayName("Пароль")]
        public string DoctorPassword { get; set; }
    }
}
