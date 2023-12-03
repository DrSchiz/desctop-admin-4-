using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ieaisadmin.models
{
    /// <summary>
    ///Модель, основнанная на таблице "clients" из БД
    /// </summary>
    public class clients
    {
        public string client_login {  get; set; }
        public string client_firstname { get; set; }
        public string client_name { get; set; }
        public string client_patronymic { get; set; }
        public string client_phone_number { get; set; }
        public string client_email { get; set; }
    }
}
