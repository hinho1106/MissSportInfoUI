using System.ComponentModel;

namespace MissSportInfoUI
{
    partial class MainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //Define UI Object
        

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SportText = new Label();
            SportTextBox = new TextBox();
            SportDescription = new Label();
            InputSectionPanel = new Panel();
            VenueComboBox = new ComboBox();
            VenueText = new Label();
            SearchButton = new Button();
            ExcludedWordDescription = new Label();
            ExcludedWordTextBox = new TextBox();
            ExcludedWordText = new Label();
            DayComboBox = new ComboBox();
            DayText = new Label();
            SportInfoView = new DataGridView();
            InputSectionPanel.SuspendLayout();
            ((ISupportInitialize)SportInfoView).BeginInit();
            SuspendLayout();
            // 
            // SportText
            // 
            SportText.AutoSize = true;
            SportText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SportText.Location = new Point(19, 64);
            SportText.Name = "SportText";
            SportText.Size = new Size(57, 25);
            SportText.TabIndex = 0;
            SportText.Text = "Sport";
            // 
            // SportTextBox
            // 
            SportTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SportTextBox.Location = new Point(82, 61);
            SportTextBox.Name = "SportTextBox";
            SportTextBox.Size = new Size(141, 33);
            SportTextBox.TabIndex = 1;
            SportTextBox.Text = "Pickleball";
            // 
            // SportDescription
            // 
            SportDescription.AutoSize = true;
            SportDescription.Location = new Point(46, 97);
            SportDescription.Name = "SportDescription";
            SportDescription.Size = new Size(117, 15);
            SportDescription.TabIndex = 2;
            SportDescription.Text = "(e.g Pickleball/Skate)";
            // 
            // InputSectionPanel
            // 
            InputSectionPanel.BackColor = SystemColors.Control;
            InputSectionPanel.Controls.Add(VenueComboBox);
            InputSectionPanel.Controls.Add(VenueText);
            InputSectionPanel.Controls.Add(SearchButton);
            InputSectionPanel.Controls.Add(ExcludedWordDescription);
            InputSectionPanel.Controls.Add(ExcludedWordTextBox);
            InputSectionPanel.Controls.Add(ExcludedWordText);
            InputSectionPanel.Controls.Add(DayComboBox);
            InputSectionPanel.Controls.Add(DayText);
            InputSectionPanel.Controls.Add(SportDescription);
            InputSectionPanel.Controls.Add(SportText);
            InputSectionPanel.Controls.Add(SportTextBox);
            InputSectionPanel.Location = new Point(25, 23);
            InputSectionPanel.Name = "InputSectionPanel";
            InputSectionPanel.Size = new Size(715, 208);
            InputSectionPanel.TabIndex = 3;
            // 
            // VenueComboBox
            // 
            VenueComboBox.AllowDrop = true;
            VenueComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            VenueComboBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VenueComboBox.FormattingEnabled = true;
            VenueComboBox.ImeMode = ImeMode.NoControl;
            VenueComboBox.Location = new Point(102, 8);
            VenueComboBox.MaxDropDownItems = 2;
            VenueComboBox.Name = "VenueComboBox";
            VenueComboBox.Size = new Size(412, 33);
            VenueComboBox.TabIndex = 17;
            // 
            // VenueText
            // 
            VenueText.AutoSize = true;
            VenueText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VenueText.Location = new Point(19, 11);
            VenueText.Name = "VenueText";
            VenueText.Size = new Size(65, 25);
            VenueText.TabIndex = 16;
            VenueText.Text = "Venue";
            // 
            // SearchButton
            // 
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchButton.Location = new Point(491, 131);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(116, 36);
            SearchButton.TabIndex = 15;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            SearchButton.Paint += button_Paint;
            // 
            // ExcludedWordDescription
            // 
            ExcludedWordDescription.AutoSize = true;
            ExcludedWordDescription.Location = new Point(202, 167);
            ExcludedWordDescription.Name = "ExcludedWordDescription";
            ExcludedWordDescription.Size = new Size(110, 15);
            ExcludedWordDescription.TabIndex = 14;
            ExcludedWordDescription.Text = "(use ; as separators)";
            // 
            // ExcludedWordTextBox
            // 
            ExcludedWordTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedWordTextBox.Location = new Point(191, 131);
            ExcludedWordTextBox.Name = "ExcludedWordTextBox";
            ExcludedWordTextBox.Size = new Size(141, 33);
            ExcludedWordTextBox.TabIndex = 13;
            ExcludedWordTextBox.Text = "Family;LGBT";
            // 
            // ExcludedWordText
            // 
            ExcludedWordText.AutoSize = true;
            ExcludedWordText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedWordText.Location = new Point(19, 134);
            ExcludedWordText.Name = "ExcludedWordText";
            ExcludedWordText.Size = new Size(159, 25);
            ExcludedWordText.TabIndex = 12;
            ExcludedWordText.Text = "Excluded Word(s)";
            // 
            // DayComboBox
            // 
            DayComboBox.AllowDrop = true;
            DayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DayComboBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayComboBox.FormattingEnabled = true;
            DayComboBox.ImeMode = ImeMode.NoControl;
            DayComboBox.Items.AddRange(new object[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" });
            DayComboBox.Location = new Point(370, 61);
            DayComboBox.MaxDropDownItems = 4;
            DayComboBox.Name = "DayComboBox";
            DayComboBox.Size = new Size(121, 33);
            DayComboBox.TabIndex = 7;
            // 
            // DayText
            // 
            DayText.AutoSize = true;
            DayText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayText.Location = new Point(320, 64);
            DayText.Name = "DayText";
            DayText.Size = new Size(44, 25);
            DayText.TabIndex = 8;
            DayText.Text = "Day";
            // 
            // SportInfoView
            // 
            SportInfoView.AllowUserToAddRows = false;
            SportInfoView.AllowUserToDeleteRows = false;
            SportInfoView.AllowUserToResizeColumns = false;
            SportInfoView.AllowUserToResizeRows = false;
            SportInfoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SportInfoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SportInfoView.Location = new Point(25, 237);
            SportInfoView.Name = "SportInfoView";
            SportInfoView.RowHeadersWidth = 70;
            SportInfoView.Size = new Size(715, 421);
            SportInfoView.TabIndex = 4;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 661);
            Controls.Add(SportInfoView);
            Controls.Add(InputSectionPanel);
            Name = "MainUI";
            Text = "MissSportInfoUI";
            Load += Form1_Load;
            InputSectionPanel.ResumeLayout(false);
            InputSectionPanel.PerformLayout();
            ((ISupportInitialize)SportInfoView).EndInit();
            ResumeLayout(false);
        }

        #endregion



        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label SportText;
        private TextBox SportTextBox;
        private Label SportDescription;
        private Panel InputSectionPanel;
        private ComboBox DayComboBox;
        private Label DayText;
        private TextBox ExcludedWordTextBox;
        private Label ExcludedWordText;
        private Button SearchButton;
        private Label ExcludedWordDescription;

        private BindingList<EventInfo> SportList = new BindingList<EventInfo>();
        private DataGridView SportInfoView;
        private ComboBox VenueComboBox;
        private Label VenueText;
    }
}
