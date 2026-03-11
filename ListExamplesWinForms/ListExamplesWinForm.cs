namespace ListExamplesWinForms
{
    public partial class ListExamplesWinForm : Form
    {
        public ListExamplesWinForm()
        {
            InitializeComponent();
        }
        //custom methods below---------------------------------
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
    }
}
