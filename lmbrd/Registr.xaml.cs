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

namespace lmbrd
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        public Registr()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {


            //Ввод логи на и пароля для нового пользователя 
            //string loginReg = logi.Text.Trim();
            //string passReg = pswrd.Password;
          
            //string fam = Surnamee.Text;
            //string  = email.Text;
            //string telph = phonee.Text;


            ////условие,если пароль и подтв пароля совпадают
            //if (passReg == passReg2)
            ////Используем базу данных для занесения пользователя в базу
            //{
            //    using (egregr_SampleDBEntities1 hachi = new egregr_SampleDBEntities1())
            //    {
            //        //запрос к базе
            //        var query = hachi.Klienti.Where(x => x.log.Equals(loginReg)).FirstOrDefault();
            //        // если такого лоигна нет,то он вносится в базу
            //        if (query == null)
            //        //Добавление нового пользователя 
            //        {
            //            hachi.Klienti.Add(new Klienti()
            //            {
            //                Login = loginReg,
            //                Password = passReg,
            //                FIO = fio,
            //                email = emaill,
            //                Phone = telph,
            //            }
            //            );
                        //сохранение изменений
            //            hachi.SaveChanges();
            //            MessageBox.Show("Поздравляем!Вы успешно зарегестрировались!");

            //        }
            //        else
            //        {
            //            MessageBox.Show("Такой логин уже существует");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Пароли не совпадают");
            //}
        }
    }
}
