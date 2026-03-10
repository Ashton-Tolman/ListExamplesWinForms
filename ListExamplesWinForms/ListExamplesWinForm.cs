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
        }

        //Event handlers below---------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
