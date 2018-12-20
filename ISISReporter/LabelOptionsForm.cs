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
    public partial class LabelOptionsForm : Form
    {
        public ReportSurvey CurrentSurvey { get; set; }
        public LabelOptionsForm()
        {
            InitializeComponent();
        }

        public LabelOptionsForm(ReportSurvey s)
        {
            CurrentSurvey = s;
            InitializeComponent();
        }

        private void LabelOptionsForm_Load(object sender, EventArgs e)
        {
            // set title of form 
            lblTitle.Text = UpdateTitle();

            // bind controls to current survey
            chkVarLabel.DataBindings.Add(new Binding("Checked", CurrentSurvey, "VarLabelCol"));
            chkDomainLabel.DataBindings.Add(new Binding("Checked", CurrentSurvey, "DomainLabelCol"));
            chkTopicLabel.DataBindings.Add(new Binding("Checked", CurrentSurvey, "TopicLabelCol"));
            chkContentLabel.DataBindings.Add(new Binding("Checked", CurrentSurvey, "ContentLabelCol"));
            chkProductLabel.DataBindings.Add(new Binding("Checked", CurrentSurvey, "ProductLabelCol"));
            //chkCombineLabels.DataBindings.Add(new Binding("Checked", CurrentSurvey, ""));
        }

        private string UpdateTitle()
        {
            if (CurrentSurvey.Backend.ToString("dd-MMM-yyyy") == DateTime.Today.ToString("dd-MMM-yyyy"))
            {
                return "Add labels to " + CurrentSurvey.SurveyCode;
            }
            else
            {
                return "Add labels to " + CurrentSurvey.SurveyCode + " from " + CurrentSurvey.Backend.ToString("dd-MMM-yyyy");
            }
        }

        
    }
}
