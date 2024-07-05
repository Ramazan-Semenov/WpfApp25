using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
   public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 20000; i++)
            {
                Epmls.Add(new Epml { Name = i, Name_1 = i.ToString(), Name_2 = i.ToString() });
            }
            //Epmls = CollectionViewSource.GetDefaultView(Epm);
            DataContext = this;
            Loaded += MainWindow_Loaded;

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           // c.CollectionView.Filter = (i) => { var x = i as Epml; return x.Name == 1; };
        }

        public List<Epml> Epmls { get; set; } = new List<Epml>();
       // public ICollectionView Epmls { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            c.CollectionView.Filter = (i) => {var x= i as Epml;return x.Name==4|| x.Name == 5|| x.Name == 1; };
        }
    }
    public class Epml
    {
        private string name_2;
        private string name_1;
        private int name;

        public int Name
        {
            get => name;

            set { 
                
                name = value; }
        }
        public string Name_1 { get => name_1; set => name_1 = value; }
        public string Name_2 { get => name_2; set => name_2 = value; }
    }
}
