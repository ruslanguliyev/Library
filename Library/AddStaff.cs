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
    public partial class AddStaff : Form
    {
        StaffManager _staffManager = new();
        public AddStaff()
        {
            InitializeComponent();
        }

        public void FillDgv()
        {

            var allStaff = _staffManager.GetStaffs()
               .Select(allStaff => new
               {
                   ID = allStaff.ID,
                   FullName = allStaff.FullName,
                   Email = allStaff.Email,
                   Number = allStaff.Number,
                   Password = allStaff.Password,

               }).ToList();

            DgvStaff.DataSource = allStaff;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Fullname = txtFullname.Text;
            var Email = txtEmail.Text;
            var Number = txtNumber.Text;
            var Password = txtPassword.Text;

            Staff staff = new()
            {
                FullName = Fullname,
                Email = Email,
                Number = Number,
                Password = Password,
            };
            _staffManager.AddStaff(staff);
            MessageBox.Show("Staff is added");
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtNumber.Text = "";
            txtPassword.Text = "";
            FillDgv();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            FillDgv();
        }
    }
}
