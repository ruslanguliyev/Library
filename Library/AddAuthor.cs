using Business;
using Entities;
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
    public partial class AddAuthor : Form
    {
        AuthorManager _authorManager = new();
        public AddAuthor()
        {
            InitializeComponent();
        }

        public void FillDgv()
        {
            var allAuthor = _authorManager.GetAuthors()
                .Select(allAuthor => new
                {
                    ID = allAuthor.ID,
                    FullName = allAuthor.FullName,

                }).ToList();
            DgvAuthor.DataSource = allAuthor;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Name = txtFullName.Text;

            Author author = new()
            {
                FullName = Name,
            };
            _authorManager.AddAuthor(author);
            txtFullName.Text = "";
            MessageBox.Show("Author is added");
            FillDgv();
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

       
    }
}
