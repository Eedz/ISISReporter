namespace ISISReporter
{
    partial class ReportForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optSelectWave = new System.Windows.Forms.RadioButton();
            this.lstCountryWave = new System.Windows.Forms.ListBox();
            this.optSelectCountry = new System.Windows.Forms.RadioButton();
            this.optSelectSurvey = new System.Windows.Forms.RadioButton();
            this.cmdRemoveSurvey = new System.Windows.Forms.Button();
            this.lstSelectedSurveys = new System.Windows.Forms.ListBox();
            this.cboSelectSurvey = new System.Windows.Forms.ComboBox();
            this.cmdAddSurvey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmdExpandSurveyPanel = new System.Windows.Forms.Button();
            this.cmdExpandVarNamePanel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qrySurveyQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._isisDataSet = new ISISReporter._isisDataSet();
            this.qrySurveyQuestionsTableAdapter = new ISISReporter._isisDataSetTableAdapters.qrySurveyQuestionsTableAdapter();
            this.tableAdapterManager = new ISISReporter._isisDataSetTableAdapters.TableAdapterManager();
            this.qrySurveyInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qrySurveyInfoTableAdapter = new ISISReporter._isisDataSetTableAdapters.qrySurveyInfoTableAdapter();
            this.qryStudyWavesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qryStudyWavesTableAdapter = new ISISReporter._isisDataSetTableAdapters.qryStudyWavesTableAdapter();
            this.qryCountryCodesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qryCountryCodesTableAdapter = new ISISReporter._isisDataSetTableAdapters.qryCountryCodesTableAdapter();
            this.cmdGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrySurveyQuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._isisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrySurveyInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryStudyWavesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCountryCodesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(52, 53);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(519, 576);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Specify Survey(s)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.optSelectWave);
            this.panel1.Controls.Add(this.lstCountryWave);
            this.panel1.Controls.Add(this.optSelectCountry);
            this.panel1.Controls.Add(this.optSelectSurvey);
            this.panel1.Controls.Add(this.cmdRemoveSurvey);
            this.panel1.Controls.Add(this.lstSelectedSurveys);
            this.panel1.Controls.Add(this.cboSelectSurvey);
            this.panel1.Controls.Add(this.cmdAddSurvey);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 245);
            this.panel1.TabIndex = 4;
            // 
            // optSelectWave
            // 
            this.optSelectWave.AutoSize = true;
            this.optSelectWave.Location = new System.Drawing.Point(20, 60);
            this.optSelectWave.Name = "optSelectWave";
            this.optSelectWave.Size = new System.Drawing.Size(75, 17);
            this.optSelectWave.TabIndex = 9;
            this.optSelectWave.TabStop = true;
            this.optSelectWave.Tag = "3";
            this.optSelectWave.Text = "By wave...";
            this.optSelectWave.UseVisualStyleBackColor = true;
            this.optSelectWave.CheckedChanged += new System.EventHandler(this.SelectSurveyBy);
            // 
            // lstCountryWave
            // 
            this.lstCountryWave.FormattingEnabled = true;
            this.lstCountryWave.Location = new System.Drawing.Point(115, 35);
            this.lstCountryWave.Name = "lstCountryWave";
            this.lstCountryWave.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCountryWave.Size = new System.Drawing.Size(73, 147);
            this.lstCountryWave.TabIndex = 8;
            this.lstCountryWave.SelectedIndexChanged += new System.EventHandler(this.lstCountryWave_SelectedIndexChanged);
            // 
            // optSelectCountry
            // 
            this.optSelectCountry.AutoSize = true;
            this.optSelectCountry.Location = new System.Drawing.Point(20, 35);
            this.optSelectCountry.Name = "optSelectCountry";
            this.optSelectCountry.Size = new System.Drawing.Size(84, 17);
            this.optSelectCountry.TabIndex = 7;
            this.optSelectCountry.TabStop = true;
            this.optSelectCountry.Tag = "2";
            this.optSelectCountry.Text = "By country...";
            this.optSelectCountry.UseVisualStyleBackColor = true;
            this.optSelectCountry.CheckedChanged += new System.EventHandler(this.SelectSurveyBy);
            // 
            // optSelectSurvey
            // 
            this.optSelectSurvey.AutoSize = true;
            this.optSelectSurvey.Location = new System.Drawing.Point(21, 9);
            this.optSelectSurvey.Name = "optSelectSurvey";
            this.optSelectSurvey.Size = new System.Drawing.Size(80, 17);
            this.optSelectSurvey.TabIndex = 6;
            this.optSelectSurvey.TabStop = true;
            this.optSelectSurvey.Tag = "1";
            this.optSelectSurvey.Text = "By survey...";
            this.optSelectSurvey.UseVisualStyleBackColor = true;
            this.optSelectSurvey.CheckedChanged += new System.EventHandler(this.SelectSurveyBy);
            // 
            // cmdRemoveSurvey
            // 
            this.cmdRemoveSurvey.Location = new System.Drawing.Point(293, 34);
            this.cmdRemoveSurvey.Name = "cmdRemoveSurvey";
            this.cmdRemoveSurvey.Size = new System.Drawing.Size(28, 22);
            this.cmdRemoveSurvey.TabIndex = 2;
            this.cmdRemoveSurvey.Text = "<";
            this.cmdRemoveSurvey.UseVisualStyleBackColor = true;
            this.cmdRemoveSurvey.Click += new System.EventHandler(this.cmdRemoveSurvey_Click);
            // 
            // lstSelectedSurveys
            // 
            this.lstSelectedSurveys.FormattingEnabled = true;
            this.lstSelectedSurveys.Location = new System.Drawing.Point(325, 9);
            this.lstSelectedSurveys.Name = "lstSelectedSurveys";
            this.lstSelectedSurveys.Size = new System.Drawing.Size(83, 108);
            this.lstSelectedSurveys.TabIndex = 3;
            // 
            // cboSelectSurvey
            // 
            this.cboSelectSurvey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSelectSurvey.FormattingEnabled = true;
            this.cboSelectSurvey.Location = new System.Drawing.Point(198, 9);
            this.cboSelectSurvey.Name = "cboSelectSurvey";
            this.cboSelectSurvey.Size = new System.Drawing.Size(92, 21);
            this.cboSelectSurvey.TabIndex = 0;
            // 
            // cmdAddSurvey
            // 
            this.cmdAddSurvey.Location = new System.Drawing.Point(293, 9);
            this.cmdAddSurvey.Name = "cmdAddSurvey";
            this.cmdAddSurvey.Size = new System.Drawing.Size(28, 22);
            this.cmdAddSurvey.TabIndex = 1;
            this.cmdAddSurvey.Text = ">";
            this.cmdAddSurvey.UseVisualStyleBackColor = true;
            this.cmdAddSurvey.Click += new System.EventHandler(this.cmdAddSurvey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Specify VarName(s)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Location = new System.Drawing.Point(3, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 115);
            this.panel2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 19);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 18);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(156, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(83, 108);
            this.listBox2.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(8, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // cmdExpandSurveyPanel
            // 
            this.cmdExpandSurveyPanel.Location = new System.Drawing.Point(23, 53);
            this.cmdExpandSurveyPanel.Name = "cmdExpandSurveyPanel";
            this.cmdExpandSurveyPanel.Size = new System.Drawing.Size(23, 20);
            this.cmdExpandSurveyPanel.TabIndex = 5;
            this.cmdExpandSurveyPanel.Text = "^";
            this.cmdExpandSurveyPanel.UseVisualStyleBackColor = true;
            this.cmdExpandSurveyPanel.Click += new System.EventHandler(this.cmdExpandSurveyPanel_Click);
            // 
            // cmdExpandVarNamePanel
            // 
            this.cmdExpandVarNamePanel.Location = new System.Drawing.Point(23, 355);
            this.cmdExpandVarNamePanel.Name = "cmdExpandVarNamePanel";
            this.cmdExpandVarNamePanel.Size = new System.Drawing.Size(23, 20);
            this.cmdExpandVarNamePanel.TabIndex = 6;
            this.cmdExpandVarNamePanel.Text = "^";
            this.cmdExpandVarNamePanel.UseVisualStyleBackColor = true;
            this.cmdExpandVarNamePanel.Click += new System.EventHandler(this.cmdExpandVarNamePanel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Compare Surveys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "List Variables";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(708, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Include Wordings";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(707, 151);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Include Labels";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(732, 176);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(62, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Domain";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(732, 201);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(53, 17);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Topic";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(732, 224);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(63, 17);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "Content";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(732, 247);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(68, 17);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "VarLabel";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "ISIS Reporter";
            // 
            // qrySurveyQuestionsBindingSource
            // 
            this.qrySurveyQuestionsBindingSource.DataMember = "qrySurveyQuestions";
            this.qrySurveyQuestionsBindingSource.DataSource = this._isisDataSet;
            // 
            // _isisDataSet
            // 
            this._isisDataSet.DataSetName = "_isisDataSet";
            this._isisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qrySurveyQuestionsTableAdapter
            // 
            this.qrySurveyQuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ISISReporter._isisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qrySurveyInfoBindingSource1
            // 
            this.qrySurveyInfoBindingSource1.DataMember = "qrySurveyInfo";
            this.qrySurveyInfoBindingSource1.DataSource = this._isisDataSet;
            // 
            // qrySurveyInfoTableAdapter
            // 
            this.qrySurveyInfoTableAdapter.ClearBeforeFill = true;
            // 
            // qryStudyWavesBindingSource1
            // 
            this.qryStudyWavesBindingSource1.DataMember = "qryStudyWaves";
            this.qryStudyWavesBindingSource1.DataSource = this._isisDataSet;
            // 
            // qryStudyWavesTableAdapter
            // 
            this.qryStudyWavesTableAdapter.ClearBeforeFill = true;
            // 
            // qryCountryCodesBindingSource1
            // 
            this.qryCountryCodesBindingSource1.DataMember = "qryCountryCodes";
            this.qryCountryCodesBindingSource1.DataSource = this._isisDataSet;
            // 
            // qryCountryCodesTableAdapter
            // 
            this.qryCountryCodesTableAdapter.ClearBeforeFill = true;
            // 
            // cmdGenerateReport
            // 
            this.cmdGenerateReport.Location = new System.Drawing.Point(1005, 525);
            this.cmdGenerateReport.Name = "cmdGenerateReport";
            this.cmdGenerateReport.Size = new System.Drawing.Size(86, 35);
            this.cmdGenerateReport.TabIndex = 16;
            this.cmdGenerateReport.Text = "Generate Report";
            this.cmdGenerateReport.UseVisualStyleBackColor = true;
            this.cmdGenerateReport.Click += new System.EventHandler(this.cmdGenerateReport_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 758);
            this.Controls.Add(this.cmdGenerateReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdExpandSurveyPanel);
            this.Controls.Add(this.cmdExpandVarNamePanel);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReportForm";
            this.Text = "ISIS Reporter";
            this.Load += new System.EventHandler(this.ISISReporter_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrySurveyQuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._isisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrySurveyInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryStudyWavesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCountryCodesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstSelectedSurveys;
        private System.Windows.Forms.Button cmdRemoveSurvey;
        private System.Windows.Forms.ComboBox cboSelectSurvey;
        private System.Windows.Forms.Button cmdAddSurvey;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button cmdExpandSurveyPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdExpandVarNamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.RadioButton optSelectSurvey;
        private System.Windows.Forms.RadioButton optSelectWave;
        private System.Windows.Forms.ListBox lstCountryWave;
        private System.Windows.Forms.RadioButton optSelectCountry;
        private System.Windows.Forms.Label label5;
  
        private System.Windows.Forms.BindingSource qrySurveyInfoBindingSource;
 
        private System.Windows.Forms.BindingSource qryStudyWavesBindingSource;
        private System.Windows.Forms.BindingSource qryCountryCodesBindingSource;
        private _isisDataSet _isisDataSet;
        private System.Windows.Forms.BindingSource qrySurveyQuestionsBindingSource;
        private _isisDataSetTableAdapters.qrySurveyQuestionsTableAdapter qrySurveyQuestionsTableAdapter;
        private _isisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource qrySurveyInfoBindingSource1;
        private _isisDataSetTableAdapters.qrySurveyInfoTableAdapter qrySurveyInfoTableAdapter;
        private System.Windows.Forms.BindingSource qryStudyWavesBindingSource1;
        private _isisDataSetTableAdapters.qryStudyWavesTableAdapter qryStudyWavesTableAdapter;
        private System.Windows.Forms.BindingSource qryCountryCodesBindingSource1;
        private _isisDataSetTableAdapters.qryCountryCodesTableAdapter qryCountryCodesTableAdapter;
        private System.Windows.Forms.Button cmdGenerateReport;
    }
}

