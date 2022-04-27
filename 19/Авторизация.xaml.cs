using System;
using System.Collections.Generic;
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

namespace _19
{
    /// <summary>
    /// Логика взаимодействия для Password.xaml
    /// </summary>
    public partial class Авторизация : Window
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            txtLogin.Focus();
            Data.Login = false;
        }

        FactoryEntities db = FactoryEntities.GetContext();
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            //Ищем запись с заданным логином и паролем через LINQ
            var user = from p in db.Passwords
                       where p.Логин == txtLogin.Text && p.Пароль == txtPas.Password
                       select p;
            //Если запись найдена
            if (user.Count() == 1)
            {
                //Запоминаем информацию
                Data.Login = true;
                Data.Fio = user.First().Фамилия;
                Data.Name = user.First().Имя;
                Data.Right = user.First().Доступ;
                Close();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверный! Повторите ввод");
                txtLogin.Focus();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
