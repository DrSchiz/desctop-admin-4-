using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ieaisadmin.models
{
    /// <summary>
    ///Модель, основнанная на таблице "employee" из БД
    /// </summary>
    public class employee
    {
        public string employee_login { get; set; }
        public string employee_role { get; set; }
    }
}
