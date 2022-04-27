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
        private void Query1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IQueryable<Factory> fioA1 = from p in db.Factories
                            where p.SurnameCollector.StartsWith("М")
                            select p;
                Data.SQL = fioA1;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Query2_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Query3_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Query4_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Query5_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Query6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.Database.ExecuteSqlCommand("UPDATE Factory SET SurnameCollector='Мельник' WHERE Number=10");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Query7_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Query8_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Query9_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
