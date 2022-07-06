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
    public partial class AddBook : Form
    {
        AuthorManager _authormanager = new();
        BookManager _bookManager = new();
        public AddBook()
        {
            InitializeComponent();
        }
        
        public void FillDGV()
        {
            var allBook = _bookManager.GetAllBook()
                .Select(allBook => new
                {
                    ID = allBook.ID,
                    Name = allBook.Name,
                    Price = allBook.Price,
                    Author = allBook.Author.FullName,
                    Delete = allBook.IsDeleted,
                    PublishD = allBook.PublishDate,

                }).ToList();

            DgvBook.DataSource = allBook;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var price = txtPrice.Text;
            var desc = txtDesc.Text;
            var publishD = dateTime.Value;
            var cmbAuthors = cmbAuthor.Text;
            var selectedAuthor = _authormanager.GetAuthorByName(cmbAuthors);
            var bookName = _bookManager.BookName(name);
            if (bookName != null)
            {
                MessageBox.Show("Name is exist");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(desc))
                {
                    MessageBox.Show("Fill in the fields!");
                }
                else
                {
                    Book book = new()
                    {
                        Name = name,
                        Price = price,
                        Description = desc,
                        PublishDate = publishD,
                        AuthorID = selectedAuthor.ID,

                    };
                    _bookManager.AddBook(book);
                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtDesc.Text = "";

                    MessageBox.Show("Book is added");
                    FillDGV();
                }
            }
           
;
           

        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            var author = _authormanager.GetAllAuthors();
            foreach (var item in author)
            {
                cmbAuthor.Items.Add(item.FullName);
            }
            FillDGV();
        }

        private void DgvBook_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int bookId = (int)DgvBook.Rows[e.RowIndex].Cells[0].Value;
            lblId.Text = bookId.ToString(); 
            var book = _bookManager.GetBookById(bookId);
            txtName.Text = book.Name;
            txtDesc.Text = book.Description;
            txtPrice.Text = book.Price;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(lblId.Text);
            var book = _bookManager.GetBookById(bookId);

            var name = txtName.Text;
            var desc = txtDesc.Text;
            var price = txtPrice.Text;

            book.Name = name;
            book.Description = desc;
            book.Price = price;
            _bookManager.UpdateBook(book);

            MessageBox.Show("Book is updated!");

            txtName.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            btnAdd.Visible = true;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            FillDGV();


        }

        private void DgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
