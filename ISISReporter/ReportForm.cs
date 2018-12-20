using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITCSurveyReportLib;

namespace ISISReporter
{
    public partial class ReportForm : Form
    {

        // NEW IDEA: 
        // class - ITCReport
        //      class - SurveyBasedReport
        //          class - VarName compared report (VarNameReport to be renamed) - started
                       // - contains overview and sections
        //          class - TopicContentReport (T/C label comparison) - done - to test
        //          class - order report - todo create
            //      class - SurveySyntaxReport - started epi
            // class - VarNameBasedReport
            //      class - HarmonyReport - started
            //      class - VariableListReport - todo create
            // class - LabelBasedReport
            //      class - ProductLabelReport (Product Crosstab) - todo create
        

        

        // form has properties for 
        //BindingList<ReportSurvey> for surveys
        //BindingList<VariableName> for varnames

        // user starts by picking type of report
        // create report object
        // appropriate option buttons appear

        
        public BindingList<ReportSurvey> Surveys { get; set; }
        public BindingList<VariableName> VarNames;



        ReportPreset preset;

        bool surveySelectionCollapsed;
        int surveySelectionTop = 50;
        int surveySelectionLeft = 50;
        int surveySelectionHeight = 245;
        int surveySelectionHeaderHeight = 40;

        bool varnameSelectionCollapsed;
        int varnameSelectionTop = 300;
        int varnameSelectionLeft = 50;
        int varnameSelectionHeight = 245;

        public ReportForm()
        {
            InitializeComponent();

            Surveys = new BindingList<ReportSurvey>();
            VarNames = new BindingList<VariableName>();

            // bind selected surveys to the form's list of surveys
            lstSelectedSurveys.DataSource = Surveys;
            lstSelectedSurveys.DisplayMember = "SurveyCode";
            lstSelectedSurveys.ValueMember = "SID";

            // bind selected varnames to the form's list of varnames
            lstSelectedVarNames.DataSource = VarNames;
            lstSelectedVarNames.DisplayMember = "VarName";
            lstSelectedVarNames.ValueMember = "VarName";

            // set defaults
            optSelectSurvey.Checked = true;
            cboSelectSurvey.SelectedItem = null;
        }

        /// <summary>
        /// Create a report object depending on selections made in the form, set it's surveys/varnames, then execute the report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdGenerateReport_Click(object sender, EventArgs e)
        {
            
            // TODO fill surveys, then assign the list to the report object
            switch (preset)
            {
                case ReportPreset.Harmony:
                    HarmonyReport HR = new HarmonyReport();
                    HR.matchFields = new List<string> { "PreA", "LitQ", "RespOptions", "Topic" };
                    foreach (VariableName v in VarNames)
                    {
                        HR.questions.AddRange(DBAction.GetQuestionsByRefVarName(v.refVarName));
                    }

                    HR.VarNames = VarNames;
                    HR.CreateHarmonyReport();
                    break;
                case ReportPreset.VarList:
                    VarNameBasedReport VL = new VarNameBasedReport();
                    break;
                case ReportPreset.SurveyList:
                    VarNameReport SR = new VarNameReport();
                    Surveys[0].Qnum = true;

                    
                    SR.Surveys = Surveys;
                    
                    if (SR.GenerateReport()==1)
                       MessageBox.Show("One or more surveys has no records!");
                    break;
                case ReportPreset.Overview:
                    
                    VarNameReport SO = new VarNameReport();
                    Surveys[0].Qnum = true;
                    
                    foreach (ReportSurvey rs in Surveys)
                    {
                        rs.VarLabelCol = true;
                        rs.TopicLabelCol = true;
                        rs.ContentLabelCol = true;
                    }
                    SO.ShowAllQnums = true;
                    SO.ShowAllVarNames = true;
                    SO.ShowQuestion = false;
                    
                    SO.Surveys = Surveys;
                    

                    
                    SO.GenerateReport();
                    break;
                case ReportPreset.Sections:
                    VarNameReport SS = new VarNameReport();
                    Surveys[0].Qnum = true;

                    foreach(ReportSurvey rs in Surveys)
                    {
                        var headingVars = rs.questions.FindAll(x => x.VarName.StartsWith("Z"));
                        foreach (SurveyQuestion sq in headingVars)
                            rs.Varnames.Add(sq.VarName);
                        
                    }
                    SS.Surveys = Surveys;
                    SS.ShowAllQnums = true;
                    SS.ShowAllVarNames = true;
                    SS.ShowSectionBounds = true;
                    SS.GenerateReport();

                    break;
                case ReportPreset.Syntax:
                    SyntaxReport SY = new SyntaxReport();
                    SY.OutputPath = @"D:\users\Dev";
                    foreach (ReportSurvey s in Surveys) {
                        SY.CreateSyntax(s, SyntaxFormat.EpiData);
                    }
                    
                    break;
                case ReportPreset.TopicContent:
                    TopicContentReport TCR = new TopicContentReport();
                    TCR.Surveys = Surveys;
                    TCR.GenerateLabelReport();
                    break;
                case ReportPreset.OrderCompare:
                    return;

                case ReportPreset.ProductCrosstab:
                    LabelBasedReport LR = new LabelBasedReport();
                    break;
                default:
                    MessageBox.Show("Please select a report type.");
                    return;

            }

        }

        #region Left Side of Form

        private void cmdAddSurvey_Click(object sender, EventArgs e)
        {
            Surveys.Add(new ReportSurvey(DBAction.GetSurvey(cboSelectSurvey.GetItemText(cboSelectSurvey.SelectedItem))));
            

        }

        private void cmdRemoveSurvey_Click(object sender, EventArgs e)
        {
            Surveys.Remove((ReportSurvey)lstSelectedSurveys.SelectedItem);
        }

        private void LoadSurveys()
        {
            // Load data in qrySurveyInfo
            qrySurveyInfoTableAdapter.ClearBeforeFill = true;
            qrySurveyInfoTableAdapter.Fill(this._isisDataSet.qrySurveyInfo);
        }

        private void LoadCountries()
        {
            // Load data in qryCountryCodes
            qryCountryCodesTableAdapter.Fill(this._isisDataSet.qryCountryCodes);
        }

        private void LoadWaves()
        {
            // Load data in qryStudyWaves
            qryStudyWavesTableAdapter.Fill(this._isisDataSet.qryStudyWaves);
        }

        private void cmdExpandSurveyPanel_Click(object sender, EventArgs e)
        {

            surveySelectionCollapsed = !surveySelectionCollapsed;

            if (surveySelectionCollapsed)
            {
                panelSelectSurveyInner.Height = 0;
                panelSelectSurveyOuter.Height = surveySelectionHeaderHeight;
                cmdExpandSurveyPanel.Text = "v";
                panelSelectVarNameOuter.Top = surveySelectionTop + surveySelectionHeaderHeight; 
            }
            else
            {
                panelSelectSurveyInner.Height = surveySelectionHeight - surveySelectionHeaderHeight;
                panelSelectSurveyOuter.Height = surveySelectionHeight;
                cmdExpandSurveyPanel.Text = "^";
                panelSelectVarNameOuter.Top = varnameSelectionTop;
            }
        }

        private void cmdExpandVarNamePanel_Click(object sender, EventArgs e)
        {
            varnameSelectionCollapsed = !varnameSelectionCollapsed;

            if (varnameSelectionCollapsed)
            {
                panelSelectVarNameInner.Height = 0;
                panelSelectVarNameOuter.Height = surveySelectionHeaderHeight;
                cmdExpandVarNamePanel.Text = "v";
                //panelSelectVarNameOuter.Top = surveySelectionTop + surveySelectionHeaderHeight; TODO add label selection
            }
            else
            {
                panelSelectVarNameInner.Height = varnameSelectionHeight - surveySelectionHeaderHeight;
                panelSelectVarNameOuter.Height = varnameSelectionHeight;
                cmdExpandVarNamePanel.Text = "^";
                //panelSelectVarNameOuter.Top = varnameSelectionTop; TODO add label selection
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSurveyBy(object sender, EventArgs e)
        {
            RadioButton option = (RadioButton)sender;

            if (!option.Checked)
                return;

            int selection = Convert.ToInt32(option.Tag);

            switch (selection)
            {
                case 1:
                    if (_isisDataSet.qrySurveyInfo.Count == 0)
                        LoadSurveys();

                    cboSelectSurvey.DataSource = _isisDataSet.qrySurveyInfo;
                    cboSelectSurvey.DisplayMember = "Survey";
                    cboSelectSurvey.ValueMember = "ID";
                    break;
                case 2:
                    if (_isisDataSet.qryCountryCodes.Count == 0)
                        LoadCountries();

                    lstCountryWave.DataSource = _isisDataSet.qryCountryCodes;
                    lstCountryWave.DisplayMember = "ISO_Code";
                    lstCountryWave.ValueMember = "ISO_Code";
                    
                    break;
                case 3:
                    if (_isisDataSet.qryStudyWaves.Count == 0)
                        LoadWaves();

                    lstCountryWave.DataSource = _isisDataSet.qryStudyWaves;
                    lstCountryWave.DisplayMember = "StudyWave";
                    lstCountryWave.ValueMember = "WaveID";
                    break;
            }
            lstCountryWave.ClearSelected();
            lstCountryWave.Visible = !(selection == 1);
        }

        private void lstCountryWave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCountryWave.SelectedItems.Count == 0)
                return;

            if (lstCountryWave.ValueMember.Equals(""))
                return;

            UpdateSurveyList();
        }

        /// <summary>
        /// Updates the Survey combo box by filling the DataTable qrySurveyInfo with records filtered by each selection on the list.
        /// </summary>
        private void UpdateSurveyList()
        {

            // clear data table
            qrySurveyInfoTableAdapter.ClearBeforeFill = true;
            qrySurveyInfoTableAdapter.FillSurveysByCountry(_isisDataSet.qrySurveyInfo, "");

            if (optSelectCountry.Checked)
            {
                foreach (DataRowView r in lstCountryWave.SelectedItems)
                {
                    // fill the table without clearing it first, so that previous filtered results remain
                    qrySurveyInfoTableAdapter.ClearBeforeFill = false;
                    qrySurveyInfoTableAdapter.FillSurveysByCountry(_isisDataSet.qrySurveyInfo, r["ISO_Code"].ToString());
                }
            }
            else if (optSelectWave.Checked)
            {
                foreach (DataRowView r in lstCountryWave.SelectedItems)
                {
                    qrySurveyInfoTableAdapter.ClearBeforeFill = false;
                    qrySurveyInfoTableAdapter.FillSurveysByWave(_isisDataSet.qrySurveyInfo, Convert.ToInt32(r["WaveID"]));
                }
            }
        }

        private void cmdAddVar_Click(object sender, EventArgs e)
        {
            VarNames.Add(DBAction.GetVariable(cboSelectVarName.GetItemText(cboSelectVarName.SelectedItem)));
        }

        private void cmdRemoveVar_Click(object sender, EventArgs e)
        {
            VarNames.Remove((VariableName)lstSelectedSurveys.SelectedItem);
        }

        #endregion

        #region Report Options

        /// <summary>
        /// Set defaults for the type of report that is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurveyReportTypeChange(object sender, EventArgs e)
        {

            RadioButton option = (RadioButton)sender;

            if (!option.Checked)
                return;

            int selection = Convert.ToInt32(option.Tag);

            preset = (ReportPreset)selection;

            switch (preset)
            {
                
                case ReportPreset.Harmony:
                    ShowOptionButtons(false);
                    break;
                case ReportPreset.VarList:
                    ShowOptionButtons(false);
                    break;
                case ReportPreset.SurveyList:
                    ShowOptionButtons(true);
                    break;
                case ReportPreset.Overview:
                    ShowOptionButtons(true);
                    foreach (ReportSurvey s in Surveys)
                    {
                        s.VarLabelCol = true;
                        s.TopicLabelCol = true;
                        s.ContentLabelCol = true;
                        s.DomainLabelCol = true;

                    }
                    
                    break;
                case ReportPreset.Sections:
                    ShowOptionButtons(true);
                    foreach (ReportSurvey s in Surveys)
                    {
                        s.VarLabelCol = false;
                        s.TopicLabelCol = false;
                        s.ContentLabelCol = false;
                        s.DomainLabelCol = false;

                    }
                    break;
                case ReportPreset.Syntax:
                    ShowOptionButtons(false);
                    break;
                case ReportPreset.TopicContent:
                    ShowOptionButtons(true);
                    break;
                case ReportPreset.OrderCompare:
                    ShowOptionButtons(false);
                    return;

                case ReportPreset.ProductCrosstab:
                    ShowOptionButtons(false);
                    break;
                default:
                    MessageBox.Show("Please select a report type.");
                    return;
            }
            
        }

        private void ShowOptionButtons(bool show)
        {
            cmdCommentOptions.Visible = show;
            cmdWordingOptions.Visible = show;
            cmdLabelOptions.Visible = show;
            cmdTranslationOptions.Visible = show;
        }

        /// <summary>
        /// Open a form with various options regarding wordings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenWordingOptionsForm(object sender, EventArgs e)
        {

            if (lstSelectedSurveys.SelectedItem == null)
            {
                MessageBox.Show("Select a Survey to configure wordings.");
                return;
            }

            WordingOptionsForm wf = new WordingOptionsForm((ReportSurvey)lstSelectedSurveys.SelectedItem);
            wf.ShowDialog();
          
        }

        /// <summary>
        /// Open a form with various options regarding comments.
        /// </summary>
        /// <param name="sender">Object triggering this even.</param>
        /// <param name="e"></param>
        private void OpenCommentOptionsForm(object sender, EventArgs e)
        {
            if (lstSelectedSurveys.SelectedItem == null)
            {
                MessageBox.Show("Select a Survey to which to add comments.");
                return;
            }
            CommentOptionsForm cf = new CommentOptionsForm();
            cf.CurrentSurvey = (ReportSurvey)lstSelectedSurveys.SelectedItem;

            cf.ShowDialog();
        }

        /// <summary>
        /// Open a form with various options regarding labels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenLabelOptionsForm(object sender, EventArgs e)
        {
            if (lstSelectedSurveys.SelectedItem == null)
            {
                MessageBox.Show("Select a Survey before adding labels.");
                return;
            }
            LabelOptionsForm lf = new LabelOptionsForm((ReportSurvey)lstSelectedSurveys.SelectedItem);
            

            lf.ShowDialog();
            // include labels
            // which labels
            // combine labels into one field?
        }

        /// <summary>
        /// Open a form with various options regarding translations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenTranslationFormOptions(object sender, EventArgs e)
        {
            if (lstSelectedSurveys.SelectedItem == null)
            {
                MessageBox.Show("Select a Survey before adding translations.");
                return;
            }
            TranslationOptionsForm tf = new TranslationOptionsForm((ReportSurvey)lstSelectedSurveys.SelectedItem);

            tf.ShowDialog();
            // pick languages
            // use english routing
            // include filters/skips, greyed out or eliminated
        }










        #endregion

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
