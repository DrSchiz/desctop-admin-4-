using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ieaisadmin.models;
using Npgsql;

namespace ieaisadmin
{
    /// <summary>
    ///Класс взаимодействия с БД
    /// </summary>
    public class DBConn
    {
        //Создание переменной подключения к БД
        private static NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=IEAIS;");
        //Метод проверки подключения к БД
        public bool checkDBConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            } 
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        ///Метод получения данных пользователей из БД
        /// </summary>

        public DataView getUsers(string data)
        {
            try
            {
                conn.Open();

                string query;

                if (data == "clients")
                {
                    query = "SELECT * FROM clients";
                }
                else if (data == "employee")
                {
                    query = "SELECT * FROM employee";
                }
                else if (data == "role")
                {
                    query = "SELECT * FROM role_employee";
                }
                else
                {
                    query = "SELECT * FROM employment_contract";
                }

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0].DefaultView;
            }
            catch (Exception e) { }
            finally
            {
                conn.Close();
            }
            return null;
        }

        /// <summary>
        ///Метод проверки введённого администратором пароля на совпадение с паролем, заданным в БД
        /// </summary>
        public bool checkPassword(string login, string password)
        {
            string query = "SELECT * FROM employee WHERE employee_login = '" + login + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            try
            {
                conn.Open();
                var rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        using (SHA256 hashAlgorithm = SHA256.Create())
                        {
                            var hashedByteArray = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
                            string hash = BitConverter.ToString(hashedByteArray).Replace("-", String.Empty);
                            if (rdr.GetString(2) == "Администратор")
                            {
                                if (hash == rdr.GetString(1))
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Неверный пароль!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                                    return false;
                                }
                            }
                        };
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        /// <summary>
        ///Метод удаления пользователя из БД
        /// </summary>
        public void deleteUser(bool isClient, string login)
        {
            try
            {
                conn.Open();
                string query;

                if (isClient)
                {
                    query = "DELETE FROM clients WHERE client_login = '" + login + "'";
                }
                else
                {
                    query = "DELETE FROM employee WHERE employee_login = '" + login + "'";
                }

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
        }

        /// <summary>
        /// Метод создания сотрудника
        /// </summary>
        public void createEmployee(int idContract, string login, string password, string role)
        {
            string hash;
            using (SHA256 hashAlgorithm = SHA256.Create())
            {
                var hashedByteArray = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
                hash = BitConverter.ToString(hashedByteArray).Replace("-", String.Empty);
            }

            try
            {
                conn.Open();
                string query = String.Format("INSERT INTO employee VALUES ('{0}', '{1}', '{2}', {3})", login, hash, role, idContract);

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
