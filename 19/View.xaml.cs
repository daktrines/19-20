using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
        }
        //Получаем доступ к контексту данных
        FactoryEntities db = FactoryEntities.GetContext(); 

        //Запрос на выборку по фамилии, которые начинаются с буквы М
        private void Query1_Click(object sender, RoutedEventArgs e)
        {
            IQueryable fioA1 = from p in db.Factories
                        where p.SurnameCollector.StartsWith("М")
                        select p;
            Data.SQL = fioA1;
            DialogResult = true;
            Close();
        }

        //Запрос на выборку с группировкой фамилии по возрастанию
        private void Query2_Click(object sender, RoutedEventArgs e)
        {
            IQueryable fioA2 = from p in db.Factories
                               orderby p.SurnameCollector
                               select p;
            Data.SQL = fioA2;
            DialogResult = true;
            Close();
        }

        //Запрос на выборку определения количества
        private void Query3_Click(object sender, RoutedEventArgs e)
        {
            IQueryable fioA3 = from p in db.Factories
                               select new { Count = db.Factories.Count() };
            Data.SQL = fioA3;
            DialogResult = true;
            Close();
        }

        //Запрос на выборку нахождения максимальной стоимости изделия
        private void Query4_Click(object sender, RoutedEventArgs e)
        {
            IQueryable fioA4 = from p in db.Factories
                               select new { Max = db.Factories.Max(g => g.PriceDetails) };
            Data.SQL = fioA4;
            DialogResult = true;
            Close();
        }

        //Запрос на выборку нахождения суммы стоимостей изделий
        private void Query5_Click(object sender, RoutedEventArgs e)
        {
            IQueryable fioA5 = from p in db.Factories
                               select new { Sum = db.Factories.Sum(g => g.PriceDetails) };
            Data.SQL = fioA5;
            DialogResult = true;
            Close();
        }

        //Запрос на обновление по номеру и фамилии сборщика изделий
        private void Query6_Click(object sender, RoutedEventArgs e)
        {
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@Number";
            param1.Value = Convert.ToInt32(nomer.Text);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@Surname";
            param2.Value = surname.Text;

            db.Database.ExecuteSqlCommand($"UPDATE Factory SET SurnameCollector=@Surname WHERE Number=@Number", param1, param2);
            Data.SQL = db.Factories;
            DialogResult = true;
            Close();
        }

        //Запрос на обновление по номеру и стоимости изделия
        private void Query7_Click(object sender, RoutedEventArgs e)
        {
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@Number";
            param1.Value = Convert.ToInt32(nomer.Text);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@Price";
            param2.Value = Convert.ToInt32(price.Text);

            db.Database.ExecuteSqlCommand($"UPDATE Factory SET PriceDetails=@Price WHERE Number=@Number", param1, param2);
            Data.SQL = db.Factories;
            DialogResult = true;
            Close();
        }

        //Запрос на удаление по номеру
        private void Query8_Click(object sender, RoutedEventArgs e)
        {
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@Number";
            param1.Value = Convert.ToInt32(nomer.Text);

            db.Database.ExecuteSqlCommand($"DELETE FROM Factory WHERE Number=@Number", param1);
            Data.SQL = db.Factories;
            DialogResult = true;
            Close();
        }
    }
}
