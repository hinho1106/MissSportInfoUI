using System.Windows.Forms;

namespace MissSportInfoUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void button_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SearchButton.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Update SportInfoHeader
            SportInfoView.DataSource = SportList;
            List<string> venues = DataHandler.GetAllVenues();
            foreach(string venue in venues)
            {
                VenueComboBox.Items.Add(venue);
            }

            //Update Items in Day Combobox
            DateTime today = DateTime.Now;
            for(int i = 0; i<7; i++)
            {
                DayComboBox.Items.Add(today.AddDays(i).ToString("yyyy-MM-dd"));
            }

        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            //Clear all data in the DataGrid table
            SportInfoView.Rows.Clear();

            bool isValidated = true;

            //Validataion check
            if (DayComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select day");
                isValidated = false;
            }
            else if (VenueComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select venue");
                isValidated = false;
            }

            //When Validated
            if (isValidated)
            {

                //Loading Message Box Controlling
                bool isAllLoaded = false;
                {
                    LoadingMessageBox LoadingMsgBox = new LoadingMessageBox();


                    Task.Run(() =>
                    {
                        LoadingMsgBox.ShowDialog();

                    });


                    Task.Run(() =>
                    {

                        while (!isAllLoaded)
                        {
                            Thread.Sleep(200);
                        }

                        LoadingMsgBox.Dispose();
                        LoadingMsgBox.Close();
                    });



                }

                //Pass UI text to DataHandler and process data
                string sport = SportTextBox.Text;
                string day = DayComboBox.Text;
                string venue = VenueComboBox.Text;

                List<EventInfo> infoTable = DataHandler.processData(venue, sport, day);
         

                //Print all info on DataGrid Table

                //use binding source to hold dummy data
                BindingSource binding = new BindingSource();
                binding.DataSource = infoTable;

                //bind datagridview to binding source
                SportInfoView.DataSource = binding;

                isAllLoaded = true;
            }
        }

        
    }
}
