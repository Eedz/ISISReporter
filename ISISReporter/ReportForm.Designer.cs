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
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelectSurveyInner = new System.Windows.Forms.Panel();
            this.lstSelectedSurveys = new System.Windows.Forms.ListBox();
            this.optSelectWave = new System.Windows.Forms.RadioButton();
            this.lstCountryWave = new System.Windows.Forms.ListBox();
            this.optSelectCountry = new System.Windows.Forms.RadioButton();
            this.optSelectSurvey = new System.Windows.Forms.RadioButton();
            this.cmdRemoveSurvey = new System.Windows.Forms.Button();
            this.cboSelectSurvey = new System.Windows.Forms.ComboBox();
            this.cmdAddSurvey = new System.Windows.Forms.Button();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.lstPrefixes = new System.Windows.Forms.ListBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.cmdRemoveVar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAddVar = new System.Windows.Forms.Button();
            this.lstSelectedVarNames = new System.Windows.Forms.ListBox();
            this.cboSelectVarName = new System.Windows.Forms.ComboBox();
            this.cmdExpandSurveyPanel = new System.Windows.Forms.Button();
            this.cmdExpandVarNamePanel = new System.Windows.Forms.Button();
            this.lblSurveyBasedReports = new System.Windows.Forms.Label();
            this.lblVarNameBasedReports = new System.Windows.Forms.Label();
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
            this.cmdWordingOptions = new System.Windows.Forms.Button();
            this.optSurveyOverview = new System.Windows.Forms.RadioButton();
            this.optSurveySections = new System.Windows.Forms.RadioButton();
            this.optSurveySyntax = new System.Windows.Forms.RadioButton();
            this.optSurveyByVarName = new System.Windows.Forms.RadioButton();
            this.optSurveyByLabel = new System.Windows.Forms.RadioButton();
            this.optOrderCompare = new System.Windows.Forms.RadioButton();
            this.cmdLabelOptions = new System.Windows.Forms.Button();
            this.cmdCommentOptions = new System.Windows.Forms.Button();
            this.cmdTranslationOptions = new System.Windows.Forms.Button();
            this.optHarmony = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.optProductCrosstab = new System.Windows.Forms.RadioButton();
            this.lblLabelBasedReports = new System.Windows.Forms.Label();
            this.optVarList = new System.Windows.Forms.RadioButton();
            this.panelSelectSurveyOuter = new System.Windows.Forms.Panel();
            this.panelSelectVarNameInner = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelSelectVarNameOuter = new System.Windows.Forms.Panel();
            this.lblReportOptions = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSelectSurveyInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrySurveyQuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._isisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrySurveyInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryStudyWavesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCountryCodesBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSelectSurveyOuter.SuspendLayout();
            this.panelSelectVarNameInner.SuspendLayout();
            this.panelSelectVarNameOuter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Specify Survey(s)";
            // 
            // panelSelectSurveyInner
            // 
            this.panelSelectSurveyInner.Controls.Add(this.lstSelectedSurveys);
            this.panelSelectSurveyInner.Controls.Add(this.optSelectWave);
            this.panelSelectSurveyInner.Controls.Add(this.lstCountryWave);
            this.panelSelectSurveyInner.Controls.Add(this.optSelectCountry);
            this.panelSelectSurveyInner.Controls.Add(this.optSelectSurvey);
            this.panelSelectSurveyInner.Controls.Add(this.cmdRemoveSurvey);
            this.panelSelectSurveyInner.Controls.Add(this.cboSelectSurvey);
            this.panelSelectSurveyInner.Controls.Add(this.cmdAddSurvey);
            this.panelSelectSurveyInner.Location = new System.Drawing.Point(3, 40);
            this.panelSelectSurveyInner.Name = "panelSelectSurveyInner";
            this.panelSelectSurveyInner.Size = new System.Drawing.Size(423, 201);
            this.panelSelectSurveyInner.TabIndex = 4;
            // 
            // lstSelectedSurveys
            // 
            this.lstSelectedSurveys.FormattingEnabled = true;
            this.lstSelectedSurveys.Location = new System.Drawing.Point(325, 9);
            this.lstSelectedSurveys.Name = "lstSelectedSurveys";
            this.lstSelectedSurveys.Size = new System.Drawing.Size(83, 121);
            this.lstSelectedSurveys.TabIndex = 10;
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
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Enabled = false;
            this.radioButton10.Location = new System.Drawing.Point(18, 60);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(68, 17);
            this.radioButton10.TabIndex = 13;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "By Qnum";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // lstPrefixes
            // 
            this.lstPrefixes.FormattingEnabled = true;
            this.lstPrefixes.Location = new System.Drawing.Point(112, 41);
            this.lstPrefixes.Name = "lstPrefixes";
            this.lstPrefixes.Size = new System.Drawing.Size(72, 134);
            this.lstPrefixes.TabIndex = 12;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(18, 37);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(66, 17);
            this.radioButton9.TabIndex = 11;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "By Prefix";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(18, 14);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(84, 17);
            this.radioButton8.TabIndex = 10;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "By VarName";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // cmdRemoveVar
            // 
            this.cmdRemoveVar.Location = new System.Drawing.Point(290, 41);
            this.cmdRemoveVar.Name = "cmdRemoveVar";
            this.cmdRemoveVar.Size = new System.Drawing.Size(28, 20);
            this.cmdRemoveVar.TabIndex = 6;
            this.cmdRemoveVar.Text = "<";
            this.cmdRemoveVar.UseVisualStyleBackColor = true;
            this.cmdRemoveVar.Click += new System.EventHandler(this.cmdRemoveVar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Specify VarName(s)";
            // 
            // cmdAddVar
            // 
            this.cmdAddVar.Location = new System.Drawing.Point(290, 13);
            this.cmdAddVar.Name = "cmdAddVar";
            this.cmdAddVar.Size = new System.Drawing.Size(28, 21);
            this.cmdAddVar.TabIndex = 5;
            this.cmdAddVar.Text = ">";
            this.cmdAddVar.UseVisualStyleBackColor = true;
            this.cmdAddVar.Click += new System.EventHandler(this.cmdAddVar_Click);
            // 
            // lstSelectedVarNames
            // 
            this.lstSelectedVarNames.FormattingEnabled = true;
            this.lstSelectedVarNames.Location = new System.Drawing.Point(322, 14);
            this.lstSelectedVarNames.Name = "lstSelectedVarNames";
            this.lstSelectedVarNames.Size = new System.Drawing.Size(83, 108);
            this.lstSelectedVarNames.TabIndex = 7;
            // 
            // cboSelectVarName
            // 
            this.cboSelectVarName.FormattingEnabled = true;
            this.cboSelectVarName.Location = new System.Drawing.Point(195, 13);
            this.cboSelectVarName.Name = "cboSelectVarName";
            this.cboSelectVarName.Size = new System.Drawing.Size(92, 21);
            this.cboSelectVarName.TabIndex = 4;
            // 
            // cmdExpandSurveyPanel
            // 
            this.cmdExpandSurveyPanel.Location = new System.Drawing.Point(6, 3);
            this.cmdExpandSurveyPanel.Name = "cmdExpandSurveyPanel";
            this.cmdExpandSurveyPanel.Size = new System.Drawing.Size(23, 20);
            this.cmdExpandSurveyPanel.TabIndex = 5;
            this.cmdExpandSurveyPanel.Text = "^";
            this.cmdExpandSurveyPanel.UseVisualStyleBackColor = true;
            this.cmdExpandSurveyPanel.Click += new System.EventHandler(this.cmdExpandSurveyPanel_Click);
            // 
            // cmdExpandVarNamePanel
            // 
            this.cmdExpandVarNamePanel.Location = new System.Drawing.Point(6, 5);
            this.cmdExpandVarNamePanel.Name = "cmdExpandVarNamePanel";
            this.cmdExpandVarNamePanel.Size = new System.Drawing.Size(23, 20);
            this.cmdExpandVarNamePanel.TabIndex = 6;
            this.cmdExpandVarNamePanel.Text = "^";
            this.cmdExpandVarNamePanel.UseVisualStyleBackColor = true;
            this.cmdExpandVarNamePanel.Click += new System.EventHandler(this.cmdExpandVarNamePanel_Click);
            // 
            // lblSurveyBasedReports
            // 
            this.lblSurveyBasedReports.AutoSize = true;
            this.lblSurveyBasedReports.Location = new System.Drawing.Point(8, 14);
            this.lblSurveyBasedReports.Name = "lblSurveyBasedReports";
            this.lblSurveyBasedReports.Size = new System.Drawing.Size(55, 13);
            this.lblSurveyBasedReports.TabIndex = 7;
            this.lblSurveyBasedReports.Text = "By Survey";
            // 
            // lblVarNameBasedReports
            // 
            this.lblVarNameBasedReports.AutoSize = true;
            this.lblVarNameBasedReports.Location = new System.Drawing.Point(8, 179);
            this.lblVarNameBasedReports.Name = "lblVarNameBasedReports";
            this.lblVarNameBasedReports.Size = new System.Drawing.Size(60, 13);
            this.lblVarNameBasedReports.TabIndex = 8;
            this.lblVarNameBasedReports.Text = "By Variable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 9);
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
            this.cmdGenerateReport.Location = new System.Drawing.Point(900, 309);
            this.cmdGenerateReport.Name = "cmdGenerateReport";
            this.cmdGenerateReport.Size = new System.Drawing.Size(86, 35);
            this.cmdGenerateReport.TabIndex = 16;
            this.cmdGenerateReport.Text = "Generate Report";
            this.cmdGenerateReport.UseVisualStyleBackColor = true;
            this.cmdGenerateReport.Click += new System.EventHandler(this.cmdGenerateReport_Click);
            // 
            // cmdWordingOptions
            // 
            this.cmdWordingOptions.Location = new System.Drawing.Point(682, 86);
            this.cmdWordingOptions.Name = "cmdWordingOptions";
            this.cmdWordingOptions.Size = new System.Drawing.Size(113, 23);
            this.cmdWordingOptions.TabIndex = 18;
            this.cmdWordingOptions.Text = "Wording Options";
            this.cmdWordingOptions.UseVisualStyleBackColor = true;
            this.cmdWordingOptions.Visible = false;
            this.cmdWordingOptions.Click += new System.EventHandler(this.OpenWordingOptionsForm);
            // 
            // optSurveyOverview
            // 
            this.optSurveyOverview.AutoSize = true;
            this.optSurveyOverview.Location = new System.Drawing.Point(11, 96);
            this.optSurveyOverview.Name = "optSurveyOverview";
            this.optSurveyOverview.Size = new System.Drawing.Size(106, 17);
            this.optSurveyOverview.TabIndex = 19;
            this.optSurveyOverview.TabStop = true;
            this.optSurveyOverview.Tag = "4";
            this.optSurveyOverview.Text = "Survey Overview";
            this.optSurveyOverview.UseVisualStyleBackColor = true;
            this.optSurveyOverview.CheckedChanged += new System.EventHandler(this.SurveyReportTypeChange);
            // 
            // optSurveySections
            // 
            this.optSurveySections.AutoSize = true;
            this.optSurveySections.Location = new System.Drawing.Point(11, 119);
            this.optSurveySections.Name = "optSurveySections";
            this.optSurveySections.Size = new System.Drawing.Size(66, 17);
            this.optSurveySections.TabIndex = 20;
            this.optSurveySections.TabStop = true;
            this.optSurveySections.Tag = "5";
            this.optSurveySections.Text = "Sections";
            this.optSurveySections.UseVisualStyleBackColor = true;
            this.optSurveySections.CheckedChanged += new System.EventHandler(this.SurveyReportTypeChange);
            // 
            // optSurveySyntax
            // 
            this.optSurveySyntax.AutoSize = true;
            this.optSurveySyntax.Location = new System.Drawing.Point(11, 142);
            this.optSurveySyntax.Name = "optSurveySyntax";
            this.optSurveySyntax.Size = new System.Drawing.Size(57, 17);
            this.optSurveySyntax.TabIndex = 21;
            this.optSurveySyntax.TabStop = true;
            this.optSurveySyntax.Tag = "6";
            this.optSurveySyntax.Text = "Syntax";
            this.optSurveySyntax.UseVisualStyleBackColor = true;
            this.optSurveySyntax.CheckedChanged += new System.EventHandler(this.SurveyReportTypeChange);
            // 
            // optSurveyByVarName
            // 
            this.optSurveyByVarName.AutoSize = true;
            this.optSurveyByVarName.Location = new System.Drawing.Point(11, 30);
            this.optSurveyByVarName.Name = "optSurveyByVarName";
            this.optSurveyByVarName.Size = new System.Drawing.Size(154, 17);
            this.optSurveyByVarName.TabIndex = 23;
            this.optSurveyByVarName.TabStop = true;
            this.optSurveyByVarName.Tag = "1";
            this.optSurveyByVarName.Text = "Survey Report by VarName";
            this.optSurveyByVarName.UseVisualStyleBackColor = true;
            this.optSurveyByVarName.CheckedChanged += new System.EventHandler(this.SurveyReportTypeChange);
            // 
            // optSurveyByLabel
            // 
            this.optSurveyByLabel.AutoSize = true;
            this.optSurveyByLabel.Location = new System.Drawing.Point(11, 52);
            this.optSurveyByLabel.Name = "optSurveyByLabel";
            this.optSurveyByLabel.Size = new System.Drawing.Size(136, 17);
            this.optSurveyByLabel.TabIndex = 24;
            this.optSurveyByLabel.TabStop = true;
            this.optSurveyByLabel.Tag = "2";
            this.optSurveyByLabel.Text = "Survey Report by Label";
            this.optSurveyByLabel.UseVisualStyleBackColor = true;
            this.optSurveyByLabel.CheckedChanged += new System.EventHandler(this.SurveyReportTypeChange);
            // 
            // optOrderCompare
            // 
            this.optOrderCompare.AutoSize = true;
            this.optOrderCompare.Location = new System.Drawing.Point(11, 75);
            this.optOrderCompare.Name = "optOrderCompare";
            this.optOrderCompare.Size = new System.Drawing.Size(184, 17);
            this.optOrderCompare.TabIndex = 25;
            this.optOrderCompare.TabStop = true;
            this.optOrderCompare.Tag = "3";
            this.optOrderCompare.Text = "Order Comparison (req. 2 surveys)";
            this.optOrderCompare.UseVisualStyleBackColor = true;
            this.optOrderCompare.CheckedChanged += new System.EventHandler(this.SurveyReportTypeChange);
            // 
            // cmdLabelOptions
            // 
            this.cmdLabelOptions.Location = new System.Drawing.Point(682, 147);
            this.cmdLabelOptions.Name = "cmdLabelOptions";
            this.cmdLabelOptions.Size = new System.Drawing.Size(113, 26);
            this.cmdLabelOptions.TabIndex = 26;
            this.cmdLabelOptions.Text = "Label Options";
            this.cmdLabelOptions.UseVisualStyleBackColor = true;
            this.cmdLabelOptions.Visible = false;
            this.cmdLabelOptions.Click += new System.EventHandler(this.OpenLabelOptionsForm);
            // 
            // cmdCommentOptions
            // 
            this.cmdCommentOptions.Location = new System.Drawing.Point(682, 212);
            this.cmdCommentOptions.Name = "cmdCommentOptions";
            this.cmdCommentOptions.Size = new System.Drawing.Size(113, 24);
            this.cmdCommentOptions.TabIndex = 27;
            this.cmdCommentOptions.Text = "Comment Options";
            this.cmdCommentOptions.UseVisualStyleBackColor = true;
            this.cmdCommentOptions.Visible = false;
            this.cmdCommentOptions.Click += new System.EventHandler(this.OpenCommentOptionsForm);
            // 
            // cmdTranslationOptions
            // 
            this.cmdTranslationOptions.Location = new System.Drawing.Point(682, 268);
            this.cmdTranslationOptions.Name = "cmdTranslationOptions";
            this.cmdTranslationOptions.Size = new System.Drawing.Size(113, 23);
            this.cmdTranslationOptions.TabIndex = 28;
            this.cmdTranslationOptions.Text = "Translation Options";
            this.cmdTranslationOptions.UseVisualStyleBackColor = true;
            this.cmdTranslationOptions.Visible = false;
            this.cmdTranslationOptions.Click += new System.EventHandler(this.OpenTranslationFormOptions);
            // 
            // optHarmony
            // 
            this.optHarmony.AutoSize = true;
            this.optHarmony.Location = new System.Drawing.Point(11, 195);
            this.optHarmony.Name = "optHarmony";
            this.optHarmony.Size = new System.Drawing.Size(67, 17);
            this.optHarmony.TabIndex = 29;
            this.optHarmony.TabStop = true;
            this.optHarmony.Tag = "7";
            this.optHarmony.Text = "Harmony";
            this.optHarmony.UseVisualStyleBackColor = true;
            this.optHarmony.CheckedChanged += new System.EventHandler(this.SurveyReportTypeChange);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.optProductCrosstab);
            this.panel2.Controls.Add(this.lblLabelBasedReports);
            this.panel2.Controls.Add(this.optVarList);
            this.panel2.Controls.Add(this.optOrderCompare);
            this.panel2.Controls.Add(this.optHarmony);
            this.panel2.Controls.Add(this.optSurveyByLabel);
            this.panel2.Controls.Add(this.lblVarNameBasedReports);
            this.panel2.Controls.Add(this.optSurveyByVarName);
            this.panel2.Controls.Add(this.optSurveySyntax);
            this.panel2.Controls.Add(this.optSurveySections);
            this.panel2.Controls.Add(this.optSurveyOverview);
            this.panel2.Controls.Add(this.lblSurveyBasedReports);
            this.panel2.Location = new System.Drawing.Point(17, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 296);
            this.panel2.TabIndex = 30;
            // 
            // optProductCrosstab
            // 
            this.optProductCrosstab.AutoSize = true;
            this.optProductCrosstab.Location = new System.Drawing.Point(11, 267);
            this.optProductCrosstab.Name = "optProductCrosstab";
            this.optProductCrosstab.Size = new System.Drawing.Size(106, 17);
            this.optProductCrosstab.TabIndex = 32;
            this.optProductCrosstab.TabStop = true;
            this.optProductCrosstab.Tag = "9";
            this.optProductCrosstab.Text = "Product Crosstab";
            this.optProductCrosstab.UseVisualStyleBackColor = true;
            // 
            // lblLabelBasedReports
            // 
            this.lblLabelBasedReports.AutoSize = true;
            this.lblLabelBasedReports.Location = new System.Drawing.Point(8, 251);
            this.lblLabelBasedReports.Name = "lblLabelBasedReports";
            this.lblLabelBasedReports.Size = new System.Drawing.Size(48, 13);
            this.lblLabelBasedReports.TabIndex = 31;
            this.lblLabelBasedReports.Text = "By Label";
            // 
            // optVarList
            // 
            this.optVarList.AutoSize = true;
            this.optVarList.Location = new System.Drawing.Point(11, 218);
            this.optVarList.Name = "optVarList";
            this.optVarList.Size = new System.Drawing.Size(82, 17);
            this.optVarList.TabIndex = 30;
            this.optVarList.TabStop = true;
            this.optVarList.Tag = "8";
            this.optVarList.Text = "Variable List";
            this.optVarList.UseVisualStyleBackColor = true;
            this.optVarList.CheckedChanged += new System.EventHandler(this.SurveyReportTypeChange);
            // 
            // panelSelectSurveyOuter
            // 
            this.panelSelectSurveyOuter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSelectSurveyOuter.Controls.Add(this.label1);
            this.panelSelectSurveyOuter.Controls.Add(this.panelSelectSurveyInner);
            this.panelSelectSurveyOuter.Controls.Add(this.cmdExpandSurveyPanel);
            this.panelSelectSurveyOuter.Location = new System.Drawing.Point(230, 56);
            this.panelSelectSurveyOuter.Name = "panelSelectSurveyOuter";
            this.panelSelectSurveyOuter.Size = new System.Drawing.Size(430, 245);
            this.panelSelectSurveyOuter.TabIndex = 32;
            // 
            // panelSelectVarNameInner
            // 
            this.panelSelectVarNameInner.Controls.Add(this.checkBox1);
            this.panelSelectVarNameInner.Controls.Add(this.radioButton10);
            this.panelSelectVarNameInner.Controls.Add(this.cboSelectVarName);
            this.panelSelectVarNameInner.Controls.Add(this.lstSelectedVarNames);
            this.panelSelectVarNameInner.Controls.Add(this.lstPrefixes);
            this.panelSelectVarNameInner.Controls.Add(this.radioButton9);
            this.panelSelectVarNameInner.Controls.Add(this.cmdAddVar);
            this.panelSelectVarNameInner.Controls.Add(this.cmdRemoveVar);
            this.panelSelectVarNameInner.Controls.Add(this.radioButton8);
            this.panelSelectVarNameInner.Location = new System.Drawing.Point(6, 37);
            this.panelSelectVarNameInner.Name = "panelSelectVarNameInner";
            this.panelSelectVarNameInner.Size = new System.Drawing.Size(420, 199);
            this.panelSelectVarNameInner.TabIndex = 33;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(195, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Include unused VarNames";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelSelectVarNameOuter
            // 
            this.panelSelectVarNameOuter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSelectVarNameOuter.Controls.Add(this.label2);
            this.panelSelectVarNameOuter.Controls.Add(this.panelSelectVarNameInner);
            this.panelSelectVarNameOuter.Controls.Add(this.cmdExpandVarNamePanel);
            this.panelSelectVarNameOuter.Location = new System.Drawing.Point(230, 306);
            this.panelSelectVarNameOuter.Name = "panelSelectVarNameOuter";
            this.panelSelectVarNameOuter.Size = new System.Drawing.Size(430, 245);
            this.panelSelectVarNameOuter.TabIndex = 34;
            // 
            // lblReportOptions
            // 
            this.lblReportOptions.AutoSize = true;
            this.lblReportOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportOptions.Location = new System.Drawing.Point(678, 56);
            this.lblReportOptions.Name = "lblReportOptions";
            this.lblReportOptions.Size = new System.Drawing.Size(117, 20);
            this.lblReportOptions.TabIndex = 35;
            this.lblReportOptions.Text = "Report Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 36;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReportOptions);
            this.Controls.Add(this.panelSelectVarNameOuter);
            this.Controls.Add(this.panelSelectSurveyOuter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdTranslationOptions);
            this.Controls.Add(this.cmdCommentOptions);
            this.Controls.Add(this.cmdLabelOptions);
            this.Controls.Add(this.cmdWordingOptions);
            this.Controls.Add(this.cmdGenerateReport);
            this.Controls.Add(this.label5);
            this.Name = "ReportForm";
            this.Text = "ISIS Reporter";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panelSelectSurveyInner.ResumeLayout(false);
            this.panelSelectSurveyInner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrySurveyQuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._isisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrySurveyInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryStudyWavesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryCountryCodesBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSelectSurveyOuter.ResumeLayout(false);
            this.panelSelectSurveyOuter.PerformLayout();
            this.panelSelectVarNameInner.ResumeLayout(false);
            this.panelSelectVarNameInner.PerformLayout();
            this.panelSelectVarNameOuter.ResumeLayout(false);
            this.panelSelectVarNameOuter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdRemoveSurvey;
        private System.Windows.Forms.ComboBox cboSelectSurvey;
        private System.Windows.Forms.Button cmdAddSurvey;
        private System.Windows.Forms.ListBox lstSelectedVarNames;
        private System.Windows.Forms.Button cmdRemoveVar;
        private System.Windows.Forms.Button cmdAddVar;
        private System.Windows.Forms.ComboBox cboSelectVarName;
        private System.Windows.Forms.Button cmdExpandSurveyPanel;
        private System.Windows.Forms.Panel panelSelectSurveyInner;
        private System.Windows.Forms.Button cmdExpandVarNamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSurveyBasedReports;
        private System.Windows.Forms.Label lblVarNameBasedReports;
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
        private System.Windows.Forms.Button cmdWordingOptions;
        private System.Windows.Forms.RadioButton optSurveyOverview;
        private System.Windows.Forms.RadioButton optSurveySections;
        private System.Windows.Forms.RadioButton optSurveySyntax;
        private System.Windows.Forms.RadioButton optSurveyByVarName;
        private System.Windows.Forms.RadioButton optSurveyByLabel;
        private System.Windows.Forms.RadioButton optOrderCompare;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.ListBox lstPrefixes;
        private System.Windows.Forms.Button cmdLabelOptions;
        private System.Windows.Forms.Button cmdCommentOptions;
        private System.Windows.Forms.Button cmdTranslationOptions;
        private System.Windows.Forms.RadioButton optHarmony;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton optVarList;
        private System.Windows.Forms.ListBox lstSelectedSurveys;
        private System.Windows.Forms.Panel panelSelectSurveyOuter;
        private System.Windows.Forms.Panel panelSelectVarNameInner;
        private System.Windows.Forms.Panel panelSelectVarNameOuter;
        private System.Windows.Forms.RadioButton optProductCrosstab;
        private System.Windows.Forms.Label lblLabelBasedReports;
        private System.Windows.Forms.Label lblReportOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

