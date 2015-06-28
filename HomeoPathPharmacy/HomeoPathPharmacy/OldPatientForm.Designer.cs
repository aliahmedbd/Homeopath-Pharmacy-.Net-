namespace HomeoPathPharmacy
{
    partial class OldPatientForm
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
            this.patientIdTxt = new System.Windows.Forms.TextBox();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.medicineNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paidTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(63, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientIdTxt
            // 
            this.patientIdTxt.Location = new System.Drawing.Point(179, 30);
            this.patientIdTxt.Multiline = true;
            this.patientIdTxt.Name = "patientIdTxt";
            this.patientIdTxt.Size = new System.Drawing.Size(289, 35);
            this.patientIdTxt.TabIndex = 1;
            this.patientIdTxt.TextChanged += new System.EventHandler(this.patientIdTxt_TextChanged);
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.Color.Transparent;
            this.modifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modifyBtn.FlatAppearance.BorderSize = 2;
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyBtn.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modifyBtn.Location = new System.Drawing.Point(393, 275);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(89, 40);
            this.modifyBtn.TabIndex = 2;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medinice Name";
            // 
            // medicineNameTxt
            // 
            this.medicineNameTxt.Location = new System.Drawing.Point(179, 91);
            this.medicineNameTxt.Multiline = true;
            this.medicineNameTxt.Name = "medicineNameTxt";
            this.medicineNameTxt.Size = new System.Drawing.Size(289, 35);
            this.medicineNameTxt.TabIndex = 1;
            this.medicineNameTxt.TextChanged += new System.EventHandler(this.medicineNameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount (taka)";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(179, 151);
            this.amountTxt.Multiline = true;
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(289, 35);
            this.amountTxt.TabIndex = 1;
            this.amountTxt.TextChanged += new System.EventHandler(this.amountTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(99, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Paid";
            // 
            // paidTxt
            // 
            this.paidTxt.Location = new System.Drawing.Point(179, 214);
            this.paidTxt.Multiline = true;
            this.paidTxt.Name = "paidTxt";
            this.paidTxt.Size = new System.Drawing.Size(289, 35);
            this.paidTxt.TabIndex = 1;
            this.paidTxt.TextChanged += new System.EventHandler(this.paidTxt_TextChanged);
            // 
            // OldPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeoPathPharmacy.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(507, 327);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.paidTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.medicineNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientIdTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "OldPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OldPatientForm";
            this.Load += new System.EventHandler(this.OldPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientIdTxt;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medicineNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paidTxt;
    }
}