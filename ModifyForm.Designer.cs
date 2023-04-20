namespace diafilm
{
    partial class ModifyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.tbKiadasEve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKocka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNem = new System.Windows.Forms.RadioButton();
            this.rbIgen = new System.Windows.Forms.RadioButton();
            this.cbKiado = new System.Windows.Forms.ComboBox();
            this.btnFelvetel = new System.Windows.Forms.Button();
            this.btnModositas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cím";
            // 
            // tbCim
            // 
            this.tbCim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCim.Location = new System.Drawing.Point(134, 23);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(320, 29);
            this.tbCim.TabIndex = 1;
            // 
            // tbKiadasEve
            // 
            this.tbKiadasEve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKiadasEve.Location = new System.Drawing.Point(134, 67);
            this.tbKiadasEve.Name = "tbKiadasEve";
            this.tbKiadasEve.Size = new System.Drawing.Size(115, 29);
            this.tbKiadasEve.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiadás éve";
            // 
            // tbKocka
            // 
            this.tbKocka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKocka.Location = new System.Drawing.Point(134, 111);
            this.tbKocka.Name = "tbKocka";
            this.tbKocka.Size = new System.Drawing.Size(115, 29);
            this.tbKocka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Képkockaszám";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kiadó";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNem);
            this.groupBox1.Controls.Add(this.rbIgen);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(19, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Színes?";
            // 
            // rbNem
            // 
            this.rbNem.AutoSize = true;
            this.rbNem.Location = new System.Drawing.Point(129, 34);
            this.rbNem.Name = "rbNem";
            this.rbNem.Size = new System.Drawing.Size(59, 25);
            this.rbNem.TabIndex = 1;
            this.rbNem.TabStop = true;
            this.rbNem.Text = "nem";
            this.rbNem.UseVisualStyleBackColor = true;
            // 
            // rbIgen
            // 
            this.rbIgen.AutoSize = true;
            this.rbIgen.Location = new System.Drawing.Point(27, 34);
            this.rbIgen.Name = "rbIgen";
            this.rbIgen.Size = new System.Drawing.Size(58, 25);
            this.rbIgen.TabIndex = 0;
            this.rbIgen.TabStop = true;
            this.rbIgen.Text = "igen";
            this.rbIgen.UseVisualStyleBackColor = true;
            // 
            // cbKiado
            // 
            this.cbKiado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbKiado.FormattingEnabled = true;
            this.cbKiado.Location = new System.Drawing.Point(134, 242);
            this.cbKiado.Name = "cbKiado";
            this.cbKiado.Size = new System.Drawing.Size(320, 29);
            this.cbKiado.TabIndex = 10;
            // 
            // btnFelvetel
            // 
            this.btnFelvetel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFelvetel.Location = new System.Drawing.Point(19, 292);
            this.btnFelvetel.Name = "btnFelvetel";
            this.btnFelvetel.Size = new System.Drawing.Size(203, 46);
            this.btnFelvetel.TabIndex = 11;
            this.btnFelvetel.Text = "Felvétel";
            this.btnFelvetel.UseVisualStyleBackColor = true;
            this.btnFelvetel.Click += new System.EventHandler(this.OnBtnFelvetelClick);
            // 
            // btnModositas
            // 
            this.btnModositas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModositas.Location = new System.Drawing.Point(251, 292);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(203, 46);
            this.btnModositas.TabIndex = 12;
            this.btnModositas.Text = "Módosítás";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.OnBtnModositasClick);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 350);
            this.Controls.Add(this.btnModositas);
            this.Controls.Add(this.btnFelvetel);
            this.Controls.Add(this.cbKiado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKocka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKiadasEve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.label1);
            this.Name = "ModifyForm";
<<<<<<< HEAD
            this.Text = "Módosítási form";
=======
            this.Text = "ModifyForm";
>>>>>>> 15c0f96d68eb91b82e2e12595307d2dfbd8df25e
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbCim;
        private TextBox tbKiadasEve;
        private Label label2;
        private TextBox tbKocka;
        private Label label3;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rbNem;
        private RadioButton rbIgen;
        private ComboBox cbKiado;
        private Button btnFelvetel;
        private Button btnModositas;
    }
}