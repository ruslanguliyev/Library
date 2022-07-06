namespace Library
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DgvBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblId);
            this.splitContainer1.Panel1.Controls.Add(this.cmbAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.dateTime);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtPrice);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtDesc);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvBook);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(21, 373);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(12, 237);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(182, 31);
            this.cmbAuthor.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Author Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 28);
            this.label5.TabIndex = 60;
            this.label5.Text = " Add Book Window";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Publish Date";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(12, 293);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(177, 27);
            this.dateTime.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(12, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(177, 30);
            this.txtPrice.TabIndex = 56;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(109, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 29);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Name";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDesc.Location = new System.Drawing.Point(12, 181);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(177, 30);
            this.txtDesc.TabIndex = 50;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(12, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 29);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(12, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 30);
            this.txtName.TabIndex = 51;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(12, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 29);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DgvBook
            // 
            this.DgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvBook.Location = new System.Drawing.Point(0, 0);
            this.DgvBook.Name = "DgvBook";
            this.DgvBook.RowHeadersWidth = 51;
            this.DgvBook.RowTemplate.Height = 29;
            this.DgvBook.Size = new System.Drawing.Size(609, 450);
            this.DgvBook.TabIndex = 0;
            this.DgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBook_CellContentClick);
            this.DgvBook.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBook_RowHeaderMouseDoubleClick);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView DgvBook;
        private Label label3;
        private TextBox txtPrice;
        private Button btnDelete;
        private Label label2;
        private Label label1;
        private TextBox txtDesc;
        private Button btnUpdate;
        private TextBox txtName;
        private Button btnAdd;
        private DateTimePicker dateTime;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbAuthor;
        private Label lblId;
    }
}