namespace ISISReporter
{
    partial class WordingOptionsForm
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
            this.lstStandardFields = new System.Windows.Forms.ListBox();
            this.lstRepeatedFields = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dateBackup = new System.Windows.Forms.DateTimePicker();
            this.lblBackupDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstStandardFields
            // 
            this.lstStandardFields.FormattingEnabled = true;
            this.lstStandardFields.Items.AddRange(new object[] {
            "PreP",
            "PreI",
            "PreA",
            "LitQ",
            "RespOptions",
            "NRCodes",
            "PstI",
            "PstP"});
            this.lstStandardFields.Location = new System.Drawing.Point(26, 123);
            this.lstStandardFields.Name = "lstStandardFields";
            this.lstStandardFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstStandardFields.Size = new System.Drawing.Size(96, 121);
            this.lstStandardFields.TabIndex = 0;
            this.lstStandardFields.SelectedIndexChanged += new System.EventHandler(this.lstStandardFields_SelectedIndexChanged);
            // 
            // lstRepeatedFields
            // 
            this.lstRepeatedFields.FormattingEnabled = true;
            this.lstRepeatedFields.Items.AddRange(new object[] {
            "PreP",
            "PreI",
            "PreA",
            "LitQ",
            "RespOptions",
            "NRCodes",
            "PstI",
            "PstP"});
            this.lstRepeatedFields.Location = new System.Drawing.Point(141, 123);
            this.lstRepeatedFields.Name = "lstRepeatedFields";
            this.lstRepeatedFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstRepeatedFields.Size = new System.Drawing.Size(87, 121);
            this.lstRepeatedFields.TabIndex = 1;
            this.lstRepeatedFields.SelectedIndexChanged += new System.EventHandler(this.lstRepeatedFields_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Standard Fields";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repeated Fields";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 20);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Wording options for";
            // 
            // dateBackup
            // 
            this.dateBackup.Checked = false;
            this.dateBackup.Location = new System.Drawing.Point(127, 47);
            this.dateBackup.Name = "dateBackup";
            this.dateBackup.ShowCheckBox = true;
            this.dateBackup.Size = new System.Drawing.Size(136, 20);
            this.dateBackup.TabIndex = 36;
            // 
            // lblBackupDate
            // 
            this.lblBackupDate.AutoSize = true;
            this.lblBackupDate.Location = new System.Drawing.Point(24, 47);
            this.lblBackupDate.Name = "lblBackupDate";
            this.lblBackupDate.Size = new System.Drawing.Size(97, 13);
            this.lblBackupDate.TabIndex = 37;
            this.lblBackupDate.Text = "Use wordings from:";
            // 
            // WordingOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 265);
            this.Controls.Add(this.lblBackupDate);
            this.Controls.Add(this.dateBackup);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRepeatedFields);
            this.Controls.Add(this.lstStandardFields);
            this.Name = "WordingOptionsForm";
            this.Text = "Wording Options";
            this.Load += new System.EventHandler(this.WordingOptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStandardFields;
        private System.Windows.Forms.ListBox lstRepeatedFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateBackup;
        private System.Windows.Forms.Label lblBackupDate;
    }
}