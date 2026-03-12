namespace ListExamplesWinForms
{
    public partial class ListExamplesWinForm : Form
    {
        public ListExamplesWinForm()
        {
            InitializeComponent();
            SetDefaults();
            LoadTestData();
        }
        //custom methods below---------------------------------
        void LoadTestData()
        {
            DisplayListBox.Items.Add("T,Ash Rombo");
            DisplayListBox.Items.Add("Tello,Jeo Reebe");
            DisplayListBox.Items.Add("Doe,Jane");
            SelectionComboBox.Items.Add("T,Ash Rombo");
            SelectionComboBox.Items.Add("Tello,Jeo");
            SelectionComboBox.Items.Add("Doe,Jane");
        }

        void SetDefaults()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            CompanyTextBox.Text = "";

            FirstNameTextBox.BackColor = Color.LightYellow;
            LastNameTextBox.BackColor = Color.LightYellow;
            CompanyTextBox.BackColor = Color.LightYellow;

            SubmitButton.Enabled = false;
            FirstNameTextBox.Select();

            if (SelectionComboBox.Items.Count > 0 && DisplayListBox.Items.Count > 0)
            {
                SelectionComboBox.SelectedIndex = 0;
                DisplayListBox.SelectedIndex = 0;
            }
        }

        void ListExampleMethod()
        {
            List<string> names = new List<string>();
            names.Add("Shayla");
            names.Add("oaky");
            names.Add("Hayley");
            this.Text = names.Count.ToString();
            names.Remove("Shayla");
            this.Text = Name.Count().ToString();
            //Console.WriteLine(names.Count);

        }

        void AddItemToListBox()
        {
            DisplayListBox.Items.Add($"{LastNameTextBox.Text},{FirstNameTextBox.Text} {CompanyTextBox.Text}");
        }

        void AddItemToComboBox()
        {
            SelectionComboBox.Items.Add($"{LastNameTextBox.Text},{FirstNameTextBox.Text}");
            if (SelectionComboBox.Items.Count > 0)
            {
                SelectionComboBox.SelectedIndex = 0;
            }
        }

        //Event handlers below---------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //ListExampleMethod();
            AddItemToListBox();
            AddItemToComboBox();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            CompanyTextBox.Text = "";
            SubmitButton.Enabled = false;
            FirstNameTextBox.Select();
        }

        private void DisplayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] temp = DisplayListBox.SelectedItem.ToString().Split(" ");
            CompanyTextBox.Text = temp[1];
            //isolate lastname firstname
            temp = temp[0].Split(",");
            FirstNameTextBox.Text = temp[1];
            LastNameTextBox.Text = temp[0];
            //this.Text = DisplayListBox.SelectedIndex.ToString(); //Number of item in list
            //FirstNameTextBox.Text = DisplayListBox.SelectedItem.ToString(); //Actual content of the list
        }

        private void SelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DisplayListBox.SelectedIndex = SelectionComboBox.SelectedIndex;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text != "")
            {
                FirstNameTextBox.BackColor = Color.White;
                if (FirstNameTextBox.Text != "" && LastNameTextBox.Text != "" && CompanyTextBox.Text != "")
                {
                    SubmitButton.Enabled = true;
                }
            }
            else
            {
                FirstNameTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text != "")
            {
                LastNameTextBox.BackColor = Color.White;
                if (FirstNameTextBox.Text != "" && LastNameTextBox.Text != "" && CompanyTextBox.Text != "")
                {
                    SubmitButton.Enabled = true;
                }
            }
            else
            {
                LastNameTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;

            }
        }

        private void CompanyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CompanyTextBox.Text != "")
            {
                CompanyTextBox.BackColor = Color.White;
                if (FirstNameTextBox.Text != "" && LastNameTextBox.Text != "" && CompanyTextBox.Text != "")
                {
                    SubmitButton.Enabled = true;
                }
            }
            else
            {
                CompanyTextBox.BackColor = Color.LightYellow;
                SubmitButton.Enabled = false;

            }
        }
    }
}
