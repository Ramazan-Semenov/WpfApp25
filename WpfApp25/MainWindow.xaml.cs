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

namespace WpfApp25
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Epmls.Add(new Epml { Name=i.ToString(), Name_1=i.ToString(), Name_2=i.ToString() });
            }
            DataContext = this;
        }
        public List<Epml> Epmls { get; set; } = new List<Epml>();
        
    }
    public class Epml
    {
        public string Name { get; set; }
        public string Name_1 { get; set; }
        public string Name_2 { get; set; }
    }
}
