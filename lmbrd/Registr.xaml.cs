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
        private void Button_Click_save(object sender, RoutedEventArgs e)
        {


            //Ввод логи на и пароля для нового пользователя
            string loginReg = logi.Text.Trim();
            string passReg = pswrd.Text;

            string fam = Surnamee.Text;
            string nam = Namee.Text;
            string last = Lastnamee.Text;
            string pasn = passn.Text;
            string date = dateps.Text;
          
            



            //условие,если пароль и подтв пароля совпадают
          
            //Используем базу данных для занесения пользователя в базу
            {
                using (egregr_SampleDBEntities3 hachi = new egregr_SampleDBEntities3())
                {
                    //запрос к базе
                    var query = hachi.Klienti.Where(x => x.login.Equals(loginReg)).FirstOrDefault();
                    // если такого лоигна нет,то он вносится в базу
                    if (query == null)
                    //Добавление нового пользователя 
                    {
                        hachi.Klienti.Add(new Klienti()
                        {
                            login = loginReg,
                            pass = passReg,
                            Surname = fam,
                            Name = nam,
                            Lastname = last,
                            Passport = Convert.ToInt64(pasn),
                            Date_passport = dateps.DisplayDate,
                            RoleID = Convert.ToInt32(RolId.Text),
                            
                        }
                        );
                        //сохранение изменений
                        
                        hachi.SaveChanges();

                        MessageBox.Show("Поздравляем!Вы успешно зарегестрировались!");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Такой логин уже существует");
                    }
                }
            }
          
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
        //свернуть окно
        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Button_Click_Maximazed(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
