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

        public Alcool(string nom, double taux)
        {
            m_nom = nom;
            m_taux = taux;
        }

        public string get_nom() { return m_nom; }
        public double get_taux() { return m_taux; }
    }
}
