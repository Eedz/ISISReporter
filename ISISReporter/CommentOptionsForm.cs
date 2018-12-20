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
    public partial class CommentOptionsForm : Form
    {
        public ReportSurvey CurrentSurvey { get; set; }
        
        public CommentOptionsForm()
        {
            InitializeComponent();
        }

        public CommentOptionsForm(ReportSurvey s)
        {
            CurrentSurvey = s;
          
            InitializeComponent();
        }

        private void CommentOptionsForm_Load(object sender, EventArgs e)
        {
            
            this.qryCommentsQuesTypesTableAdapter.FillBySurvey(this._isisDataSet.qryCommentsQuesTypes, CurrentSurvey.SurveyCode);
            this.qryCommentsQuesSourcesTableAdapter.FillBySurvey(this._isisDataSet.qryCommentsQuesSources, CurrentSurvey.SurveyCode);
            this.qryCommentsQuesAuthorsTableAdapter.FillBySurvey(this._isisDataSet.qryCommentsQuesAuthors, CurrentSurvey.SurveyCode);

            // set title of form 
            lblTitle.Text = UpdateTitle();

            // load comment fields
            lstCommentTypes.SelectionMode = SelectionMode.None;
            lstCommentTypes.DataSource = _isisDataSet.qryCommentsQuesTypes;
            lstCommentTypes.DisplayMember = "NoteType";
            lstCommentTypes.ValueMember = "NoteType";
            lstCommentTypes.SelectionMode = SelectionMode.MultiSimple;

            // load comment authors
            lstCommentAuthors.SelectionMode = SelectionMode.None;
            lstCommentAuthors.DataSource = _isisDataSet.qryCommentsQuesAuthors;
            lstCommentAuthors.DisplayMember = "Name";
            lstCommentAuthors.ValueMember = "NoteInit";
            lstCommentAuthors.SelectionMode = SelectionMode.MultiSimple;

            // load comment sources
            lstCommentSources.SelectionMode = SelectionMode.None;
            lstCommentSources.DataSource = _isisDataSet.qryCommentsQuesSources;
            lstCommentSources.DisplayMember = "SourceName";
            lstCommentSources.ValueMember = "SourceName";
            lstCommentSources.SelectionMode = SelectionMode.MultiSimple;

            // bind things to the current survey
            dateTimePicker1.DataBindings.Add(new Binding("Value", CurrentSurvey, "CommentDate", true));
            //lstCommentTypes.DataBindings.Add(new Binding("SelectedItems", CurrentSurvey, "CommentFields"));
            //lstCommentAuthors.DataBindings.Add(new Binding("SelectedItems", CurrentSurvey, "CommentAuthors"));
            //lstCommentSources.DataBindings.Add(new Binding("SelectedItems", CurrentSurvey, "CommentSources"));
        }

        private string UpdateTitle()
        {
            if (CurrentSurvey.Backend.ToString("dd-MMM-yyyy") == DateTime.Today.ToString("dd-MMM-yyyy"))
            {
                return "Add comments to " + CurrentSurvey.SurveyCode;
            }
            else
            {
                return  "Add comments to " + CurrentSurvey.SurveyCode + " from " + CurrentSurvey.Backend.ToString("dd-MMM-yyyy");
            }
        }

        private void lstCommentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstCommentTypes.SelectedIndices.Count; i ++)
            {
                var item = lstCommentTypes.SelectedIndices[i];  // get the selected index
                var label = (DataRowView)lstCommentTypes.Items[item]; // get the item at the selected index
                CurrentSurvey.CommentFields.Add((string)label["NoteType"]); // add the actual text to the list of comment types
            }
        }

        private void lstCommentAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstCommentAuthors.SelectedIndices.Count; i++)
            {
                var item = lstCommentAuthors.SelectedIndices[i];  // get the selected index
                var label = (DataRowView)lstCommentAuthors.Items[item]; // get the item at the selected index
                CurrentSurvey.CommentAuthors.Add((int)label["NoteInit"]); // add the actual number to the list of comment authors
            }
        }

        private void lstCommentSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstCommentSources.SelectedIndices.Count; i++)
            { 
                var item = lstCommentSources.SelectedIndices[i];  // get the selected index
                var label = (DataRowView)lstCommentSources.Items[item]; // get the item at the selected index
                CurrentSurvey.CommentSources.Add((string)label["SourceName"]); // add the actual text to the list of comment source names
            }
        }

        /// <summary>
        /// Upon closing the form, fill the Survey's questions with the selected comments.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommentOptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CurrentSurvey.CommentFields.Count > 0)
                DBAction.FillCommentsBySurvey(CurrentSurvey, CurrentSurvey.CommentFields, CurrentSurvey.CommentDate, CurrentSurvey.CommentAuthors, CurrentSurvey.CommentSources);
        }

        
    }
}
