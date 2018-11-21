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
namespace AlcoolTest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Alcool> m_alcool = new List<Alcool>();
        private Grid m_grid;

        public MainWindow()
        {
            InitializeComponent();
            m_grid = new Grid();
            Calcul.Content = m_grid;
            init_component();
        }

        public void init_component()
        {
            m_alcool.Add(new Alcool("Bièrre", 25, 4.5, "images/bg.jpg"));
            foreach (Alcool alcool in m_alcool)
                add_alcool(alcool.get_path());
        }

        public void add_tabcontent()
        {
            m_grid.Children.Add()
        }

        public void add_alcool(string image_path)
        {
            ImageBrush imgBrush = new ImageBrush();
            imgBrush.ImageSource = new BitmapImage(new Uri(@image_path, UriKind.Relative));
            Calcul.Background = imgBrush;
            m_grid.Children.Add(imgBrush);
        }
    }
}
