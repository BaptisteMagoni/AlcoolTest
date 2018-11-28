using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoolTest
{
    class Alcool
    {
        private string m_nom;
        private double m_taux;
        private int m_quantite;
        private bool isListBox;
        private bool estNouveauAlcool;

        public Alcool(string nom, double taux)
        {
            m_nom = nom;
            m_taux = taux;
            estNouveauAlcool = false;
            isListBox = false;
        }

        public Alcool(string nom, double taux, int qte)
        {
            m_nom = nom;
            m_taux = taux;
            m_quantite = qte;
            estNouveauAlcool = true;
            isListBox = true;
        }

        public string get_nom() { return m_nom; }
        public double get_taux() { return m_taux; }
        public int get_qte() { return m_quantite;  }
        public bool get_state() { return estNouveauAlcool; }
        public bool get_type() { return isListBox; }
    }
}
