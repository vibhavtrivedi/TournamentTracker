namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButon = new System.Windows.Forms.Button();
            this.createPrizeButon = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deletedSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deletePrizeButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.createTournamentLabel.Location = new System.Drawing.Point(38, 20);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(249, 31);
            this.createTournamentLabel.TabIndex = 1;
            this.createTournamentLabel.Text = "Create Tournament";
            this.createTournamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tournamentNameValue.Location = new System.Drawing.Point(44, 142);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(372, 38);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tournamentLabel.Location = new System.Drawing.Point(38, 96);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(239, 31);
            this.tournamentLabel.TabIndex = 9;
            this.tournamentLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.entryFeeValue.Location = new System.Drawing.Point(238, 243);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 38);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.entryFeeLabel.Location = new System.Drawing.Point(44, 243);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(132, 31);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(50, 362);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(372, 39);
            this.selectTeamDropdown.TabIndex = 14;
            this.selectTeamDropdown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.selectTeamLabel.Location = new System.Drawing.Point(44, 309);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(166, 31);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.selectTeamLabel_Click);
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(344, 324);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(72, 16);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            // 
            // addTeamButon
            // 
            this.addTeamButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addTeamButon.Location = new System.Drawing.Point(128, 487);
            this.addTeamButon.Name = "addTeamButon";
            this.addTeamButon.Size = new System.Drawing.Size(159, 46);
            this.addTeamButon.TabIndex = 16;
            this.addTeamButon.Text = "Add Team";
            this.addTeamButon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addTeamButon.UseVisualStyleBackColor = true;
            // 
            // createPrizeButon
            // 
            this.createPrizeButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.createPrizeButon.Location = new System.Drawing.Point(118, 573);
            this.createPrizeButon.Name = "createPrizeButon";
            this.createPrizeButon.Size = new System.Drawing.Size(177, 51);
            this.createPrizeButon.TabIndex = 17;
            this.createPrizeButon.Text = "Create Prize";
            this.createPrizeButon.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 31;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(540, 57);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(373, 283);
            this.tournamentPlayersListBox.TabIndex = 18;
            this.tournamentPlayersListBox.SelectedIndexChanged += new System.EventHandler(this.tournamentPlayersListBox_SelectedIndexChanged);
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(534, 20);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(196, 31);
            this.tournamentPlayersLabel.TabIndex = 19;
            this.tournamentPlayersLabel.Text = "Teams/Players";
            this.tournamentPlayersLabel.Click += new System.EventHandler(this.tournamentPlayersLabel_Click);
            // 
            // deletedSelectedPlayerButton
            // 
            this.deletedSelectedPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.deletedSelectedPlayerButton.Location = new System.Drawing.Point(936, 167);
            this.deletedSelectedPlayerButton.Name = "deletedSelectedPlayerButton";
            this.deletedSelectedPlayerButton.Size = new System.Drawing.Size(189, 51);
            this.deletedSelectedPlayerButton.TabIndex = 20;
            this.deletedSelectedPlayerButton.Text = "Delete Player";
            this.deletedSelectedPlayerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletedSelectedPlayerButton.UseVisualStyleBackColor = true;
            this.deletedSelectedPlayerButton.Click += new System.EventHandler(this.deletedSelectedPlayerButton_Click);
            // 
            // deletePrizeButton
            // 
            this.deletePrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.deletePrizeButton.Location = new System.Drawing.Point(936, 503);
            this.deletePrizeButton.Name = "deletePrizeButton";
            this.deletePrizeButton.Size = new System.Drawing.Size(189, 51);
            this.deletePrizeButton.TabIndex = 23;
            this.deletePrizeButton.Text = "Delete Prize";
            this.deletePrizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletePrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.prizesLabel.Location = new System.Drawing.Point(534, 350);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(196, 31);
            this.prizesLabel.TabIndex = 22;
            this.prizesLabel.Text = "Teams/Players";
            this.prizesLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // prizeListBox
            // 
            this.prizeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 31;
            this.prizeListBox.Location = new System.Drawing.Point(540, 384);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(373, 283);
            this.prizeListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.createTournamentButton.Location = new System.Drawing.Point(448, 674);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(311, 51);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 737);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deletePrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.deletedSelectedPlayerButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizeButon);
            this.Controls.Add(this.addTeamButon);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButon;
        private System.Windows.Forms.Button createPrizeButon;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button deletedSelectedPlayerButton;
        private System.Windows.Forms.Button deletePrizeButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}