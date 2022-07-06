namespace Library
{
    partial class AddReader
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
            this.txtId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwReader = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReader)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtId);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtNumber);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.txtFullname);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
           
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwReader);
            this.splitContainer1.Size = new System.Drawing.Size(837, 500);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 266);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(42, 286);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 28);
            this.label5.TabIndex = 60;
            this.label5.Text = "Add Reader Window";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(12, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 30);
            this.txtEmail.TabIndex = 47;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(109, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 29);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Full Name";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.Location = new System.Drawing.Point(12, 178);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(177, 30);
            this.txtNumber.TabIndex = 42;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(12, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 29);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullname.Location = new System.Drawing.Point(12, 72);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(177, 30);
            this.txtFullname.TabIndex = 42;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(12, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 29);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgwReader
            // 
            this.dgwReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwReader.Location = new System.Drawing.Point(0, 0);
            this.dgwReader.Name = "dgwReader";
            this.dgwReader.RowHeadersWidth = 51;
            this.dgwReader.RowTemplate.Height = 29;
            this.dgwReader.Size = new System.Drawing.Size(637, 500);
            this.dgwReader.TabIndex = 0;
            this.dgwReader.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwReader_RowHeaderMouseDoubleClick);
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 500);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddReader";
            this.Text = "AddReader";
            this.Load += new System.EventHandler(this.AddReader_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwReader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgwReader;
        private Button btnDelete;
        private Label label1;
        private Button btnUpdate;
        private TextBox txtFullname;
        private Button btnAdd;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNumber;
        private Label label5;
        private Label txtId;
        private Label lblId;
    }
}