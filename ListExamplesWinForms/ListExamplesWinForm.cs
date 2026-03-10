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

        //Event handlers below---------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ListExampleMethod();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
