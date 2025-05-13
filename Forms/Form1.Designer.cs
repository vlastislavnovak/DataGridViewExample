namespace Forms
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
            tblUsers = new DataGridView();
            btnSave = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            dtpBirthDate = new DateTimePicker();
            rbnMale = new RadioButton();
            rbnFemale = new RadioButton();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tblUsers).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tblUsers
            // 
            tblUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblUsers.Location = new Point(200, 11);
            tblUsers.Name = "tblUsers";
            tblUsers.RowHeadersWidth = 51;
            tblUsers.Size = new Size(682, 309);
            tblUsers.TabIndex = 0;
            tblUsers.CellValueChanged += tblUsers_CellValueChanged;
            tblUsers.DataError += tblUsers_DataError;
            tblUsers.UserDeletingRow += tblUsers_UserDeletingRow;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(807, 326);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 11);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Jméno";
            txtFirstName.Size = new Size(181, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 38);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Příjmení";
            txtLastName.Size = new Size(181, 23);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 6;
            label3.Text = "Datum narození";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(12, 90);
            dtpBirthDate.Margin = new Padding(3, 2, 3, 2);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(181, 23);
            dtpBirthDate.TabIndex = 7;
            // 
            // rbnMale
            // 
            rbnMale.AutoSize = true;
            rbnMale.Checked = true;
            rbnMale.Location = new Point(27, 20);
            rbnMale.Margin = new Padding(3, 2, 3, 2);
            rbnMale.Name = "rbnMale";
            rbnMale.Size = new Size(48, 19);
            rbnMale.TabIndex = 9;
            rbnMale.TabStop = true;
            rbnMale.Text = "Muž";
            rbnMale.UseVisualStyleBackColor = true;
            // 
            // rbnFemale
            // 
            rbnFemale.AutoSize = true;
            rbnFemale.Location = new Point(81, 20);
            rbnFemale.Margin = new Padding(3, 2, 3, 2);
            rbnFemale.Name = "rbnFemale";
            rbnFemale.Size = new Size(51, 19);
            rbnFemale.TabIndex = 10;
            rbnFemale.Text = "Žena";
            rbnFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnMale);
            groupBox1.Controls.Add(rbnFemale);
            groupBox1.Location = new Point(12, 126);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(181, 48);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pohlaví";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(119, 179);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Přidat";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(726, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Smazat";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(200, 326);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Hledat";
            txtSearch.Size = new Size(181, 23);
            txtSearch.TabIndex = 15;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 361);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(dtpBirthDate);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnSave);
            Controls.Add(tblUsers);
            Name = "Form1";
            Text = "DataGridViewExample";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tblUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblUsers;
        private Button btnSave;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private DateTimePicker dtpBirthDate;
        private RadioButton rbnMale;
        private RadioButton rbnFemale;
        private GroupBox groupBox1;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtSearch;
    }
}
