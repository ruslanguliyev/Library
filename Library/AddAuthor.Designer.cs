namespace Library
{
    partial class AddAuthor
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvAuthor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtFullName);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvAuthor);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(8, 71);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(170, 27);
            this.txtFullName.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(8, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(56, 23);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(8, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(105, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Author";
            // 
            // DgvAuthor
            // 
            this.DgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAuthor.Location = new System.Drawing.Point(0, 0);
            this.DgvAuthor.Name = "DgvAuthor";
            this.DgvAuthor.RowHeadersWidth = 51;
            this.DgvAuthor.RowTemplate.Height = 29;
            this.DgvAuthor.Size = new System.Drawing.Size(615, 450);
            this.DgvAuthor.TabIndex = 2;
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.Load += new System.EventHandler(this.AddAuthor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private DataGridView DgvAuthor;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label txtName;
        private TextBox txtFullName;
    }
}