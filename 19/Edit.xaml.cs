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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
        }
        //Получаем доступ к контексту данных
        FactoryEntities db = FactoryEntities.GetContext();
        Factory p1;//Элемент для работы с записью

        private void EditForm_Click(object sender, RoutedEventArgs e)
        {
            //Проверка каждого обязательного для заполнения поля
            StringBuilder errors = new StringBuilder();
            if (TextNumber.Text.Length == 0 || double.TryParse(TextNumber.Text, out double x1) == false) errors.AppendLine("Введите номер");
            if (TextSurnameCollector.Text.Length == 0) errors.AppendLine("Введите фамилию");
            if (TextNameCollector.Text.Length == 0) errors.AppendLine("Введите имя");
            if (TextCountOfManufacturedDetailsMonday.Text.Length == 0 || double.TryParse(TextNumber.Text, out double x2) == false) errors.AppendLine("Введите кол-во изготовленных изделий за понедельник");
            if (TextCountOfManufacturedDetailsTuesday.Text.Length == 0 || double.TryParse(TextNumber.Text, out double x3) == false) errors.AppendLine("Введите кол-во изготовленных изделий за вторник");
            if (TextCountOfManufacturedDetailsWednesday.Text.Length == 0 || double.TryParse(TextNumber.Text, out double x4) == false) errors.AppendLine("Введите кол-во изготовленных изделий за среду");
            if (TextCountOfManufacturedDetailsThursday.Text.Length == 0 || double.TryParse(TextNumber.Text, out double x5) == false) errors.AppendLine("Введите кол-во изготовленных изделий за четверг");
            if (TextCountOfManufacturedDetailsFriday.Text.Length == 0 || double.TryParse(TextNumber.Text, out double x6) == false) errors.AppendLine("Введите кол-во изготовленных изделий за пятницу");
            if (TextCountOfManufacturedDetailsSaturday.Text.Length == 0 || double.TryParse(TextNumber.Text, out double x7) == false) errors.AppendLine("Введите кол-во изготовленных изделий за субботу");
            if (TextCountOfManufacturedDetailsSunday.Text.Length == 0 || double.TryParse(TextNumber.Text, out double x8) == false) errors.AppendLine("Введите кол-во изготовленных изделий за воскресенье");
            if (TextNameFactory.Text.Length == 0) errors.AppendLine("Введите название цеха");
            if (TextTypeDetails.Text.Length == 0) errors.AppendLine("Введите тип изделия");
            if (TextPriceDetails.Text.Length == 0 || double.TryParse(TextNumber.Text, out double x9) == false) errors.AppendLine("Введите стоимость изделия");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            //Заполняем этот элемент
            p1.Number = Convert.ToInt32(TextNumber.Text);
            p1.SurnameCollector = TextSurnameCollector.Text;
            p1.NameCollector = TextNameCollector.Text;
            p1.PatronymicCollector = TextPatronymicCollector.Text;
            p1.CountOfManufacturedDetailsMonday = Convert.ToInt32(TextCountOfManufacturedDetailsMonday.Text);
            p1.CountOfManufacturedDetailsTuesday = Convert.ToInt32(TextCountOfManufacturedDetailsTuesday.Text);
            p1.CountOfManufacturedDetailsWednesday = Convert.ToInt32(TextCountOfManufacturedDetailsWednesday.Text);
            p1.CountOfManufacturedDetailsThursday = Convert.ToInt32(TextCountOfManufacturedDetailsThursday.Text);
            p1.CountOfManufacturedDetailsFriday = Convert.ToInt32(TextCountOfManufacturedDetailsFriday.Text);
            p1.CountOfManufacturedDetailsSaturday = Convert.ToInt32(TextCountOfManufacturedDetailsSaturday.Text);
            p1.CountOfManufacturedDetailsSunday = Convert.ToInt32(TextCountOfManufacturedDetailsSunday.Text);
            p1.NameFactory = TextNameFactory.Text;
            p1.TypeDetails = TextTypeDetails.Text;
            p1.PriceDetails = Convert.ToDecimal(TextPriceDetails.Text);
            try
            {
                //Сохраняем изменения
                db.SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Получаем запись по коду
            p1 = db.Factories.Find(Data.Number);
            //Отображаем запись
            TextNumber.Text = Convert.ToString(p1.Number);
            TextSurnameCollector.Text = p1.SurnameCollector;
            TextNameCollector.Text = p1.NameCollector;
            TextPatronymicCollector.Text = p1.PatronymicCollector;
            TextCountOfManufacturedDetailsMonday.Text = Convert.ToString(p1.CountOfManufacturedDetailsMonday);
            TextCountOfManufacturedDetailsTuesday.Text = Convert.ToString(p1.CountOfManufacturedDetailsTuesday);
            TextCountOfManufacturedDetailsWednesday.Text = Convert.ToString(p1.CountOfManufacturedDetailsWednesday);
            TextCountOfManufacturedDetailsThursday.Text = Convert.ToString(p1.CountOfManufacturedDetailsThursday);
            TextCountOfManufacturedDetailsFriday.Text = Convert.ToString(p1.CountOfManufacturedDetailsFriday);
            TextCountOfManufacturedDetailsSaturday.Text = Convert.ToString(p1.CountOfManufacturedDetailsSaturday);
            TextCountOfManufacturedDetailsSunday.Text = Convert.ToString(p1.CountOfManufacturedDetailsSunday);
            TextNameFactory.Text = p1.NameFactory;
            TextTypeDetails.Text = p1.TypeDetails;
            TextPriceDetails.Text = Convert.ToString(p1.PriceDetails);
        }
    }
}
