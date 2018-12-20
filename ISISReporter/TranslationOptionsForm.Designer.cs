namespace ISISReporter
{
    partial class TranslationOptionsForm
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
            this.lstTranslationFields = new System.Windows.Forms.ListBox();
            this.chkEnglishRouting = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTranslationFields
            // 
            this.lstTranslationFields.FormattingEnabled = true;
            this.lstTranslationFields.Location = new System.Drawing.Point(89, 69);
            this.lstTranslationFields.Name = "lstTranslationFields";
            this.lstTranslationFields.Size = new System.Drawing.Size(149, 108);
            this.lstTranslationFields.TabIndex = 0;
            // 
            // chkEnglishRouting
            // 
            this.chkEnglishRouting.AutoSize = true;
            this.chkEnglishRouting.Location = new System.Drawing.Point(311, 71);
            this.chkEnglishRouting.Name = "chkEnglishRouting";
            this.chkEnglishRouting.Size = new System.Drawing.Size(100, 17);
            this.chkEnglishRouting.TabIndex = 1;
            this.chkEnglishRouting.Text = "English Routing";
            this.chkEnglishRouting.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 20);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Translation options for";
            // 
            // TranslationOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 230);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkEnglishRouting);
            this.Controls.Add(this.lstTranslationFields);
            this.Name = "TranslationOptionsForm";
            this.Text = "Translation Options";
            this.Load += new System.EventHandler(this.TranslationOptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTranslationFields;
        private System.Windows.Forms.CheckBox chkEnglishRouting;
        private System.Windows.Forms.Label lblTitle;
    }
}