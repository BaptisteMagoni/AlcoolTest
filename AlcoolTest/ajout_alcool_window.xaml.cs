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

namespace AlcoolTest
{
    /// <summary>
    /// Logique d'interaction pour ajout_alcool_window.xaml
    /// </summary>
    public partial class ajout_alcool_window : Window
    {
        private string nom;
        private double taux;
        private int quantite;

        public ajout_alcool_window()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            nom = taux_text.Text;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            taux = (double)slider_taux.Value;
            lbl_taux.Content = "Le taux choisi est de : " + taux.ToString(".##") + "°";
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            quantite = (int)slider_qte.Value;
            lbl_qte.Content = "La quantité choisi est de : " + quantite.ToString() + "cl";
        }

        private void valide_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void raz_Click(object sender, RoutedEventArgs e)
        {
            reset_information();
        }

        private void reset_information()
        {
            slider_qte.Value = 0;
            slider_taux.Value = 0;
            lbl_qte.Content = "";
            lbl_taux.Content = "";
            taux_text.Text = "";
        }

        public string getNom()
        {
            return nom;
        }

        public double getTaux()
        {
            return taux;
        }

        public int getQte()
        {
            return quantite;
        }
    }
}
