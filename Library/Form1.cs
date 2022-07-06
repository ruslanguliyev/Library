namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new();
            adminPanel.Show();
        }
    }
}