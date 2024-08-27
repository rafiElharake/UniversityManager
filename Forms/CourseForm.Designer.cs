namespace UniversityManager.Forms
{
    partial class CourseForm
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
            this.UpdateCourseButton = new System.Windows.Forms.Button();
            this.DeleteCourseButton = new System.Windows.Forms.Button();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.CreditsValue = new System.Windows.Forms.TextBox();
            this.CourseCodeLabel = new System.Windows.Forms.Label();
            this.CourseCodeValue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmingTutorialDBDataSet3 = new UniversityManager.ProgrammingTutorialDBDataSet3();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.CourseNameValue = new System.Windows.Forms.TextBox();
            this.coursesTableAdapter = new UniversityManager.ProgrammingTutorialDBDataSet3TableAdapters.CoursesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingTutorialDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateCourseButton
            // 
            this.UpdateCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCourseButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateCourseButton.Location = new System.Drawing.Point(116, 286);
            this.UpdateCourseButton.Name = "UpdateCourseButton";
            this.UpdateCourseButton.Size = new System.Drawing.Size(101, 56);
            this.UpdateCourseButton.TabIndex = 19;
            this.UpdateCourseButton.Text = "Update Course";
            this.UpdateCourseButton.UseVisualStyleBackColor = true;
            this.UpdateCourseButton.Click += new System.EventHandler(this.UpdateCourseButton_Click_1);
            // 
            // DeleteCourseButton
            // 
            this.DeleteCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCourseButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteCourseButton.Location = new System.Drawing.Point(223, 286);
            this.DeleteCourseButton.Name = "DeleteCourseButton";
            this.DeleteCourseButton.Size = new System.Drawing.Size(101, 56);
            this.DeleteCourseButton.TabIndex = 18;
            this.DeleteCourseButton.Text = "Delete Course";
            this.DeleteCourseButton.UseVisualStyleBackColor = true;
            this.DeleteCourseButton.Click += new System.EventHandler(this.DeleteCourseButton_Click);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourseButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddCourseButton.Location = new System.Drawing.Point(9, 286);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(101, 56);
            this.AddCourseButton.TabIndex = 17;
            this.AddCourseButton.Text = "Add New Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreditsLabel.Location = new System.Drawing.Point(5, 194);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(208, 29);
            this.CreditsLabel.TabIndex = 16;
            this.CreditsLabel.Text = "Credits";
            // 
            // CreditsValue
            // 
            this.CreditsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreditsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsValue.Location = new System.Drawing.Point(9, 226);
            this.CreditsValue.MaxLength = 50;
            this.CreditsValue.MinimumSize = new System.Drawing.Size(208, 26);
            this.CreditsValue.Name = "CreditsValue";
            this.CreditsValue.Size = new System.Drawing.Size(276, 26);
            this.CreditsValue.TabIndex = 15;
            // 
            // CourseCodeLabel
            // 
            this.CourseCodeLabel.AutoSize = true;
            this.CourseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseCodeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CourseCodeLabel.Location = new System.Drawing.Point(5, 107);
            this.CourseCodeLabel.Name = "CourseCodeLabel";
            this.CourseCodeLabel.Size = new System.Drawing.Size(122, 24);
            this.CourseCodeLabel.TabIndex = 14;
            this.CourseCodeLabel.Text = "Course Code";
            // 
            // CourseCodeValue
            // 
            this.CourseCodeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseCodeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseCodeValue.Location = new System.Drawing.Point(9, 134);
            this.CourseCodeValue.MaxLength = 50;
            this.CourseCodeValue.Name = "CourseCodeValue";
            this.CourseCodeValue.Size = new System.Drawing.Size(276, 26);
            this.CourseCodeValue.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(384, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 324);
            this.dataGridView1.TabIndex = 12;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.programmingTutorialDBDataSet3;
            // 
            // programmingTutorialDBDataSet3
            // 
            this.programmingTutorialDBDataSet3.DataSetName = "ProgrammingTutorialDBDataSet3";
            this.programmingTutorialDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CourseNameLabel.Location = new System.Drawing.Point(5, 15);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(127, 24);
            this.CourseNameLabel.TabIndex = 11;
            this.CourseNameLabel.Text = "Course Name";
            // 
            // CourseNameValue
            // 
            this.CourseNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNameValue.Location = new System.Drawing.Point(9, 42);
            this.CourseNameValue.MaxLength = 50;
            this.CourseNameValue.Name = "CourseNameValue";
            this.CourseNameValue.Size = new System.Drawing.Size(276, 26);
            this.CourseNameValue.TabIndex = 10;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 205;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 356);
            this.Controls.Add(this.UpdateCourseButton);
            this.Controls.Add(this.DeleteCourseButton);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.CreditsValue);
            this.Controls.Add(this.CourseCodeLabel);
            this.Controls.Add(this.CourseCodeValue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CourseNameLabel);
            this.Controls.Add(this.CourseNameValue);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingTutorialDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateCourseButton;
        private System.Windows.Forms.Button DeleteCourseButton;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Label CreditsLabel;
        private System.Windows.Forms.TextBox CreditsValue;
        private System.Windows.Forms.Label CourseCodeLabel;
        private System.Windows.Forms.TextBox CourseCodeValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.TextBox CourseNameValue;
        private ProgrammingTutorialDBDataSet3 programmingTutorialDBDataSet3;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private ProgrammingTutorialDBDataSet3TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
    }
}