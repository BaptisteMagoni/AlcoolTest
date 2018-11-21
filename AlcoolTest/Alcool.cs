using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoolTest
{
    class Alcool
    {
        private string m_name;
        private int m_qte;
        private double m_degres;
        private string m_path_img;

        public Alcool(string name, int qte, double degres, string path_img)
        {
            this.m_name = name;
            this.m_qte = qte;
            this.m_degres = degres;
            this.m_path_img = path_img;
        }

        public void set_path(string path_img){ this.m_path_img = path_img; }
        public string get_path(){ return m_path_img; }
        public void set_name(string name){ this.m_name = name; }
        public string get_name(){ return m_name; }
        public void set_qte(int qte){ this.m_qte += qte; }
        public int get_qte(){ return m_qte; }
        public void set_degres(double degres) { this.m_degres = degres; }
        public double get_degres() { return m_degres; }
    }
}
