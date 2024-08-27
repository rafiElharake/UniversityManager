namespace UniversityManager.Forms
{
    partial class InstructorForm
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
            this.components = new System.ComponentModel.Container();
            this.UpdateInstructorButton = new System.Windows.Forms.Button();
            this.DeleteInstructorButton = new System.Windows.Forms.Button();
            this.AddInstructorButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.instructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmingTutorialDBDataSet1 = new UniversityManager.ProgrammingTutorialDBDataSet1();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.instructorsTableAdapter = new UniversityManager.ProgrammingTutorialDBDataSet1TableAdapters.InstructorsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingTutorialDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateInstructorButton
            // 
            this.UpdateInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateInstructorButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateInstructorButton.Location = new System.Drawing.Point(119, 280);
            this.UpdateInstructorButton.Name = "UpdateInstructorButton";
            this.UpdateInstructorButton.Size = new System.Drawing.Size(101, 56);
            this.UpdateInstructorButton.TabIndex = 19;
            this.UpdateInstructorButton.Text = "Update Instructor";
            this.UpdateInstructorButton.UseVisualStyleBackColor = true;
            this.UpdateInstructorButton.Click += new System.EventHandler(this.UpdateInstructorButton_Click);
            // 
            // DeleteInstructorButton
            // 
            this.DeleteInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInstructorButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteInstructorButton.Location = new System.Drawing.Point(226, 280);
            this.DeleteInstructorButton.Name = "DeleteInstructorButton";
            this.DeleteInstructorButton.Size = new System.Drawing.Size(101, 56);
            this.DeleteInstructorButton.TabIndex = 18;
            this.DeleteInstructorButton.Text = "Delete Instructor";
            this.DeleteInstructorButton.UseVisualStyleBackColor = true;
            this.DeleteInstructorButton.Click += new System.EventHandler(this.DeleteInstructorButton_Click);
            // 
            // AddInstructorButton
            // 
            this.AddInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInstructorButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddInstructorButton.Location = new System.Drawing.Point(12, 280);
            this.AddInstructorButton.Name = "AddInstructorButton";
            this.AddInstructorButton.Size = new System.Drawing.Size(101, 56);
            this.AddInstructorButton.TabIndex = 17;
            this.AddInstructorButton.Text = "Add New Instructor";
            this.AddInstructorButton.UseVisualStyleBackColor = true;
            this.AddInstructorButton.Click += new System.EventHandler(this.AddInstructorButton_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EmailLabel.Location = new System.Drawing.Point(8, 188);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(208, 29);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email";
            // 
            // EmailValue
            // 
            this.EmailValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailValue.Location = new System.Drawing.Point(12, 220);
            this.EmailValue.MaxLength = 50;
            this.EmailValue.MinimumSize = new System.Drawing.Size(208, 26);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(276, 26);
            this.EmailValue.TabIndex = 15;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LastNameLabel.Location = new System.Drawing.Point(8, 101);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(99, 24);
            this.LastNameLabel.TabIndex = 14;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameValue
            // 
            this.LastNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameValue.Location = new System.Drawing.Point(12, 128);
            this.LastNameValue.MaxLength = 50;
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(276, 26);
            this.LastNameValue.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instructorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(387, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 324);
            this.dataGridView1.TabIndex = 12;
            // 
            // instructorsBindingSource
            // 
            this.instructorsBindingSource.DataMember = "Instructors";
            this.instructorsBindingSource.DataSource = this.programmingTutorialDBDataSet1;
            // 
            // programmingTutorialDBDataSet1
            // 
            this.programmingTutorialDBDataSet1.DataSetName = "ProgrammingTutorialDBDataSet1";
            this.programmingTutorialDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FirstNameLabel.Location = new System.Drawing.Point(8, 9);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(101, 24);
            this.FirstNameLabel.TabIndex = 11;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValue.Location = new System.Drawing.Point(12, 36);
            this.FirstNameValue.MaxLength = 50;
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(276, 26);
            this.FirstNameValue.TabIndex = 10;
            // 
            // instructorsTableAdapter
            // 
            this.instructorsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 205;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 352);
            this.Controls.Add(this.UpdateInstructorButton);
            this.Controls.Add(this.DeleteInstructorButton);
            this.Controls.Add(this.AddInstructorButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailValue);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameValue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameValue);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingTutorialDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateInstructorButton;
        private System.Windows.Forms.Button DeleteInstructorButton;
        private System.Windows.Forms.Button AddInstructorButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private ProgrammingTutorialDBDataSet1 programmingTutorialDBDataSet1;
        private System.Windows.Forms.BindingSource instructorsBindingSource;
        private ProgrammingTutorialDBDataSet1TableAdapters.InstructorsTableAdapter instructorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}