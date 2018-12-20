namespace ISISReporter
{
    partial class LabelOptionsForm
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
            this.chkVarLabel = new System.Windows.Forms.CheckBox();
            this.chkDomainLabel = new System.Windows.Forms.CheckBox();
            this.chkTopicLabel = new System.Windows.Forms.CheckBox();
            this.chkContentLabel = new System.Windows.Forms.CheckBox();
            this.chkProductLabel = new System.Windows.Forms.CheckBox();
            this.chkCombineLabels = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkVarLabel
            // 
            this.chkVarLabel.AutoSize = true;
            this.chkVarLabel.Location = new System.Drawing.Point(34, 83);
            this.chkVarLabel.Name = "chkVarLabel";
            this.chkVarLabel.Size = new System.Drawing.Size(68, 17);
            this.chkVarLabel.TabIndex = 0;
            this.chkVarLabel.Text = "VarLabel";
            this.chkVarLabel.UseVisualStyleBackColor = true;
            // 
            // chkDomainLabel
            // 
            this.chkDomainLabel.AutoSize = true;
            this.chkDomainLabel.Location = new System.Drawing.Point(34, 108);
            this.chkDomainLabel.Name = "chkDomainLabel";
            this.chkDomainLabel.Size = new System.Drawing.Size(91, 17);
            this.chkDomainLabel.TabIndex = 1;
            this.chkDomainLabel.Text = "Domain Label";
            this.chkDomainLabel.UseVisualStyleBackColor = true;
            // 
            // chkTopicLabel
            // 
            this.chkTopicLabel.AutoSize = true;
            this.chkTopicLabel.Location = new System.Drawing.Point(34, 131);
            this.chkTopicLabel.Name = "chkTopicLabel";
            this.chkTopicLabel.Size = new System.Drawing.Size(82, 17);
            this.chkTopicLabel.TabIndex = 2;
            this.chkTopicLabel.Text = "Topic Label";
            this.chkTopicLabel.UseVisualStyleBackColor = true;
            // 
            // chkContentLabel
            // 
            this.chkContentLabel.AutoSize = true;
            this.chkContentLabel.Location = new System.Drawing.Point(34, 154);
            this.chkContentLabel.Name = "chkContentLabel";
            this.chkContentLabel.Size = new System.Drawing.Size(92, 17);
            this.chkContentLabel.TabIndex = 3;
            this.chkContentLabel.Text = "Content Label";
            this.chkContentLabel.UseVisualStyleBackColor = true;
            // 
            // chkProductLabel
            // 
            this.chkProductLabel.AutoSize = true;
            this.chkProductLabel.Location = new System.Drawing.Point(34, 177);
            this.chkProductLabel.Name = "chkProductLabel";
            this.chkProductLabel.Size = new System.Drawing.Size(92, 17);
            this.chkProductLabel.TabIndex = 4;
            this.chkProductLabel.Text = "Product Label";
            this.chkProductLabel.UseVisualStyleBackColor = true;
            // 
            // chkCombineLabels
            // 
            this.chkCombineLabels.AutoSize = true;
            this.chkCombineLabels.Location = new System.Drawing.Point(164, 83);
            this.chkCombineLabels.Name = "chkCombineLabels";
            this.chkCombineLabels.Size = new System.Drawing.Size(101, 17);
            this.chkCombineLabels.TabIndex = 5;
            this.chkCombineLabels.Text = "Combine Labels";
            this.chkCombineLabels.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 20);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Add label to";
            // 
            // LabelOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 246);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkCombineLabels);
            this.Controls.Add(this.chkProductLabel);
            this.Controls.Add(this.chkContentLabel);
            this.Controls.Add(this.chkTopicLabel);
            this.Controls.Add(this.chkDomainLabel);
            this.Controls.Add(this.chkVarLabel);
            this.Name = "LabelOptionsForm";
            this.Text = "Label Options";
            this.Load += new System.EventHandler(this.LabelOptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkVarLabel;
        private System.Windows.Forms.CheckBox chkDomainLabel;
        private System.Windows.Forms.CheckBox chkTopicLabel;
        private System.Windows.Forms.CheckBox chkContentLabel;
        private System.Windows.Forms.CheckBox chkProductLabel;
        private System.Windows.Forms.CheckBox chkCombineLabels;
        private System.Windows.Forms.Label lblTitle;
    }
}