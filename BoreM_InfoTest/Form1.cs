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
        string[] statiCandidato = new string[] { "Disoccupato", "Lavoratore" };
        string[] lode = new string[] { "True", "False" };
        string[] testiButton = new string[] { "AGGIUNGI CANDIDATO", "AGGIORNA CANDIDATO" };
        bool aggiungi = true;
        public Form1() {
            candidati = new List<BoreM_Candidato>();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            dataGridView1.Columns.Add("nmatricola", "NUM MATRICOLA");
            dataGridView1.Columns.Add("nome", "NOME");
            dataGridView1.Columns.Add("extra1", "EXTRA 1");
            dataGridView1.Columns.Add("extra2", "EXTRA 2");

            comboBoxStato.DropDownStyle = comboBoxBOH2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStato.Items.AddRange(statiCandidato);
            comboBoxBOH2.Items.AddRange(lode);

            comboBoxStato.Text = statiCandidato[0];
            comboBoxBOH2.Text = lode[0];

            labelBOH1.Visible = labelBOH2.Visible = textBoxBOH1.Visible = comboBoxBOH2.Visible = false;
            comboBoxStato_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e) {/*aggiunta candidato*/
            if (!textBoxNMatricola.Text.All(char.IsDigit) || !textBoxBOH1.Text.All(char.IsDigit)) {
                string tmp;

                if (comboBoxStato.SelectedIndex == 0)
                    tmp = "voto di uscita";
                else
                    tmp = "numero di lavori";

                MessageBox.Show($"Inserire come matricola e come {tmp} un numero");
                return;
            }

            if (comboBoxStato.SelectedIndex == 0) {
                BoreM_Disoccupato tmp = new BoreM_Disoccupato(int.Parse(textBoxNMatricola.Text), textBoxNome.Text, byte.Parse(textBoxBOH1.Text), bool.Parse(comboBoxBOH2.Text));
                if (aggiungi)
                    AggiuntaCandidato(tmp);
                else
                    ModificaCandidato(tmp);
            } else if (comboBoxStato.SelectedIndex == 1) {
                BoreM_Lavoratore tmp = new BoreM_Lavoratore(int.Parse(textBoxNMatricola.Text), textBoxNome.Text, byte.Parse(textBoxBOH1.Text));
                if (aggiungi)
                    AggiuntaCandidato(tmp);
                else
                    ModificaCandidato(tmp);
            }

            aggiungi = true;
            RefreshDataGridView();
            ResetTutto();
        }
        private void comboBoxStato_SelectedIndexChanged(object sender, EventArgs e) {
            CambiaGrafica(comboBoxStato.SelectedIndex);
            ResetTutto();
        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (dataGridView1.SelectedRows[0].IsNewRow) {
                ResetTutto();
                return;
            }

            aggiungi = false;
            if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() != "") {
                comboBoxStato.Text = statiCandidato[0];
                comboBoxBOH2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            } else {
                comboBoxStato.Text = statiCandidato[1];
            }

            buttonAggiuntaCan.Text = testiButton[1];

            textBoxNMatricola.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxNome.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxBOH1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void buttonRimuoviCan_Click(object sender, EventArgs e) {/*rimuovi candidato*/
            if (dataGridView1.SelectedRows[0].IsNewRow) {
                return;
            }

            if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() != "") {
                BoreM_Disoccupato tmp = new BoreM_Disoccupato(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), byte.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()), bool.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()));
                RimuoviCandidato(tmp);
            } else {
                BoreM_Lavoratore tmp = new BoreM_Lavoratore(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), byte.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()));
                RimuoviCandidato(tmp);
            }
            RefreshDataGridView();
        }

        public void CambiaGrafica(int scelta) {
            if (scelta == 0) {
                labelBOH1.Text = "VOTO";
                labelBOH2.Text = "LODE";
                labelBOH1.Visible = labelBOH2.Visible = textBoxBOH1.Visible = comboBoxBOH2.Visible = true;
            } else {
                labelBOH1.Text = "NUM DI ESPERIENZE [5]";
                labelBOH1.Visible = textBoxBOH1.Visible = true;
                labelBOH2.Visible = comboBoxBOH2.Visible = false;/*resetto le altre 2*/
            }
        }
        public void ResetTutto() {
            textBoxBOH1.Text = textBoxNMatricola.Text = textBoxNome.Text = "";
            buttonAggiuntaCan.Text = testiButton[0];
        }

        public void RefreshDataGridView() {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string[] tmp = RitornaElementiPerDataGridView();

            for (int i = 0; i < tmp.Length; i++) {
                string[] tt = tmp[i].Split(';');
                if (tt.Length == 3) {
                    string[] ttt = new string[4];
                    for (int j = 0; j < tt.Length; j++) {
                        ttt[j] = tt[j];
                    }
                    ttt[tt.Length] = "";
                    dataGridView1.Rows.Add(ttt);
                } else
                    dataGridView1.Rows.Add(tt);
            }
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
            candidati.Sort();
            candidati.Reverse();
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
