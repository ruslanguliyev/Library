using Business;
using DataAccess;
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
    public partial class AddReader : Form
    {
        
        ReaderManager _readermanager = new();
        public AddReader()
        {
            InitializeComponent();
        }

        public void FillDgv()
        {
            var allReader = _readermanager.GetReaders()
               .Select(allReader => new
               {
                   ID = allReader.ID,   
                   FullName = allReader.FullName,
                   Email = allReader.Email,
                   Number = allReader.Number,

               }).ToList();

            dgwReader.DataSource = allReader;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var FullName = txtFullname.Text;
            var Email = txtEmail.Text;
            var Number = txtNumber.Text;
            var readerEmail = _readermanager.GetReaderByEmail(Email);
            if (readerEmail != null)
            {
                MessageBox.Show("Email is exist!");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(FullName) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Number))
                {
                    MessageBox.Show("Fill in the fields!");
                }
                else
                {
                    Reader reader = new()
                    {
                        FullName = FullName,
                        Email = Email,
                        Number = Number,
                    };

                    _readermanager.AddReader(reader);
                    txtEmail.Text = "";
                    txtFullname.Text = "";
                    txtNumber.Text = "";
                    MessageBox.Show("Reader is added");
                    FillDgv();

                }
            }
           

        }

        private void AddReader_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void dgwReader_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int readerId = (int)dgwReader.Rows[e.RowIndex].Cells[0].Value;
            lblId.Text = readerId.ToString();
            var reader = _readermanager.GetReaderById(readerId);
            txtFullname.Text = reader.FullName;
            txtEmail.Text = reader.Email;
            txtNumber.Text = reader.Number;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnAdd.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int readerId = Convert.ToInt32(lblId.Text);
            var reader = _readermanager.GetReaderById(readerId);

            var fullName = txtFullname.Text;
            var email = txtEmail.Text;
            var number = txtNumber.Text;

            reader.FullName = fullName;
            reader.Email = email;
            reader.Number = number;
            _readermanager.UpdateReader(reader);

            MessageBox.Show("Reader is updated.");

            txtFullname.Text = "";
            txtEmail.Text = "";
            txtNumber.Text = "";
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = true;
            FillDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are your sure ? ", "Delete teacher", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int readerId = Convert.ToInt32(lblId.Text);
                var reader = _readermanager.GetReaderById(readerId);
                _readermanager.DeleteReader(reader);
                txtFullname.Text = "";
                txtEmail.Text = "";
                txtNumber.Text = "";
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                FillDgv();
            }
            else
            {
                txtFullname.Text = "";
                txtEmail.Text = "";
                txtNumber.Text = "";
                txtId.Text = "";
                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                FillDgv();
            }

        }


    }
}
