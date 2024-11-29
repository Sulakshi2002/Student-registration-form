namespace Activity02DBconnection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtid = new TextBox();
            txtname = new TextBox();
            txtaddress = new TextBox();
            add = new Button();
            update = new Button();
            delete = new Button();
            NEW = new Button();
            search = new Button();
            close = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 26);
            label1.Name = "label1";
            label1.Size = new Size(318, 22);
            label1.TabIndex = 0;
            label1.Text = "STUDENT REGISTRATION FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 86);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 1;
            label2.Text = "ID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 142);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 2;
            label3.Text = "Name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 204);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 3;
            label4.Text = "Address : ";
            // 
            // txtid
            // 
            txtid.Location = new Point(166, 86);
            txtid.Name = "txtid";
            txtid.Size = new Size(172, 23);
            txtid.TabIndex = 4;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // txtname
            // 
            txtname.Location = new Point(166, 138);
            txtname.Name = "txtname";
            txtname.Size = new Size(276, 23);
            txtname.TabIndex = 5;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(166, 200);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(276, 23);
            txtaddress.TabIndex = 6;
            // 
            // add
            // 
            add.Location = new Point(53, 273);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 7;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // update
            // 
            update.Location = new Point(186, 273);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 8;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(327, 273);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 9;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // NEW
            // 
            NEW.Location = new Point(468, 273);
            NEW.Name = "NEW";
            NEW.Size = new Size(75, 23);
            NEW.TabIndex = 10;
            NEW.Text = "NEW";
            NEW.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            search.Location = new Point(728, 273);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 11;
            search.Text = "SEARCH";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // close
            // 
            close.Location = new Point(587, 402);
            close.Name = "close";
            close.Size = new Size(75, 23);
            close.TabIndex = 12;
            close.Text = "CLOSE";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.PaleGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(106, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(425, 150);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(587, 273);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(135, 23);
            txtSearch.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(800, 493);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(close);
            Controls.Add(search);
            Controls.Add(NEW);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(add);
            Controls.Add(txtaddress);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox txtaddress;
        private Button add;
        private Button update;
        private Button delete;
        private Button NEW;
        private Button search;
        private Button close;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
    }
}
