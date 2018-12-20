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
    public partial class TranslationOptionsForm : Form
    {
        public ReportSurvey CurrentSurvey { get; set; }

        public TranslationOptionsForm()
        {
            InitializeComponent();
        }

        public TranslationOptionsForm(ReportSurvey s)
        {
            CurrentSurvey = s;
            InitializeComponent();
        }

        private void TranslationOptionsForm_Load(object sender, EventArgs e)
        {
            // set the title text
            lblTitle.Text = UpdateTitle();

            // bind properties

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
