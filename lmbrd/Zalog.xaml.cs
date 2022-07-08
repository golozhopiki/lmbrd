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
    /// Логика взаимодействия для Zalog.xaml
    /// </summary>
    public partial class Zalog : Window
    {
       egregr_SampleDBEntities3 egr = new egregr_SampleDBEntities3();
        List<Category> categories = new List<Category>();
        public Zalog()
        {
            InitializeComponent();
            cmbbxt.ItemsSource = egr.Category.Select(t => t.NameC.Trim()).ToList();

        }
        public void LoadingFiltration()
        {
            try
            {
                var product = from p in egr.Category
                              select new
                              {
                                  NameC = p.NameC,
                                  CategoryID = p.CategoryID
                              };
                cmbbxt.ItemsSource = product.ToList();
                cmbbxt.SelectedValuePath = "ID";
                cmbbxt.DisplayMemberPath = "Title";
            }
            catch
            {
                MessageBox.Show("Возможно, отсутвует база данных.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserNavigation user = new UserNavigation();
            user.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
              
                    egr.Sdacha.Add(new Sdacha()
                    {
                        Category = Convert.ToString(cmbbxt),
                        Opisanie = OPIS.Text,
                        Date_sdachi = dtpSdacha.DisplayDate,
                        IDClienta = Convert.ToInt32(id.Text),

                    });
                
                egr.SaveChanges();
                MessageBox.Show("Агент успешно добавлен.");
                this.Close();
            

        }

        private void cmbbxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
