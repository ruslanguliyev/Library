using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void LoadForm(object Form)
        {
            if (this.pnlHome.Controls.Count > 0)
                this.pnlHome.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlHome.Controls.Add(f);
            this.pnlHome.Tag = f;
            f.Show();

        }   

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            LoadForm(new AddReader());
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            LoadForm(new AddBook());
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            LoadForm(new AddStaff());
        }

       

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            LoadForm(new AddAuthor());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new ViewBooks());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
