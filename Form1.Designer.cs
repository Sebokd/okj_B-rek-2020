
namespace Berek2020_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_1_feladat = new System.Windows.Forms.Label();
            this.lbl_1_valasz = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_4_feladat_valasz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_DolgozoNeve = new System.Windows.Forms.Label();
            this.lbl_DolgozoNeme = new System.Windows.Forms.Label();
            this.lbl_DolgozoBelepese = new System.Windows.Forms.Label();
            this.lbl_DolgozoBere = new System.Windows.Forms.Label();
            this.btn_7_f_stat = new System.Windows.Forms.Button();
            this.lbl_beszerzes = new System.Windows.Forms.Label();
            this.lbl_karbantartas = new System.Windows.Forms.Label();
            this.lbl_szemelyzeti = new System.Windows.Forms.Label();
            this.lbl_asztalos = new System.Windows.Forms.Label();
            this.lbl_szerelok = new System.Windows.Forms.Label();
            this.lbl_asztalos_szam = new System.Windows.Forms.Label();
            this.lbl_beszerzes_adat = new System.Windows.Forms.Label();
            this.lbl_szemelyzeti_adat = new System.Windows.Forms.Label();
            this.lbl_karbantartas_adat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_1_feladat
            // 
            this.lbl_1_feladat.AutoSize = true;
            this.lbl_1_feladat.Location = new System.Drawing.Point(16, 39);
            this.lbl_1_feladat.Name = "lbl_1_feladat";
            this.lbl_1_feladat.Size = new System.Drawing.Size(255, 13);
            this.lbl_1_feladat.TabIndex = 0;
            this.lbl_1_feladat.Text = "3. feladat: hány dolgozóról vannak adatok a fileban?";
            // 
            // lbl_1_valasz
            // 
            this.lbl_1_valasz.AutoSize = true;
            this.lbl_1_valasz.Location = new System.Drawing.Point(37, 56);
            this.lbl_1_valasz.Name = "lbl_1_valasz";
            this.lbl_1_valasz.Size = new System.Drawing.Size(0, 13);
            this.lbl_1_valasz.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mutasd a válaszokat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "4. feladat: határozza meg az átlag bért, és írja ki!";
            // 
            // lbl_4_feladat_valasz
            // 
            this.lbl_4_feladat_valasz.AutoSize = true;
            this.lbl_4_feladat_valasz.Location = new System.Drawing.Point(37, 119);
            this.lbl_4_feladat_valasz.Name = "lbl_4_feladat_valasz";
            this.lbl_4_feladat_valasz.Size = new System.Drawing.Size(0, 13);
            this.lbl_4_feladat_valasz.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "5. Válasszon ki egy részleget!";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Név:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Neme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Belépés:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bér:";
            // 
            // lbl_DolgozoNeve
            // 
            this.lbl_DolgozoNeve.AutoSize = true;
            this.lbl_DolgozoNeve.Location = new System.Drawing.Point(69, 215);
            this.lbl_DolgozoNeve.Name = "lbl_DolgozoNeve";
            this.lbl_DolgozoNeve.Size = new System.Drawing.Size(0, 13);
            this.lbl_DolgozoNeve.TabIndex = 11;
            // 
            // lbl_DolgozoNeme
            // 
            this.lbl_DolgozoNeme.AutoSize = true;
            this.lbl_DolgozoNeme.Location = new System.Drawing.Point(72, 247);
            this.lbl_DolgozoNeme.Name = "lbl_DolgozoNeme";
            this.lbl_DolgozoNeme.Size = new System.Drawing.Size(0, 13);
            this.lbl_DolgozoNeme.TabIndex = 12;
            // 
            // lbl_DolgozoBelepese
            // 
            this.lbl_DolgozoBelepese.AutoSize = true;
            this.lbl_DolgozoBelepese.Location = new System.Drawing.Point(71, 279);
            this.lbl_DolgozoBelepese.Name = "lbl_DolgozoBelepese";
            this.lbl_DolgozoBelepese.Size = new System.Drawing.Size(0, 13);
            this.lbl_DolgozoBelepese.TabIndex = 13;
            // 
            // lbl_DolgozoBere
            // 
            this.lbl_DolgozoBere.AutoSize = true;
            this.lbl_DolgozoBere.Location = new System.Drawing.Point(72, 310);
            this.lbl_DolgozoBere.Name = "lbl_DolgozoBere";
            this.lbl_DolgozoBere.Size = new System.Drawing.Size(0, 13);
            this.lbl_DolgozoBere.TabIndex = 14;
            // 
            // btn_7_f_stat
            // 
            this.btn_7_f_stat.Location = new System.Drawing.Point(122, 609);
            this.btn_7_f_stat.Name = "btn_7_f_stat";
            this.btn_7_f_stat.Size = new System.Drawing.Size(76, 40);
            this.btn_7_f_stat.TabIndex = 16;
            this.btn_7_f_stat.Text = "Mutasd a statisztikát";
            this.btn_7_f_stat.UseVisualStyleBackColor = true;
            this.btn_7_f_stat.Click += new System.EventHandler(this.btn_7_f_stat_Click);
            // 
            // lbl_beszerzes
            // 
            this.lbl_beszerzes.AutoSize = true;
            this.lbl_beszerzes.Location = new System.Drawing.Point(19, 371);
            this.lbl_beszerzes.Name = "lbl_beszerzes";
            this.lbl_beszerzes.Size = new System.Drawing.Size(35, 13);
            this.lbl_beszerzes.TabIndex = 17;
            this.lbl_beszerzes.Text = "label7";
            // 
            // lbl_karbantartas
            // 
            this.lbl_karbantartas.AutoSize = true;
            this.lbl_karbantartas.Location = new System.Drawing.Point(19, 404);
            this.lbl_karbantartas.Name = "lbl_karbantartas";
            this.lbl_karbantartas.Size = new System.Drawing.Size(35, 13);
            this.lbl_karbantartas.TabIndex = 18;
            this.lbl_karbantartas.Text = "label7";
            // 
            // lbl_szemelyzeti
            // 
            this.lbl_szemelyzeti.AutoSize = true;
            this.lbl_szemelyzeti.Location = new System.Drawing.Point(19, 445);
            this.lbl_szemelyzeti.Name = "lbl_szemelyzeti";
            this.lbl_szemelyzeti.Size = new System.Drawing.Size(35, 13);
            this.lbl_szemelyzeti.TabIndex = 19;
            this.lbl_szemelyzeti.Text = "label7";
            // 
            // lbl_asztalos
            // 
            this.lbl_asztalos.AutoSize = true;
            this.lbl_asztalos.Location = new System.Drawing.Point(19, 477);
            this.lbl_asztalos.Name = "lbl_asztalos";
            this.lbl_asztalos.Size = new System.Drawing.Size(35, 13);
            this.lbl_asztalos.TabIndex = 20;
            this.lbl_asztalos.Text = "label7";
            // 
            // lbl_szerelok
            // 
            this.lbl_szerelok.AutoSize = true;
            this.lbl_szerelok.Location = new System.Drawing.Point(19, 516);
            this.lbl_szerelok.Name = "lbl_szerelok";
            this.lbl_szerelok.Size = new System.Drawing.Size(35, 13);
            this.lbl_szerelok.TabIndex = 21;
            this.lbl_szerelok.Text = "label7";
            // 
            // lbl_asztalos_szam
            // 
            this.lbl_asztalos_szam.AutoSize = true;
            this.lbl_asztalos_szam.Location = new System.Drawing.Point(109, 477);
            this.lbl_asztalos_szam.Name = "lbl_asztalos_szam";
            this.lbl_asztalos_szam.Size = new System.Drawing.Size(35, 13);
            this.lbl_asztalos_szam.TabIndex = 22;
            this.lbl_asztalos_szam.Text = "label7";
            // 
            // lbl_beszerzes_adat
            // 
            this.lbl_beszerzes_adat.AutoSize = true;
            this.lbl_beszerzes_adat.Location = new System.Drawing.Point(109, 371);
            this.lbl_beszerzes_adat.Name = "lbl_beszerzes_adat";
            this.lbl_beszerzes_adat.Size = new System.Drawing.Size(35, 13);
            this.lbl_beszerzes_adat.TabIndex = 23;
            this.lbl_beszerzes_adat.Text = "label7";
            // 
            // lbl_szemelyzeti_adat
            // 
            this.lbl_szemelyzeti_adat.AutoSize = true;
            this.lbl_szemelyzeti_adat.Location = new System.Drawing.Point(109, 445);
            this.lbl_szemelyzeti_adat.Name = "lbl_szemelyzeti_adat";
            this.lbl_szemelyzeti_adat.Size = new System.Drawing.Size(35, 13);
            this.lbl_szemelyzeti_adat.TabIndex = 24;
            this.lbl_szemelyzeti_adat.Text = "label7";
            // 
            // lbl_karbantartas_adat
            // 
            this.lbl_karbantartas_adat.AutoSize = true;
            this.lbl_karbantartas_adat.Location = new System.Drawing.Point(109, 404);
            this.lbl_karbantartas_adat.Name = "lbl_karbantartas_adat";
            this.lbl_karbantartas_adat.Size = new System.Drawing.Size(35, 13);
            this.lbl_karbantartas_adat.TabIndex = 25;
            this.lbl_karbantartas_adat.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 661);
            this.Controls.Add(this.lbl_karbantartas_adat);
            this.Controls.Add(this.lbl_szemelyzeti_adat);
            this.Controls.Add(this.lbl_beszerzes_adat);
            this.Controls.Add(this.lbl_asztalos_szam);
            this.Controls.Add(this.lbl_szerelok);
            this.Controls.Add(this.lbl_asztalos);
            this.Controls.Add(this.lbl_szemelyzeti);
            this.Controls.Add(this.lbl_karbantartas);
            this.Controls.Add(this.lbl_beszerzes);
            this.Controls.Add(this.btn_7_f_stat);
            this.Controls.Add(this.lbl_DolgozoBere);
            this.Controls.Add(this.lbl_DolgozoBelepese);
            this.Controls.Add(this.lbl_DolgozoNeme);
            this.Controls.Add(this.lbl_DolgozoNeve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_4_feladat_valasz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_1_valasz);
            this.Controls.Add(this.lbl_1_feladat);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1_feladat;
        private System.Windows.Forms.Label lbl_1_valasz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_4_feladat_valasz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_DolgozoNeve;
        private System.Windows.Forms.Label lbl_DolgozoNeme;
        private System.Windows.Forms.Label lbl_DolgozoBelepese;
        private System.Windows.Forms.Label lbl_DolgozoBere;
        private System.Windows.Forms.Button btn_7_f_stat;
        private System.Windows.Forms.Label lbl_beszerzes;
        private System.Windows.Forms.Label lbl_karbantartas;
        private System.Windows.Forms.Label lbl_szemelyzeti;
        private System.Windows.Forms.Label lbl_asztalos;
        private System.Windows.Forms.Label lbl_szerelok;
        private System.Windows.Forms.Label lbl_asztalos_szam;
        private System.Windows.Forms.Label lbl_beszerzes_adat;
        private System.Windows.Forms.Label lbl_szemelyzeti_adat;
        private System.Windows.Forms.Label lbl_karbantartas_adat;
    }
}

