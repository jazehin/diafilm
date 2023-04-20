namespace diafilm
{
    partial class MainForm
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
            this.dgvFilmek = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbKereses = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmek)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmek
            // 
            this.dgvFilmek.AllowUserToAddRows = false;
            this.dgvFilmek.AllowUserToDeleteRows = false;
            this.dgvFilmek.AllowUserToResizeRows = false;
            this.dgvFilmek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilmek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvFilmek.Location = new System.Drawing.Point(12, 47);
            this.dgvFilmek.MultiSelect = false;
            this.dgvFilmek.Name = "dgvFilmek";
            this.dgvFilmek.ReadOnly = true;
            this.dgvFilmek.RowHeadersVisible = false;
            this.dgvFilmek.RowTemplate.Height = 25;
            this.dgvFilmek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmek.Size = new System.Drawing.Size(575, 349);
            this.dgvFilmek.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cím";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kiadás éve";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Képkockaszám";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Színes-e";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kiadó";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tbKereses
            // 
            this.tbKereses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKereses.Location = new System.Drawing.Point(12, 12);
            this.tbKereses.Name = "tbKereses";
            this.tbKereses.PlaceholderText = "Keresés...";
            this.tbKereses.Size = new System.Drawing.Size(575, 29);
            this.tbKereses.TabIndex = 1;
            this.tbKereses.TextChanged += new System.EventHandler(this.OnTbKeresesTextChanged);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModify.Location = new System.Drawing.Point(12, 402);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(280, 40);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Diafilm módosítása";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.OnBtnModifyClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(307, 402);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(280, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Diafilm törlése";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnBtnDeleteClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.tbKereses);
            this.Controls.Add(this.dgvFilmek);
            this.Name = "MainForm";
            this.Text = "Diafilmek";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvFilmek;
        private TextBox tbKereses;
        private Button btnModify;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}