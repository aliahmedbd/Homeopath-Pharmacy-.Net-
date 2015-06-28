namespace HomeoPathPharmacy
{
    partial class NewPatientForm
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
            this.patientNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.medicineNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paidTxt = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.newPatientGrid = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSymptom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.newPatientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientNameTxt
            // 
            this.patientNameTxt.Location = new System.Drawing.Point(175, 25);
            this.patientNameTxt.Multiline = true;
            this.patientNameTxt.Name = "patientNameTxt";
            this.patientNameTxt.Size = new System.Drawing.Size(338, 32);
            this.patientNameTxt.TabIndex = 1;
            this.patientNameTxt.TextChanged += new System.EventHandler(this.patientNameTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medicine Name";
            // 
            // medicineNameTxt
            // 
            this.medicineNameTxt.Location = new System.Drawing.Point(175, 120);
            this.medicineNameTxt.Multiline = true;
            this.medicineNameTxt.Name = "medicineNameTxt";
            this.medicineNameTxt.Size = new System.Drawing.Size(338, 32);
            this.medicineNameTxt.TabIndex = 2;
            this.medicineNameTxt.TextChanged += new System.EventHandler(this.medicineNameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount (taka)";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(175, 169);
            this.amountTxt.Multiline = true;
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(338, 32);
            this.amountTxt.TabIndex = 3;
            this.amountTxt.TextChanged += new System.EventHandler(this.amountTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(106, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Paid";
            // 
            // paidTxt
            // 
            this.paidTxt.Location = new System.Drawing.Point(175, 222);
            this.paidTxt.Multiline = true;
            this.paidTxt.Name = "paidTxt";
            this.paidTxt.Size = new System.Drawing.Size(338, 32);
            this.paidTxt.TabIndex = 4;
            this.paidTxt.TextChanged += new System.EventHandler(this.paidTxt_TextChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Add.FlatAppearance.BorderSize = 3;
            this.Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Location = new System.Drawing.Point(438, 274);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 35);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // newPatientGrid
            // 
            this.newPatientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newPatientGrid.Location = new System.Drawing.Point(1, 315);
            this.newPatientGrid.Name = "newPatientGrid";
            this.newPatientGrid.Size = new System.Drawing.Size(552, 68);
            this.newPatientGrid.TabIndex = 3;
            this.newPatientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.newPatientGrid_CellContentClick);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitBtn.FlatAppearance.BorderSize = 3;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(44, 274);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(70, 35);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Symptom";
            // 
            // txtSymptom
            // 
            this.txtSymptom.Location = new System.Drawing.Point(175, 74);
            this.txtSymptom.Multiline = true;
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.Size = new System.Drawing.Size(338, 28);
            this.txtSymptom.TabIndex = 7;
            this.txtSymptom.TextChanged += new System.EventHandler(this.txtSymptom_TextChanged);
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeoPathPharmacy.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(554, 384);
            this.Controls.Add(this.txtSymptom);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newPatientGrid);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.paidTxt);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.medicineNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientNameTxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NewPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPatientForm";
            this.Load += new System.EventHandler(this.NewPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newPatientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medicineNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paidTxt;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView newPatientGrid;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSymptom;
    }
}