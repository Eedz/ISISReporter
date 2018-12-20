namespace ISISReporter
{
    partial class CommentOptionsForm
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
            this.components = new System.ComponentModel.Container();
            this.lstCommentTypes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCommentAuthors = new System.Windows.Forms.ListBox();
            this.lstCommentSources = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this._isisDataSet = new ISISReporter._isisDataSet();
            this.tableAdapterManager = new ISISReporter._isisDataSetTableAdapters.TableAdapterManager();
            this.qryCommentsQuesAuthorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryCommentsQuesAuthorsTableAdapter = new ISISReporter._isisDataSetTableAdapters.qryCommentsQuesAuthorsTableAdapter();
            this.qryCommentsQuesSourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryCommentsQuesSourcesTableAdapter = new ISISReporter._isisDataSetTableAdapters.qryCommentsQuesSourcesTableAdapter();
            this.qryCommentsQuesTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qryCommentsQuesTypesTableAdapter = new ISISReporter._isisDataSetTableAdapters.qryCommentsQuesTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._isisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCommentsQuesAuthorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCommentsQuesSourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCommentsQuesTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCommentTypes
            // 
            this.lstCommentTypes.FormattingEnabled = true;
            this.lstCommentTypes.Location = new System.Drawing.Point(21, 99);
            this.lstCommentTypes.Name = "lstCommentTypes";
            this.lstCommentTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCommentTypes.Size = new System.Drawing.Size(124, 82);
            this.lstCommentTypes.TabIndex = 20;
            this.lstCommentTypes.SelectedIndexChanged += new System.EventHandler(this.lstCommentTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Choose Comments";
            // 
            // lstCommentAuthors
            // 
            this.lstCommentAuthors.FormattingEnabled = true;
            this.lstCommentAuthors.Location = new System.Drawing.Point(151, 99);
            this.lstCommentAuthors.Name = "lstCommentAuthors";
            this.lstCommentAuthors.Size = new System.Drawing.Size(104, 82);
            this.lstCommentAuthors.TabIndex = 23;
            this.lstCommentAuthors.SelectedIndexChanged += new System.EventHandler(this.lstCommentAuthors_SelectedIndexChanged);
            // 
            // lstCommentSources
            // 
            this.lstCommentSources.FormattingEnabled = true;
            this.lstCommentSources.Location = new System.Drawing.Point(261, 99);
            this.lstCommentSources.Name = "lstCommentSources";
            this.lstCommentSources.Size = new System.Drawing.Size(88, 82);
            this.lstCommentSources.TabIndex = 24;
            this.lstCommentSources.SelectedIndexChanged += new System.EventHandler(this.lstCommentSources_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Source Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Comments Since:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(17, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 20);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Add comments to";
            // 
            // _isisDataSet
            // 
            this._isisDataSet.DataSetName = "_isisDataSet";
            this._isisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ISISReporter._isisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qryCommentsQuesAuthorsBindingSource
            // 
            this.qryCommentsQuesAuthorsBindingSource.DataMember = "qryCommentsQuesAuthors";
            this.qryCommentsQuesAuthorsBindingSource.DataSource = this._isisDataSet;
            // 
            // qryCommentsQuesAuthorsTableAdapter
            // 
            this.qryCommentsQuesAuthorsTableAdapter.ClearBeforeFill = true;
            // 
            // qryCommentsQuesSourcesBindingSource
            // 
            this.qryCommentsQuesSourcesBindingSource.DataMember = "qryCommentsQuesSources";
            this.qryCommentsQuesSourcesBindingSource.DataSource = this._isisDataSet;
            // 
            // qryCommentsQuesSourcesTableAdapter
            // 
            this.qryCommentsQuesSourcesTableAdapter.ClearBeforeFill = true;
            // 
            // qryCommentsQuesTypesBindingSource
            // 
            this.qryCommentsQuesTypesBindingSource.DataMember = "qryCommentsQuesTypes";
            this.qryCommentsQuesTypesBindingSource.DataSource = this._isisDataSet;
            // 
            // qryCommentsQuesTypesTableAdapter
            // 
            this.qryCommentsQuesTypesTableAdapter.ClearBeforeFill = true;
            // 
            // CommentOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 224);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lstCommentSources);
            this.Controls.Add(this.lstCommentAuthors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCommentTypes);
            this.Name = "CommentOptionsForm";
            this.Text = "ExtraFieldsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommentOptionsForm_FormClosed);
            this.Load += new System.EventHandler(this.CommentOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._isisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCommentsQuesAuthorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCommentsQuesSourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCommentsQuesTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstCommentTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCommentAuthors;
        private System.Windows.Forms.ListBox lstCommentSources;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitle;
        private _isisDataSet _isisDataSet;
        private _isisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource qryCommentsQuesAuthorsBindingSource;
        private _isisDataSetTableAdapters.qryCommentsQuesAuthorsTableAdapter qryCommentsQuesAuthorsTableAdapter;
        private System.Windows.Forms.BindingSource qryCommentsQuesSourcesBindingSource;
        private _isisDataSetTableAdapters.qryCommentsQuesSourcesTableAdapter qryCommentsQuesSourcesTableAdapter;
        private System.Windows.Forms.BindingSource qryCommentsQuesTypesBindingSource;
        private _isisDataSetTableAdapters.qryCommentsQuesTypesTableAdapter qryCommentsQuesTypesTableAdapter;
    }
}