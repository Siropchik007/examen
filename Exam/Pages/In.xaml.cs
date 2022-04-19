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
using ClassLibrary1.Data;
namespace Exam.Pages
{
    /// <summary>
    /// Логика взаимодействия для In.xaml
    /// </summary>
    public partial class In : Page

    {

        private Rep _rep;
        private ClassAppl _clap;
        public In()
        {
            InitializeComponent();
            _rep = new Rep();
            _clap = new ClassAppl(_rep);
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }
        public void Update()
        {
            Table.ItemsSource = _clap.GetAllList();
        }

        private void Dlt_Click(object sender, RoutedEventArgs e)
        {
            var sel = (Class2)Table.SelectedItem;
            _clap.Delete(sel.Id);
            Update();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
