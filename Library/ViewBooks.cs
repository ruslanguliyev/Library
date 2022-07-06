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
    public partial class ViewBooks : Form
    {
        BookManager _bookManager = new();
        public ViewBooks()
        {
            InitializeComponent();
        }

        





        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //(DgvBook.DataSource as DataTable).DefaultView.RowFilter = $"PName LIKE '%{txtSearch.Text}%'";
            var search = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(search))
            {
                DgvBook.DataSource = null;
            }
            else
            {
                var searchBook = _bookManager.BookNames()
               .Select(searchBook => new
               {
                   ID = searchBook.ID,
                   Name = searchBook.Name,
                   Price = searchBook.Price,
                   Author = searchBook.Author.FullName,
                   Delete = searchBook.IsDeleted,
                   PublishD = searchBook.PublishDate,


               }).ToList();

                DgvBook.DataSource = searchBook;
            }

        }


    }
}
