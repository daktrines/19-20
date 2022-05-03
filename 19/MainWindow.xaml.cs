using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Получаем доступ к контексту данных
        FactoryEntities db = FactoryEntities.GetContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Открываем окно авторизации
            Авторизация w = new Авторизация();
            w.Owner = this;
            w.ShowDialog();
            //При отказе от авторизации выходим из программы
            if (Data.Login == false) Close();
            //Устанавливаем права доступа
            if (Data.Right == "Администратор") ;
            else
            {
                //Можно запретить какие-либо действия
                Command.IsEnabled = false;//отключаем кнопу команды в меню
                Add.IsEnabled = false;//отлючаем кнопку добавления
                Edit.IsEnabled = false;//отлючаем кнопку редактирования
                Delete.IsEnabled = false;//отключаем кнопку удаления
                View.IsEnabled = false;//отключаем кнопку просмотр запросов
            }
            //Выводим информацию о пользователе в заголовок окна
            Title = Title + " " + Data.Fio + " " +
                Data.Name + "(" + Data.Right + ")";

            //Загружаем таблицу из БД
            db.Factories.Load();
            //Загружаем таблицу в DataGrid без отслеживания изменений контекста 
            //DataGrid1.ItemsSource = db.Factories.ToList();
            //Загружаем таблицу в DataGrid с отслеживанием изменения контекста 
            DataGrid1.ItemsSource = db.Factories.Local.ToBindingList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //Открываем форму Добавить
            Add f = new Add();
            f.ShowDialog();
            DataGrid1.Focus();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = DataGrid1.SelectedIndex;
            if (indexRow != -1)
            {
                //Получаем ключ текущей записи
                Factory row = (Factory)DataGrid1.Items[indexRow];
                Data.Number = row.Number;
                //Открываем форму Редактировать
                Edit f = new Edit();
                f.ShowDialog();
                //Обновляем таблицу
                DataGrid1.Items.Refresh();
                DataGrid1.Focus();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = DataGrid1.SelectedIndex;
            MessageBoxResult result;
            result = MessageBox.Show("Удалить запись?", "Удаление записи",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    //Получаем текущую запись
                    //Factory row = (Factory)DataGrid1.SelectedItems[0];
                    Factory row = (Factory)DataGrid1.Items[indexRow];
                    //Factory row = (Factory)DataGrid1.CurrentCell.Item;
                    //Удаляем запись
                    db.Factories.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }


        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калион Екатерина " +
               "\n19-20 пр" +
               "\nВариант 1." +
               "Учет изделий, собранных в цехе за неделю. База данных должна содержать следующую " +
               "информацию: фамилию, имя, отчество сборщика, количество изготовленных изделий за" +
               "каждый день недели раздельно, название цеха, а также тип изделия и его стоимость. Сделать авторизацию БД", "Информация", MessageBoxButton.OK, MessageBoxImage.Question);

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //Кнопка просмотр
        private void View_Click(object sender, RoutedEventArgs e)
        {
            //Открываем форму просмотр
            View f = new View();
            DataGrid1.Focus();
            if (f.ShowDialog() == true)
            {
                try
                {
                    //Обращаемся к классу и выводим запрос
                    DataGrid1.ItemsSource = Data.SQL.ToListAsync().Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
    }

        //кнопка обновление таблицы
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //Обновляем таблицу
            db = new FactoryEntities();
            db.Factories.Load();
            DataGrid1.ItemsSource = db.Factories.Local.ToBindingList();
        }
    }
}
