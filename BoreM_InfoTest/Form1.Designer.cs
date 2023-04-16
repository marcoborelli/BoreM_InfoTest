namespace BoreM_InfoTest {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAggiuntaCan = new System.Windows.Forms.Button();
            this.labelNMatricola = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNMatricola = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxStato = new System.Windows.Forms.ComboBox();
            this.labelStatLav = new System.Windows.Forms.Label();
            this.textBoxBOH1 = new System.Windows.Forms.TextBox();
            this.labelBOH1 = new System.Windows.Forms.Label();
            this.labelBOH2 = new System.Windows.Forms.Label();
            this.comboBoxBOH2 = new System.Windows.Forms.ComboBox();
            this.buttonRimuoviCan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // buttonAggiuntaCan
            // 
            this.buttonAggiuntaCan.Location = new System.Drawing.Point(600, 316);
            this.buttonAggiuntaCan.Name = "buttonAggiuntaCan";
            this.buttonAggiuntaCan.Size = new System.Drawing.Size(100, 54);
            this.buttonAggiuntaCan.TabIndex = 1;
            this.buttonAggiuntaCan.Text = "AGGIUNGI CANDIDATO";
            this.buttonAggiuntaCan.UseVisualStyleBackColor = true;
            this.buttonAggiuntaCan.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNMatricola
            // 
            this.labelNMatricola.AutoSize = true;
            this.labelNMatricola.Location = new System.Drawing.Point(491, 26);
            this.labelNMatricola.Name = "labelNMatricola";
            this.labelNMatricola.Size = new System.Drawing.Size(100, 13);
            this.labelNMatricola.TabIndex = 2;
            this.labelNMatricola.Text = "NUM. MATRICOLA";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(552, 52);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(39, 13);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "NOME";
            // 
            // textBoxNMatricola
            // 
            this.textBoxNMatricola.Location = new System.Drawing.Point(600, 19);
            this.textBoxNMatricola.Name = "textBoxNMatricola";
            this.textBoxNMatricola.Size = new System.Drawing.Size(100, 20);
            this.textBoxNMatricola.TabIndex = 4;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(600, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // comboBoxStato
            // 
            this.comboBoxStato.FormattingEnabled = true;
            this.comboBoxStato.Location = new System.Drawing.Point(600, 184);
            this.comboBoxStato.Name = "comboBoxStato";
            this.comboBoxStato.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStato.TabIndex = 6;
            this.comboBoxStato.SelectedIndexChanged += new System.EventHandler(this.comboBoxStato_SelectedIndexChanged);
            // 
            // labelStatLav
            // 
            this.labelStatLav.AutoSize = true;
            this.labelStatLav.Location = new System.Drawing.Point(480, 192);
            this.labelStatLav.Name = "labelStatLav";
            this.labelStatLav.Size = new System.Drawing.Size(114, 13);
            this.labelStatLav.TabIndex = 7;
            this.labelStatLav.Text = "STATO LAVORATIVO";
            // 
            // textBoxBOH1
            // 
            this.textBoxBOH1.Location = new System.Drawing.Point(600, 71);
            this.textBoxBOH1.Name = "textBoxBOH1";
            this.textBoxBOH1.Size = new System.Drawing.Size(100, 20);
            this.textBoxBOH1.TabIndex = 8;
            // 
            // labelBOH1
            // 
            this.labelBOH1.AutoSize = true;
            this.labelBOH1.Location = new System.Drawing.Point(462, 78);
            this.labelBOH1.Name = "labelBOH1";
            this.labelBOH1.Size = new System.Drawing.Size(35, 13);
            this.labelBOH1.TabIndex = 10;
            this.labelBOH1.Text = "label1";
            // 
            // labelBOH2
            // 
            this.labelBOH2.AutoSize = true;
            this.labelBOH2.Location = new System.Drawing.Point(556, 105);
            this.labelBOH2.Name = "labelBOH2";
            this.labelBOH2.Size = new System.Drawing.Size(35, 13);
            this.labelBOH2.TabIndex = 11;
            this.labelBOH2.Text = "label1";
            // 
            // comboBoxBOH2
            // 
            this.comboBoxBOH2.FormattingEnabled = true;
            this.comboBoxBOH2.Location = new System.Drawing.Point(600, 97);
            this.comboBoxBOH2.Name = "comboBoxBOH2";
            this.comboBoxBOH2.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBOH2.TabIndex = 12;
            // 
            // buttonRimuoviCan
            // 
            this.buttonRimuoviCan.Location = new System.Drawing.Point(483, 316);
            this.buttonRimuoviCan.Name = "buttonRimuoviCan";
            this.buttonRimuoviCan.Size = new System.Drawing.Size(100, 54);
            this.buttonRimuoviCan.TabIndex = 13;
            this.buttonRimuoviCan.Text = "RIMUOVI CANDIDATO";
            this.buttonRimuoviCan.UseVisualStyleBackColor = true;
            this.buttonRimuoviCan.Click += new System.EventHandler(this.buttonRimuoviCan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.buttonRimuoviCan);
            this.Controls.Add(this.comboBoxBOH2);
            this.Controls.Add(this.labelBOH2);
            this.Controls.Add(this.labelBOH1);
            this.Controls.Add(this.textBoxBOH1);
            this.Controls.Add(this.labelStatLav);
            this.Controls.Add(this.comboBoxStato);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNMatricola);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelNMatricola);
            this.Controls.Add(this.buttonAggiuntaCan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAggiuntaCan;
        private System.Windows.Forms.Label labelNMatricola;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNMatricola;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.ComboBox comboBoxStato;
        private System.Windows.Forms.Label labelStatLav;
        private System.Windows.Forms.TextBox textBoxBOH1;
        private System.Windows.Forms.Label labelBOH1;
        private System.Windows.Forms.Label labelBOH2;
        private System.Windows.Forms.ComboBox comboBoxBOH2;
        private System.Windows.Forms.Button buttonRimuoviCan;
    }
}

