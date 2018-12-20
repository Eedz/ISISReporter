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
    public partial class WordingOptionsForm : Form
    {
        public ReportSurvey CurrentSurvey { get; set; }

        public WordingOptionsForm()
        {
            InitializeComponent();
        }

        public WordingOptionsForm(ReportSurvey s)
        {
            CurrentSurvey = s;
            InitializeComponent();
        }

        private void WordingOptionsForm_Load(object sender, EventArgs e)
        {
            // set the title text
            lblTitle.Text = UpdateTitle();

            // bind properties
            dateBackup.DataBindings.Add(new Binding("Value", CurrentSurvey, "Backend", true));

            // select standard fields
            foreach (string fieldname in CurrentSurvey.StdFieldsChosen.ToList())
            {
                for(int i = 0; i <lstStandardFields.Items.Count; i++)
                {
                    if (lstStandardFields.Items[i].Equals(fieldname))
                    {
                        lstStandardFields.SelectedIndices.Add(i);
                        break;
                    }
                }
            }

            // select repeated fields
            foreach (string fieldname in CurrentSurvey.RepeatedFields.ToList())
            {
                for (int i = 0; i < lstRepeatedFields.Items.Count; i++)
                {
                    if (lstRepeatedFields.Items[i].Equals(fieldname))
                    {
                        lstRepeatedFields.SelectedIndices.Add(i);
                        break;
                    }
                }
            }


        }

        private string UpdateTitle()
        {
            if (CurrentSurvey.Backend.ToString("dd-MMM-yyyy") == DateTime.Today.ToString("dd-MMM-yyyy"))
            {
                return "Wording options for " + CurrentSurvey.SurveyCode;
            }
            else
            {
                return "Wording options for " + CurrentSurvey.SurveyCode + " from " + CurrentSurvey.Backend.ToString("dd-MMM-yyyy");
            }
        }

        private void lstStandardFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentSurvey.StdFieldsChosen.Clear();
            for (int i = 0; i < lstStandardFields.SelectedIndices.Count; i++)
            {
                var item = lstStandardFields.SelectedIndices[i];  // get the selected index
                var label = (string)lstStandardFields.Items[item]; // get the item at the selected index
                CurrentSurvey.StdFieldsChosen.Add(label); // add the actual text to the list of comment types
            }
        }

        private void lstRepeatedFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentSurvey.RepeatedFields.Clear();
            for (int i = 0; i < lstRepeatedFields.SelectedIndices.Count; i++)
            {
                var item = lstRepeatedFields.SelectedIndices[i];  // get the selected index
                var label = (string)lstRepeatedFields.Items[item]; // get the item at the selected index
                CurrentSurvey.RepeatedFields.Add(label); // add the actual text to the list of comment types
            }
        }
    }
}
