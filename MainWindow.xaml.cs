using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> Slowa { get; set; }
        public List<Class1> Produkty { get; set; } = new List<Class1>();
        public MainWindow()
        {
            InitializeComponent();
            Slowa=new List<string>();
            Slowa.Add("programista");
            Slowa.Add("informatyka");
            Slowa.Add("matematyka");
            Slowa.Add("algorytmy");
            
            itemsControlSlowa.ItemsSource = Slowa;
            listBox.ItemsSource=Slowa;
            Produkty.Add(new Class1("komputer", 1502, "komputer biurowy", true, "komputer"));
            Produkty.Add(new Class1("drukarka", 600, "drukarka atramentowa", true, "urzadzenia peryferyjne"));
            Produkty.Add(new Class1("mysz", 200, "mysz komputerowa", true, "akcesoria"));
            DataContext = this;
        }
    }
}
