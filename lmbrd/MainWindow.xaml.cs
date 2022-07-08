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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lmbrd
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registr registr = new Registr();
            this.Close();
            registr.Show();
        }

        private void Button_Click_auth(object sender, RoutedEventArgs e)
        {
            // инициал. переменных
            string log = Txblogin.Text;
            string pass = TxbPassword.Password;

            //Условие,если лоина логина и пароля больше 2 символов,идет подключение к базе
            if (log.Length > 2 && pass.Length > 3)
            {
                using (egregr_SampleDBEntities3 hachi = new egregr_SampleDBEntities3())
                //Проверка на правильные данные пользователя
                {
                    //запрос где логин и пароль совпадают с данными в базе
                    var query = hachi.Klienti.Where(x => x.login == log
                                                 && x.pass == pass).FirstOrDefault();
                    //условие если запрос не пустой открывается личный кабинет
                    if (query != null && query.RoleID == 1)
                    {
                        MessageBox.Show("Вы успешно зашли с правами админа!");
                        Admin profile = new Admin();
                        this.Close();
                        profile.Show();
                    }
                    else if (query != null && query.RoleID == 0)
                    {
                        MessageBox.Show("Вы успешно зашли с правами пользователя!");
                        UserNavigation profile = new UserNavigation();
                        this.Close();
                        profile.Show();
                    }
                    else
                    {
                        MessageBox.Show("Не правильно введен логин или пароль");

                    }
                }
            }
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
