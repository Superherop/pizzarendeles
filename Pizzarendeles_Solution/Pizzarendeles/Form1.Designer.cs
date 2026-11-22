namespace Pizzarendeles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            grpUgyfelRogzites = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            grpUjRendeles = new GroupBox();
            btnRendeles = new Button();
            nudDarab = new NumericUpDown();
            dtRendelesDatum = new DateTimePicker();
            cmbPizza = new ComboBox();
            lblDatum = new Label();
            lblDarab = new Label();
            lblPizza = new Label();
            lblKivalasztott = new Label();
            grpUgyfelKereses = new GroupBox();
            lstUgyfel = new ListBox();
            lblKeres = new Label();
            txtKereses = new TextBox();
            dgvRendelesek = new DataGridView();
            lblOsszesRendeles = new Label();
            lblNev = new Label();
            groupBox1 = new GroupBox();
            btnMentes = new Button();
            txtCim = new TextBox();
            txtTelefon = new TextBox();
            txtNev = new TextBox();
            lblCim = new Label();
            lblTelefon = new Label();
            btnOsszesRendeles = new Button();
            grpUgyfelRogzites.SuspendLayout();
            grpUjRendeles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDarab).BeginInit();
            grpUgyfelKereses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRendelesek).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(51, 37);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 0;
            label1.Text = "Pizza Rendlés nyilvántartó";
            // 
            // grpUgyfelRogzites
            // 
            grpUgyfelRogzites.Controls.Add(label6);
            grpUgyfelRogzites.Controls.Add(label5);
            grpUgyfelRogzites.Location = new Point(51, 104);
            grpUgyfelRogzites.Name = "grpUgyfelRogzites";
            grpUgyfelRogzites.Size = new Size(277, 223);
            grpUgyfelRogzites.TabIndex = 1;
            grpUgyfelRogzites.TabStop = false;
            grpUgyfelRogzites.Text = "Új Ügyfél rögzítése";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 138);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 3;
            label6.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 87);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 3;
            label5.Text = "label2";
            // 
            // grpUjRendeles
            // 
            grpUjRendeles.Controls.Add(btnRendeles);
            grpUjRendeles.Controls.Add(nudDarab);
            grpUjRendeles.Controls.Add(dtRendelesDatum);
            grpUjRendeles.Controls.Add(cmbPizza);
            grpUjRendeles.Controls.Add(lblDatum);
            grpUjRendeles.Controls.Add(lblDarab);
            grpUjRendeles.Controls.Add(lblPizza);
            grpUjRendeles.Controls.Add(lblKivalasztott);
            grpUjRendeles.Location = new Point(51, 365);
            grpUjRendeles.Name = "grpUjRendeles";
            grpUjRendeles.Size = new Size(318, 253);
            grpUjRendeles.TabIndex = 1;
            grpUjRendeles.TabStop = false;
            grpUjRendeles.Text = "Új rendelés";
            // 
            // btnRendeles
            // 
            btnRendeles.BackColor = SystemColors.Control;
            btnRendeles.Location = new Point(110, 202);
            btnRendeles.Name = "btnRendeles";
            btnRendeles.Size = new Size(135, 35);
            btnRendeles.TabIndex = 10;
            btnRendeles.Text = "Rendelés rögzítése";
            btnRendeles.UseVisualStyleBackColor = false;
            btnRendeles.Click += btnRendeles_Click;
            // 
            // nudDarab
            // 
            nudDarab.Location = new Point(78, 119);
            nudDarab.Name = "nudDarab";
            nudDarab.Size = new Size(167, 23);
            nudDarab.TabIndex = 8;
            // 
            // dtRendelesDatum
            // 
            dtRendelesDatum.Location = new Point(78, 158);
            dtRendelesDatum.Name = "dtRendelesDatum";
            dtRendelesDatum.Size = new Size(223, 23);
            dtRendelesDatum.TabIndex = 9;
            // 
            // cmbPizza
            // 
            cmbPizza.FormattingEnabled = true;
            cmbPizza.Location = new Point(78, 71);
            cmbPizza.Name = "cmbPizza";
            cmbPizza.Size = new Size(223, 23);
            cmbPizza.TabIndex = 7;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(19, 164);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(46, 15);
            lblDatum.TabIndex = 3;
            lblDatum.Text = "Dátum:";
            // 
            // lblDarab
            // 
            lblDarab.AutoSize = true;
            lblDarab.Location = new Point(19, 119);
            lblDarab.Name = "lblDarab";
            lblDarab.Size = new Size(41, 15);
            lblDarab.TabIndex = 3;
            lblDarab.Text = "Darab:";
            // 
            // lblPizza
            // 
            lblPizza.AutoSize = true;
            lblPizza.Location = new Point(19, 74);
            lblPizza.Name = "lblPizza";
            lblPizza.Size = new Size(36, 15);
            lblPizza.TabIndex = 3;
            lblPizza.Text = "Pizza:";
            // 
            // lblKivalasztott
            // 
            lblKivalasztott.AutoSize = true;
            lblKivalasztott.Location = new Point(19, 32);
            lblKivalasztott.Name = "lblKivalasztott";
            lblKivalasztott.Size = new Size(38, 15);
            lblKivalasztott.TabIndex = 3;
            lblKivalasztott.Text = "label2";
            // 
            // grpUgyfelKereses
            // 
            grpUgyfelKereses.Controls.Add(lstUgyfel);
            grpUgyfelKereses.Controls.Add(lblKeres);
            grpUgyfelKereses.Controls.Add(txtKereses);
            grpUgyfelKereses.Location = new Point(388, 104);
            grpUgyfelKereses.Name = "grpUgyfelKereses";
            grpUgyfelKereses.Size = new Size(294, 424);
            grpUgyfelKereses.TabIndex = 1;
            grpUgyfelKereses.TabStop = false;
            grpUgyfelKereses.Text = "Ügyfél keresése";
            // 
            // lstUgyfel
            // 
            lstUgyfel.FormattingEnabled = true;
            lstUgyfel.Location = new Point(15, 108);
            lstUgyfel.Name = "lstUgyfel";
            lstUgyfel.Size = new Size(256, 289);
            lstUgyfel.TabIndex = 6;
            lstUgyfel.SelectedIndexChanged += lstUgyfel_SelectedIndexChanged;
            // 
            // lblKeres
            // 
            lblKeres.AutoSize = true;
            lblKeres.Location = new Point(15, 36);
            lblKeres.Name = "lblKeres";
            lblKeres.Size = new Size(99, 15);
            lblKeres.TabIndex = 3;
            lblKeres.Text = "Név vagy telefon:";
            // 
            // txtKereses
            // 
            txtKereses.Location = new Point(15, 64);
            txtKereses.Name = "txtKereses";
            txtKereses.Size = new Size(256, 23);
            txtKereses.TabIndex = 5;
            txtKereses.TextChanged += txtKereses_TextChanged;
            // 
            // dgvRendelesek
            // 
            dgvRendelesek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRendelesek.Location = new Point(707, 104);
            dgvRendelesek.Name = "dgvRendelesek";
            dgvRendelesek.Size = new Size(922, 576);
            dgvRendelesek.TabIndex = 12;
            // 
            // lblOsszesRendeles
            // 
            lblOsszesRendeles.AutoSize = true;
            lblOsszesRendeles.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblOsszesRendeles.Location = new Point(707, 61);
            lblOsszesRendeles.Name = "lblOsszesRendeles";
            lblOsszesRendeles.Size = new Size(133, 21);
            lblOsszesRendeles.TabIndex = 3;
            lblOsszesRendeles.Text = "Összes Rendelés";
            // 
            // lblNev
            // 
            lblNev.AutoSize = true;
            lblNev.Location = new Point(70, 140);
            lblNev.Name = "lblNev";
            lblNev.Size = new Size(31, 15);
            lblNev.TabIndex = 3;
            lblNev.Text = "Név:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMentes);
            groupBox1.Controls.Add(txtCim);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtNev);
            groupBox1.Controls.Add(lblCim);
            groupBox1.Controls.Add(lblTelefon);
            groupBox1.Location = new Point(51, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Új Ügyfél rögzítése";
            // 
            // btnMentes
            // 
            btnMentes.BackColor = SystemColors.Control;
            btnMentes.Location = new Point(110, 188);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(135, 35);
            btnMentes.TabIndex = 4;
            btnMentes.Text = "Ügyfél mentése";
            btnMentes.UseVisualStyleBackColor = false;
            btnMentes.Click += btnMentes_Click;
            // 
            // txtCim
            // 
            txtCim.Location = new Point(96, 145);
            txtCim.Name = "txtCim";
            txtCim.Size = new Size(175, 23);
            txtCim.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(96, 84);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(175, 23);
            txtTelefon.TabIndex = 2;
            // 
            // txtNev
            // 
            txtNev.Location = new Point(96, 33);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(175, 23);
            txtNev.TabIndex = 1;
            // 
            // lblCim
            // 
            lblCim.AutoSize = true;
            lblCim.Location = new Point(19, 153);
            lblCim.Name = "lblCim";
            lblCim.Size = new Size(32, 15);
            lblCim.TabIndex = 3;
            lblCim.Text = "Cím:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(19, 87);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(49, 15);
            lblTelefon.TabIndex = 3;
            lblTelefon.Text = "Telefon:";
            // 
            // btnOsszesRendeles
            // 
            btnOsszesRendeles.BackColor = SystemColors.Control;
            btnOsszesRendeles.Location = new Point(1030, 56);
            btnOsszesRendeles.Name = "btnOsszesRendeles";
            btnOsszesRendeles.Size = new Size(135, 35);
            btnOsszesRendeles.TabIndex = 11;
            btnOsszesRendeles.Text = "Összes Rendelés";
            btnOsszesRendeles.UseVisualStyleBackColor = false;
            btnOsszesRendeles.Click += btnOsszesRendeles_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 711);
            Controls.Add(btnOsszesRendeles);
            Controls.Add(lblNev);
            Controls.Add(lblOsszesRendeles);
            Controls.Add(dgvRendelesek);
            Controls.Add(grpUjRendeles);
            Controls.Add(grpUgyfelKereses);
            Controls.Add(groupBox1);
            Controls.Add(grpUgyfelRogzites);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Pizza Rendelés";
            Load += Form1_Load;
            grpUgyfelRogzites.ResumeLayout(false);
            grpUgyfelRogzites.PerformLayout();
            grpUjRendeles.ResumeLayout(false);
            grpUjRendeles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDarab).EndInit();
            grpUgyfelKereses.ResumeLayout(false);
            grpUgyfelKereses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRendelesek).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpUgyfelRogzites;
        private GroupBox grpUjRendeles;
        private GroupBox grpUgyfelKereses;
        private Label label6;
        private Label label5;
        private Label lblKivalasztott;
        private Label lblKeres;
        private DataGridView dgvRendelesek;
        private Label lblOsszesRendeles;
        private Label lblNev;
        private GroupBox groupBox1;
        private Label lblCim;
        private Label lblTelefon;
        private Label lblDatum;
        private Label lblDarab;
        private Label lblPizza;
        private ListBox lstUgyfel;
        private TextBox txtKereses;
        private TextBox txtCim;
        private TextBox txtTelefon;
        private TextBox txtNev;
        private NumericUpDown nudDarab;
        private DateTimePicker dtRendelesDatum;
        private ComboBox cmbPizza;
        private Button btnMentes;
        private Button btnRendeles;
        private Button btnOsszesRendeles;
    }
}
