namespace HomeoPathPharmacy
{
    partial class SearchForm
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
            this.patentIdTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBookGrid = new System.Windows.Forms.DataGridView();
            this.treatmentBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchBookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Id";
            // 
            // patentIdTxt
            // 
            this.patentIdTxt.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patentIdTxt.Location = new System.Drawing.Point(226, 43);
            this.patentIdTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.patentIdTxt.Multiline = true;
            this.patentIdTxt.Name = "patentIdTxt";
            this.patentIdTxt.Size = new System.Drawing.Size(377, 33);
            this.patentIdTxt.TabIndex = 1;
            this.patentIdTxt.TextChanged += new System.EventHandler(this.patentIdTxt_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchBtn.FlatAppearance.BorderSize = 3;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchBtn.Location = new System.Drawing.Point(495, 172);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(108, 39);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBookGrid
            // 
            this.searchBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchBookGrid.Location = new System.Drawing.Point(-3, 287);
            this.searchBookGrid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchBookGrid.Name = "searchBookGrid";
            this.searchBookGrid.Size = new System.Drawing.Size(664, 124);
            this.searchBookGrid.TabIndex = 3;
            // 
            // treatmentBtn
            // 
            this.treatmentBtn.BackColor = System.Drawing.Color.Transparent;
            this.treatmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.treatmentBtn.FlatAppearance.BorderSize = 3;
            this.treatmentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.treatmentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.treatmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treatmentBtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.treatmentBtn.Location = new System.Drawing.Point(120, 172);
            this.treatmentBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.treatmentBtn.Name = "treatmentBtn";
            this.treatmentBtn.Size = new System.Drawing.Size(108, 39);
            this.treatmentBtn.TabIndex = 2;
            this.treatmentBtn.Text = "Treatment";
            this.treatmentBtn.UseVisualStyleBackColor = false;
            this.treatmentBtn.Click += new System.EventHandler(this.treatmentBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patient Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(226, 107);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(377, 33);
            this.nameTxt.TabIndex = 4;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomeoPathPharmacy.Properties.Resources._71;
            this.ClientSize = new System.Drawing.Size(660, 409);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.searchBookGrid);
            this.Controls.Add(this.treatmentBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patentIdTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchBookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patentIdTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView searchBookGrid;
        private System.Windows.Forms.Button treatmentBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
    }
}