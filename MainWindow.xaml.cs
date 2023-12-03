using ieaisadmin.models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ieaisadmin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Экземпляр класса взаимодействия с БД
        /// </summary>
        DBConn db = new DBConn();

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, вызываемый при загрузке окна авторизации, проверяющий подключение к БД
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (db.checkDBConnection())
            {
                databaseConn.Content = "База данных успешно подключена!";
                databaseConn.Foreground = Brushes.Green;
            }
        }

        /// <summary>
        /// Метод обработки нажатия на кнопку "Войти", обращающийся к методу проверки введённого пароля администратором на соответствие с заданным паролем в БД
        /// </summary>
        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            if (db.checkPassword(textBoxLogin.Text, passwordBoxPassword.Password))
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                this.Close();
            }
        }
    }
}
