using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoreM_InfoTest {
    public partial class Form1 : Form {
        List<BoreM_Candidato> candidati;/*non uso dizionario perchè la chiave è il nome ma non ho un valore vero da associare poi*/
        public Form1() {
            candidati = new List<BoreM_Candidato>();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

        }

        public bool AggiuntaCandidato(BoreM_Candidato c) {
            if (candidati.Contains(c) || c == null) {
                return false;
            }
            candidati.Add(c);
            return true;
        }

        public string[] RitornaElementiPerDataGridView() {
            string[] tmp = new string[candidati.Count()];

            for (int i = 0; i < tmp.Length; i++) {
                tmp[i] = candidati[i].ToString();
            }

            return tmp;
        }

        public bool ModificaCandidato(BoreM_Candidato c) {/*true= modificato correttamente false=non modificato*/
            if (c == null)
                return false;

            int matricola = c.BoreM_matricola; /*assumo che la matricola resti immutata*/
            int lungh = candidati.Count();

            for (int i = 0; i < lungh; i++) {
                if (candidati[i].BoreM_matricola == matricola) {
                    candidati[i] = c;/*lo riassegno direttamente*/
                    return true;
                }
            }
            return false; /*se sono fuori è perchè non ho trovato corrispondenza*/
        }

        public bool RimuoviCandidato(BoreM_Candidato c) {
            if (c == null)
                return false;

            return candidati.Remove(c);
        }

        public void OrdinaDecrescente() {
            candidati.OrderByDescending<>;
        }

        public string[] RitornaIdonei() {
            List<string> disoc = new List<string>();
            List<string> lav = new List<string>();

            int lungh = candidati.Count();

            for (int i = 0; i < lungh; i++) {
                if (candidati[i].IsIdoneo()) {
                    if (candidati[i].GetType() == typeof(BoreM_Lavoratore))
                        lav.Add(candidati[i].ToString());
                    else if (candidati[i].GetType() == typeof(BoreM_Disoccupato))
                        disoc.Add(candidati[i].ToString());

                }
            }

            List<string> tmp = new List<string>();
            tmp.AddRange(disoc);
            tmp.AddRange(lav);

            return tmp.ToArray();
        }
    }
}
