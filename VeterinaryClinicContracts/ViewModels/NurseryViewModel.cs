using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VeterinaryClinicContracts.ViewModels
{
    public class NurseryViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название питомника")]
        public string NurseryName { get; set; }
        [DisplayName("Логин")]
        public string NurseryLogin { get; set; }
        [DisplayName("Пароль")]
        public string NurseryPassword { get; set; }
    }
}
