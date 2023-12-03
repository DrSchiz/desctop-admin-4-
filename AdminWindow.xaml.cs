using ieaisadmin.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;

namespace ieaisadmin
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : System.Windows.Window
    {

        /// <summary>
        /// Экземпляр класса взаимодействия с БД
        /// </summary>
        DBConn db = new DBConn();
        public AdminWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод загрузки данных в dataGridClients
        /// </summary>
        private void dataGridClients_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridClients.ItemsSource = db.getUsers("clients");
        }

        /// <summary>
        /// Метод обработки выбранного администратором элемента dataGridClients
        /// </summary>
        private void dataGridClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonDeleteClient.IsEnabled = true;
        }

        /// <summary>
        /// Метод обработки нажатия на кнопку "Удалить" для клиента
        /// </summary>
        private void buttonDeleteClient_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = dataGridClients.SelectedItem as DataRowView;
            switch (MessageBox.Show("Вы действительно хотите удалить клиента " + row.Row.ItemArray[0].ToString() + "?", "Удаление клиента", MessageBoxButton.YesNo))
            {
                case MessageBoxResult.Yes:
                    db.deleteUser(true, row.Row.ItemArray[0].ToString());
                    dataGridClients.ItemsSource = db.getUsers("clients");
                    break;

                case MessageBoxResult.No:
                    return;
            }
        }

        /// <summary>
        /// Метод обработки нажатия на кнопку ".CSV"
        /// </summary>
        private void buttonExcel_Click(object sender, RoutedEventArgs e)
        {
            buttonDeleteClient.IsEnabled = false;

            dataGridClients.SelectAllCells();
            dataGridClients.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, dataGridClients);
            dataGridClients.UnselectAllCells();
            String result = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            try
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ieaisClients.csv", result, Encoding.GetEncoding(1251));
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ieaisClients.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Метод выгрузки данных в dataGridEmployee
        /// </summary>
        private void dataGridEmployee_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridEmployee.ItemsSource = db.getUsers("employee");
        }

        /// <summary>
        /// Метод выбора элемента в dataGridEmployee
        /// </summary>
        private void dataGridEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonDeleteEmployee.IsEnabled = true;
        }

        /// <summary>
        /// Метод обработки нажатия на кнопку "Удалить" для сотрудника
        /// </summary>
        private void buttonDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = dataGridEmployee.SelectedItem as DataRowView;
            switch (MessageBox.Show("Вы действительно хотите удалить сотрудника " + row.Row.ItemArray[0].ToString() + "?", "Удаление сотрудника", MessageBoxButton.YesNo))
            {
                case MessageBoxResult.Yes:
                    if (row.Row.ItemArray[2].ToString() == "Администратор")
                    {
                        MessageBox.Show("Вы не можете удалить администратора!");
                        return;
                    }
                    db.deleteUser(false, row.Row.ItemArray[0].ToString());
                    dataGridEmployee.ItemsSource = db.getUsers("employee");
                    break;

                case MessageBoxResult.No:
                    return;
            }
        }

        /// <summary>
        /// Метод обработки нажатия на кнопку ".CSV"
        /// </summary>
        private void buttonExcelEmployee_Click(object sender, RoutedEventArgs e)
        {
            buttonDeleteEmployee.IsEnabled = false;

            dataGridEmployee.SelectAllCells();
            dataGridEmployee.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, dataGridEmployee);
            dataGridEmployee.UnselectAllCells();
            String result = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            try
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ieaisEmployees.csv", result, Encoding.GetEncoding(1251));
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ieaisEmployees.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Метод выгрузки данных в dataGridContracts
        /// </summary>
        private void dataGridContracts_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridContracts.ItemsSource = db.getUsers("employment_contract");
        }

        /// <summary>
        /// Метод выгрузки данных в comboBoxRole
        /// </summary>
        private void comboBoxRole_Loaded(object sender, RoutedEventArgs e)
        {
            System.Data.DataTable dataTableRows = db.getUsers("role").ToTable();

            List<string> roles = new List<string>();

            foreach (DataRow row in dataTableRows.Rows)
            {
                string role = row[0].ToString();
                roles.Add(role);
            }

            comboBoxRole.ItemsSource = roles;
        }

        /// <summary>
        /// Метод обработки нажатия на выбранный элемент dataGridContracts
        /// </summary>
        private void dataGridContracts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView row = dataGridContracts.SelectedItem as DataRowView;
            try
            {
                textBlockContractNum.Text = row.Row.ItemArray[0].ToString();
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// Метод обработки нажатия на кнопку "Добавить" сотрудника
        /// </summary>
        private void buttonAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            db.createEmployee(int.Parse(textBlockContractNum.Text), textBoxLogin.Text, passwordBoxPassword.Password, comboBoxRole.Text);
        }
    }
}