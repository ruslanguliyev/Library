namespace Library
{
    partial class ViewBooks
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.DgvBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(206, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 31);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Teal;
            this.btnClear.Location = new System.Drawing.Point(559, 66);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 31);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
           
            // 
            // DgvBook
            // 
            this.DgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvBook.Location = new System.Drawing.Point(0, 103);
            this.DgvBook.Name = "DgvBook";
            this.DgvBook.RowHeadersWidth = 51;
            this.DgvBook.RowTemplate.Height = 29;
            this.DgvBook.Size = new System.Drawing.Size(800, 347);
            this.DgvBook.TabIndex = 3;
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvBook);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ViewBooks";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtSearch;
        private Button btnClear;
        private DataGridView DgvBook;
    }
}