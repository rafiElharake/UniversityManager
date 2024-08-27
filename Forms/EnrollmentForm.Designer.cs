namespace UniversityManager.Forms
{
    partial class EnrollmentForm
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
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.UpdateEnrollmentButton = new System.Windows.Forms.Button();
            this.DeleteEnrollmentButton = new System.Windows.Forms.Button();
            this.AddEnrollmentButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enrollmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmingTutorialDBDataSet2 = new UniversityManager.ProgrammingTutorialDBDataSet2();
            this.enrollmentsTableAdapter = new UniversityManager.ProgrammingTutorialDBDataSet2TableAdapters.EnrollmentsTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingTutorialDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(121, 68);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(213, 32);
            this.StudentComboBox.TabIndex = 0;
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(121, 159);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(213, 32);
            this.CourseComboBox.TabIndex = 1;
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Location = new System.Drawing.Point(202, 45);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(50, 13);
            this.StudentLabel.TabIndex = 2;
            this.StudentLabel.Text = "Student  ";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(207, 136);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(40, 13);
            this.CourseLabel.TabIndex = 3;
            this.CourseLabel.Text = "Course";
            // 
            // UpdateEnrollmentButton
            // 
            this.UpdateEnrollmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEnrollmentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateEnrollmentButton.Location = new System.Drawing.Point(121, 280);
            this.UpdateEnrollmentButton.Name = "UpdateEnrollmentButton";
            this.UpdateEnrollmentButton.Size = new System.Drawing.Size(101, 56);
            this.UpdateEnrollmentButton.TabIndex = 13;
            this.UpdateEnrollmentButton.Text = "Update Enrollment";
            this.UpdateEnrollmentButton.UseVisualStyleBackColor = true;
            this.UpdateEnrollmentButton.Click += new System.EventHandler(this.UpdateEnrollmentButton_Click);
            // 
            // DeleteEnrollmentButton
            // 
            this.DeleteEnrollmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEnrollmentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteEnrollmentButton.Location = new System.Drawing.Point(228, 280);
            this.DeleteEnrollmentButton.Name = "DeleteEnrollmentButton";
            this.DeleteEnrollmentButton.Size = new System.Drawing.Size(101, 56);
            this.DeleteEnrollmentButton.TabIndex = 12;
            this.DeleteEnrollmentButton.Text = "Delete Enrollment";
            this.DeleteEnrollmentButton.UseVisualStyleBackColor = true;
            this.DeleteEnrollmentButton.Click += new System.EventHandler(this.DeleteEnrollmentButton_Click);
            // 
            // AddEnrollmentButton
            // 
            this.AddEnrollmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEnrollmentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddEnrollmentButton.Location = new System.Drawing.Point(14, 280);
            this.AddEnrollmentButton.Name = "AddEnrollmentButton";
            this.AddEnrollmentButton.Size = new System.Drawing.Size(101, 56);
            this.AddEnrollmentButton.TabIndex = 11;
            this.AddEnrollmentButton.Text = "Add new Enrollment";
            this.AddEnrollmentButton.UseVisualStyleBackColor = true;
            this.AddEnrollmentButton.Click += new System.EventHandler(this.AddEnrollmentButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(502, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 324);
            this.dataGridView1.TabIndex = 10;
            // 
            // enrollmentsBindingSource
            // 
            this.enrollmentsBindingSource.DataMember = "Enrollments";
            this.enrollmentsBindingSource.DataSource = this.programmingTutorialDBDataSet2;
            // 
            // programmingTutorialDBDataSet2
            // 
            this.programmingTutorialDBDataSet2.DataSetName = "ProgrammingTutorialDBDataSet2";
            this.programmingTutorialDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrollmentsTableAdapter
            // 
            this.enrollmentsTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 29);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "fall",
            "spring",
            "summer"});
            this.comboBox1.Location = new System.Drawing.Point(115, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 15;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SearchButton.Location = new System.Drawing.Point(335, 280);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(101, 56);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 353);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.UpdateEnrollmentButton);
            this.Controls.Add(this.DeleteEnrollmentButton);
            this.Controls.Add(this.AddEnrollmentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.StudentComboBox);
            this.Name = "EnrollmentForm";
            this.Text = "EnrollmentForm";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingTutorialDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Button UpdateEnrollmentButton;
        private System.Windows.Forms.Button DeleteEnrollmentButton;
        private System.Windows.Forms.Button AddEnrollmentButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProgrammingTutorialDBDataSet2 programmingTutorialDBDataSet2;
        private System.Windows.Forms.BindingSource enrollmentsBindingSource;
        private ProgrammingTutorialDBDataSet2TableAdapters.EnrollmentsTableAdapter enrollmentsTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SearchButton;
    }
}