using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _13_social_network
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usern_TextChanged(object sender, EventArgs e)
        {

        }

        private void auth_Click(object sender, EventArgs e)
        {
            /* #region Аутентификация клиента(данные берутся из таблицы DB Browser)
            string connection = "Data Source=DBshka.db;";
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            string query = "SELECT admin " +
                "FROM Usersa " +
                "WHERE username = @username" +
                "AND Password = @Password";
            SQLiteCommand cmd = new SQLiteCommand(query, DB);
            string username = username.Text;
            string Password = password.Text;// присвоение переменные 

            cmd.Parameters.AddWithValue("@Mail", Mail);
            cmd.Parameters.AddWithValue("@Password", Password);

            // для администрации
            object Admin = cmd.ExecuteScalar();
            int roleValue = Convert.ToInt32(Admin);

            if (string.IsNullOrEmpty(username.Text))
            { MessageBox.Show("Пожалуйста, укажите имя пользователя!"); }

            if (string.IsNullOrEmpty(password.Text))
            { MessageBox.Show("Пожалуйста, укажите пароль!"); }
            else //если в поле mail ничего не написано
            if (Admin != null) //сравнение данных из бд с полями-это условие
                //При значении 0 , клиент входит как обычный зарегестрированный
                if (roleValue == 1)
                {

                    MessageBox.Show("Вас назначили Администратором! Переносим вас в базу данных отеля.");
                    this.Close();
                    var thread = new Thread(openForm3);
                    thread.Start();
                }//ДЛЯ АДМИНИСТРАТОРОВ(в бд отмечены с колконки admin с полем 1)
                else
                {
                    MessageBox.Show("Вы успешно вошли в аккаунт!");

                    this.Close();
                    var thread = new Thread(openForm);
                    thread.Start();
                }
            else
            {
                MessageBox.Show("Указанная почта или пароль неверный! Попробуйте снова");
            }


            DB.Close();
            #endregion */
            

            // ...

            /* #region Аутентификация клиента (MS Access .accdb) */
            // Строка подключения для .accdb (Microsoft.ACE.OLEDB.12.0)
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SocNetworkDB.accdb;Persist Security Info=False;";

            using (OleDbConnection DB = new OleDbConnection(connectionString))
            {
                try
                {
                    DB.Open();
                    // В Access важно: параметры часто передаются через '?', но можно использовать и имена.
                    // Добавлен пробел перед AND, чтобы запрос не слипся.
                    string query = "SELECT admin FROM Users WHERE username = @username AND Password = @Password";

                    OleDbCommand cmd = new OleDbCommand(query, DB);

                    // В OleDb порядок добавления параметров должен строго соответствовать их порядку в SQL-запросе
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);

                    if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля!");
                        return;
                    }

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int roleValue = Convert.ToInt32(result);

                        if (roleValue == 1)
                        {
                            MessageBox.Show("Вас назначили Администратором!");
                            this.Close();
                            new Thread(() => Application.Run(new Admin())).Start(); // Пример корректного запуска
                        }
                        else
                        {
                            MessageBox.Show("Вы успешно вошли!");
                            this.Close();
                            new Thread(() => Application.Run(new Clients())).Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверное имя пользователя или пароль!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message);
                }
            }
            /* #endregion */

        }
    }
}
