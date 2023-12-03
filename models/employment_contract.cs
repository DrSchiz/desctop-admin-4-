using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ieaisadmin.models
{
    /// <summary>
    ///Модель, основнанная на таблице "employment_contract" из БД
    /// </summary>
    public class employment_contract
    {
        public int contract_number {  get; set; }
        public string employee_itn { get; set; }
        public string employee_adress { get; set; }
        public string employee_phone_number { get; set; }
    }
}
