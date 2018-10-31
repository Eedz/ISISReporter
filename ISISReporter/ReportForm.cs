using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISISReporter
{
    public partial class ReportForm : Form
    {

        ITCSurveyReportLib.SurveyReport SR;

        public ReportForm()
        {
            InitializeComponent();
            
            SR = new ITCSurveyReportLib.SurveyReport();

            // bind selected surveys to the SurveyReport object's list of surveys
            lstSelectedSurveys.DataSource = SR.Surveys;
            lstSelectedSurveys.DisplayMember = "SurveyCode";
            lstSelectedSurveys.ValueMember = "SID";

            // set defaults
            optSelectSurvey.Checked = true;
            cboSelectSurvey.SelectedItem = null;
        }

        private void ISISReporter_Load(object sender, EventArgs e)
        {

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
            
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
            
            
            if (splitContainer1.Panel1Collapsed)
                cmdExpandSurveyPanel.Text = "v";
            else
                cmdExpandSurveyPanel.Text = "^";
        }

        private void cmdExpandVarNamePanel_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;


            if (splitContainer1.Panel2Collapsed)
                cmdExpandVarNamePanel.Text = "v";
            else
                cmdExpandVarNamePanel.Text = "^";
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

       

        private void cmdGenerateReport_Click(object sender, EventArgs e)
        {
            SR.GenerateSurveyReport();
            
        }

        private void cmdAddSurvey_Click(object sender, EventArgs e)
        {            
            SR.AddSurvey(ITCSurveyReportLib.DBAction.GetSurvey(cboSelectSurvey.GetItemText(cboSelectSurvey.SelectedItem)));
        }

        private void cmdRemoveSurvey_Click(object sender, EventArgs e)
        {  
            SR.Surveys.Remove((ITCSurveyReportLib.Survey)lstSelectedSurveys.SelectedItem);
        }

        #region Unused/Abandoned
        private string GetSurveyFilter()
        {

            string list = "";


            if (list.EndsWith("','"))
                list = list.Substring(0, list.Length - 3);

            if (optSelectCountry.Checked)
            {
                foreach (DataRowView r in lstCountryWave.SelectedItems)
                {
                    list += r["ISO_Code"].ToString() + "','";
                }
                if (list.EndsWith("','"))
                    list = list.Substring(0, list.Length - 3);
                list = "ISO_Code IN ('" + list + "')";
            }
            else if (optSelectWave.Checked)
            {
                foreach (DataRowView r in lstCountryWave.SelectedItems)
                {
                    list += r["WaveID"].ToString() + ",";
                }
                if (list.EndsWith(","))
                    list = list.Substring(0, list.Length - 1);
                list = "WaveID IN (" + list + ")";
            }
            return list;
        }
        #endregion
    }
}
