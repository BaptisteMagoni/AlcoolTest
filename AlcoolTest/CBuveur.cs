using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace /* METTEZ ICI VOTRE NAMESPACE !!!!!!!!!!!!! */
{
    class CBuveur
    {
        /*** Attributs ***/

        private double coef_diffusion;      // true si c'est un homme
        private int poids;                  // en Kgs

        private double taux_alcoolemie;     // en gramme par litre de sang

        /*** Méthodes ***/

        public CBuveur()                    // <<< Constructeur par défaut de la classe CBuveur
        {
            coef_diffusion = 0.7;
            poids = 70;
            taux_alcoolemie = 0;
        }

        public CBuveur(bool sx, int pds)    // <<< Constructeur avec paramètres de la classe CBuveur
        {
            if (sx != true) coef_diffusion = 0.6;
            else coef_diffusion = 0.7;

            poids = pds;
            taux_alcoolemie = 0;
        }

        public void MAJ_alcoolemie(int qte, double tx)
        {
            double qte_totale_alc_absorbee; // en grammes

            qte_totale_alc_absorbee = (tx * qte * 8 * 0.01);
            taux_alcoolemie = taux_alcoolemie + (qte_totale_alc_absorbee / (poids * coef_diffusion));
        }

        public void reset_alcoolemie()
        {
            taux_alcoolemie = 0;
        }

        public bool get_sexe()
        {
            if (coef_diffusion == 0.7) return true;
            else return false;
        }

        public int get_poids()
        {
            return poids;
        }

        public double get_alcoolemie()
        {
            return taux_alcoolemie;
        }
    }
}
