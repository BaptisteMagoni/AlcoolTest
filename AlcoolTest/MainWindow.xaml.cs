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

        private string[] m_sexe = {"Homme","Femme"};
        private CBuveur m_buveur;
        private int nb_biere;
        private int nb_vin;
        private int nb_fort;
        private int nb_shot;

        public MainWindow()
        {
            InitializeComponent();
            init_comboBox();
            init_button();
            nb_biere = 0;
            nb_vin = 0;
            nb_fort = 0;
            nb_shot = 0;
        }

        private void init_comboBox()
        {
            foreach (string sexe in m_sexe)
                comboSexe.Items.Add(sexe);
        }

        private void init_button()
        {
            button_biere_moin.IsEnabled = false;
            button_fort_moin.IsEnabled = false;
            button_vin_moin.IsEnabled = false;
            button_shooter_moin.IsEnabled = false;
        }

        private void gestion_incrementation(object sender, RoutedEventArgs e)
        {   
            String button_type = ((Button)sender).Name.ToString();
            if (button_type.Equals("button_biere_plus"))
            {
                nb_biere++;
                String nb = label_biere.Content.ToString();
                label_biere.Content = nb.Replace(nb, nb_biere.ToString());
                if (nb_biere > 0)
                    button_biere_moin.IsEnabled = true;
            }
            else if (button_type.Equals("button_biere_moin"))
            {
                nb_biere--;
                if(nb_biere >= 0)
                {
                    String nb = label_biere.Content.ToString();
                    label_biere.Content = nb.Replace(nb, nb_biere.ToString());
                    if (nb_biere == 0)
                        button_biere_moin.IsEnabled = false;
                }
                
            }
            else if (button_type.Equals("button_vin_plus"))
            {
                nb_vin++;
                String nb = label_vin.Content.ToString();
                label_vin.Content = nb.Replace(nb, nb_vin.ToString());
                if (nb_vin > 0)
                    button_vin_moin.IsEnabled = true;
            }
            else if (button_type.Equals("button_vin_moin"))
            {
                nb_vin--;
                if (nb_vin >= 0)
                {
                    String nb = label_vin.Content.ToString();
                    label_vin.Content = nb.Replace(nb, nb_vin.ToString());
                    if (nb_vin == 0)
                        button_vin_moin.IsEnabled = false;
                }

            }
            else if (button_type.Equals("button_fort_plus"))
            {
                nb_fort++;
                String nb = label_fort.Content.ToString();
                label_fort.Content = nb.Replace(nb, nb_fort.ToString());
                if (nb_fort > 0)
                    button_fort_moin.IsEnabled = true;
            }
            else if (button_type.Equals("button_fort_moin"))
            {
                nb_fort--;
                if (nb_fort >= 0)
                {
                    String nb = label_fort.Content.ToString();
                    label_fort.Content = nb.Replace(nb, nb_fort.ToString());
                    if (nb_fort == 0)
                        button_fort_moin.IsEnabled = false;
                }

            }
            else if (button_type.Equals("button_shooter_plus"))
            {
                nb_shot++;
                String nb = label_shooter.Content.ToString();
                label_shooter.Content = nb.Replace(nb, nb_shot.ToString());
                if (nb_shot > 0)
                    button_shooter_moin.IsEnabled = true;
            }
            else if (button_type.Equals("button_shooter_moin"))
            {
                nb_shot--;
                if (nb_shot >= 0)
                {
                    String nb = label_shooter.Content.ToString();
                    label_shooter.Content = nb.Replace(nb, nb_shot.ToString());
                    if (nb_shot == 0)
                        button_shooter_moin.IsEnabled = false;
                }

            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
