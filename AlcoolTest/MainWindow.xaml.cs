﻿using System;
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
        private string[] m_heure = { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" };
        private string[] m_minute = { "00", "15", "30", "45" };
        private CBuveur m_buveur;
        private List<Alcool> m_alcool = new List<Alcool>();
        private int nb_biere;
        private int nb_vin;
        private int nb_fort;
        private int nb_shot;
        private int nb_champagne;

        public MainWindow()
        {
            InitializeComponent();
            init_comboBox();
            init_comboHeure();
            init_button();
            m_alcool.Add(new Alcool("Biere", 5.0));
            m_alcool.Add(new Alcool("Vin", 12.0));
            m_alcool.Add(new Alcool("Fort", 45.0));
            m_alcool.Add(new Alcool("Shooter", 40.0));
            m_alcool.Add(new Alcool("Champagne", 12.0));
            nb_biere = 0;
            nb_vin = 0;
            nb_fort = 0;
            nb_shot = 0;
            nb_champagne = 0;
        }

        private void init_comboBox()
        {
            comboSexe.Items.Clear();
            foreach (string sexe in m_sexe)
                comboSexe.Items.Add(sexe);
        }

        private void init_button()
        {
            button_biere_moin.IsEnabled = false;
            button_fort_moin.IsEnabled = false;
            button_vin_moin.IsEnabled = false;
            button_shooter_moin.IsEnabled = false;
            button_champagne_moin.IsEnabled = false;
        }

        private void init_comboHeure()
        {
            premier_heure.Items.Clear();
            premier_minute.Items.Clear();
            dernier_heure.Items.Clear();
            dernier_minute.Items.Clear();
            foreach (string data_heure in m_heure)
            {
                premier_heure.Items.Add(data_heure);
                dernier_heure.Items.Add(data_heure);
            }

            foreach(string data_minute in m_minute)
            {
                premier_minute.Items.Add(data_minute);
                dernier_minute.Items.Add(data_minute);
            }
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
            else if (button_type.Equals("button_champagne_plus"))
            {
                nb_champagne++;
                String nb = label_champagne.Content.ToString();
                label_champagne.Content = nb.Replace(nb, nb_champagne.ToString());
                if (nb_champagne > 0)
                    button_champagne_moin.IsEnabled = true;
            }
            else if (button_type.Equals("button_champagne_moin"))
            {
                nb_champagne--;
                if (nb_champagne >= 0)
                {
                    String nb = label_champagne.Content.ToString();
                    label_champagne.Content = nb.Replace(nb, nb_champagne.ToString());
                    if (nb_champagne == 0)
                        button_champagne_moin.IsEnabled = false;
                }
                
            }

        }

        private int get_qte_alcool(string alcool_name)
        {
            if (alcool_name.Equals("Biere"))
                return (Int32.Parse(label_biere.Content.ToString()) * 25);
            else if (alcool_name.Equals("Vin"))
                return (Int32.Parse(label_vin.Content.ToString()) * 12);
            else if (alcool_name.Equals("Fort"))
                return (Int32.Parse(label_fort.Content.ToString()) * 10);
            else if (alcool_name.Equals("Shooter"))
                return (Int32.Parse(label_shooter.Content.ToString()) * 3);
            else if (alcool_name.Equals("Champagne"))
                return (Int32.Parse(label_champagne.Content.ToString()) * 10);
            return 0;
        }

        private void calcul(object sender, RoutedEventArgs e)
        {
            if (!isEmpty())
            {
                bool isHomme;
                if (comboSexe.Text.Equals("Homme"))
                    isHomme = true;
                else
                    isHomme = false;
                int ok_convert;
                if (Int32.TryParse(text_poids.Text, out ok_convert))
                {
                    m_buveur = new CBuveur(isHomme, Int32.Parse(text_poids.Text));
                    foreach(Alcool alc in m_alcool)
                        m_buveur.MAJ_alcoolemie(get_qte_alcool(alc.get_nom()), alc.get_taux());
                    setMessage("Votre taux d'alcoolémie est de " + m_buveur.get_alcoolemie().ToString(".##") + " g/l");
                }
                else
                    setMessageError("Le poids saisi est éroné");
            }
            else
            {
                setMessageError("Vous avez oublié de remplir tous les champs dans la catégorie \"Information utilisateur\" !");
            }
        }

        private void setMessageError(string message)
        {
            Messagelog.Content = message;
            Messagelog.Foreground = new SolidColorBrush(Colors.White);
            Content_Message.Fill = new SolidColorBrush(Colors.Red);
        }

        private void setMessage(string message)
        {
            Messagelog.Content = message;
            Messagelog.Foreground = new SolidColorBrush(Colors.Black);
            Content_Message.Fill = new SolidColorBrush(Colors.Green);
        }

        private bool isEmpty()
        {
            if (String.IsNullOrEmpty(text_poids.Text) || String.IsNullOrEmpty(comboSexe.Text) || 
                String.IsNullOrEmpty(premier_heure.Text) || String.IsNullOrEmpty(premier_minute.Text) || 
                String.IsNullOrEmpty(dernier_heure.Text) || String.IsNullOrEmpty(dernier_minute.Text))
                return true;
            else
                return false;
        }

        private void reset_information(object sender, RoutedEventArgs e)
        {
            m_buveur = null;
            nb_biere = 0;
            nb_vin = 0;
            nb_fort = 0;
            nb_shot = 0;
            nb_champagne = 0;
            label_biere.Content = "0";
            label_vin.Content = "0";
            label_fort.Content = "0";
            label_shooter.Content = "0";
            label_champagne.Content = "0";
            text_nom.Text = "";
            text_poids.Text = "";
            text_prenom.Text = "";
            setMessage("Aucune erreur pour l'instant");
            init_comboBox();
            init_comboHeure();
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

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
