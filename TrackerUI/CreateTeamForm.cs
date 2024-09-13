using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableMembers = GlobalConfig.Connection.GetPersons();
        private List<PersonModel> selectedMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            WiredUpList();
        }

        private void WiredUpList()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void teamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel(firstNameValue.Text, lastNameValue.Text, emailNameValue.Text, cellPhoneNameValue.Text);
                PersonModel p = GlobalConfig.Connection.CreatePerson(person);
                selectedMembers.Add(p);
                WiredUpList();
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailNameValue.Text = "";
                cellPhoneNameValue.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all the values in form.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailNameValue.Text.Length == 0)
            {
                return false;
            }
            if (cellPhoneNameValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addMemberButon_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableMembers.Remove(p);
                selectedMembers.Add(p);
                WiredUpList();
            }
        }

        private void removeSelectedButon_Click(object sender, EventArgs e)
        {

            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null)
            {
                selectedMembers.Remove(p);
                availableMembers.Add(p);
                WiredUpList();
            }
        }

        private void createTeamButon_Click(object sender, EventArgs e)
        {
            TeamModel team = new TeamModel();
            team.TeamName = teamNameValue.Text;
            team.TeamMembers = selectedMembers;

            team = GlobalConfig.Connection.CreateTeam(team);
        }
    }
}
