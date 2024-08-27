namespace UniversityManager.Forms
{
    partial class CourseInstructorForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.UpdateCourseInstructorButton = new System.Windows.Forms.Button();
            this.DeleteCourseInstructorButton = new System.Windows.Forms.Button();
            this.AddCourseInstructorButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.InstructorLabel = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.InstructorComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "fall",
            "spring",
            "summer"});
            this.comboBox1.Location = new System.Drawing.Point(40, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 29);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // UpdateCourseInstructorButton
            // 
            this.UpdateCourseInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCourseInstructorButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateCourseInstructorButton.Location = new System.Drawing.Point(119, 272);
            this.UpdateCourseInstructorButton.Name = "UpdateCourseInstructorButton";
            this.UpdateCourseInstructorButton.Size = new System.Drawing.Size(101, 73);
            this.UpdateCourseInstructorButton.TabIndex = 23;
            this.UpdateCourseInstructorButton.Text = "Update  Course Instructor";
            this.UpdateCourseInstructorButton.UseVisualStyleBackColor = true;
            this.UpdateCourseInstructorButton.Click += new System.EventHandler(this.UpdateCourseInstructorButton_Click_1);
            // 
            // DeleteCourseInstructorButton
            // 
            this.DeleteCourseInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCourseInstructorButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DeleteCourseInstructorButton.Location = new System.Drawing.Point(226, 272);
            this.DeleteCourseInstructorButton.Name = "DeleteCourseInstructorButton";
            this.DeleteCourseInstructorButton.Size = new System.Drawing.Size(101, 73);
            this.DeleteCourseInstructorButton.TabIndex = 22;
            this.DeleteCourseInstructorButton.Text = "Delete Course Instructor";
            this.DeleteCourseInstructorButton.UseVisualStyleBackColor = true;
            this.DeleteCourseInstructorButton.Click += new System.EventHandler(this.DeleteCourseInstructorButton_Click_1);
            // 
            // AddCourseInstructorButton
            // 
            this.AddCourseInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourseInstructorButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddCourseInstructorButton.Location = new System.Drawing.Point(12, 272);
            this.AddCourseInstructorButton.Name = "AddCourseInstructorButton";
            this.AddCourseInstructorButton.Size = new System.Drawing.Size(101, 73);
            this.AddCourseInstructorButton.TabIndex = 21;
            this.AddCourseInstructorButton.Text = "Add new Course Instructor";
            this.AddCourseInstructorButton.UseVisualStyleBackColor = true;
            this.AddCourseInstructorButton.Click += new System.EventHandler(this.AddCourseInstructorButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 324);
            this.dataGridView1.TabIndex = 20;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(132, 126);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(40, 13);
            this.CourseLabel.TabIndex = 19;
            this.CourseLabel.Text = "Course";
            // 
            // InstructorLabel
            // 
            this.InstructorLabel.AutoSize = true;
            this.InstructorLabel.Location = new System.Drawing.Point(127, 35);
            this.InstructorLabel.Name = "InstructorLabel";
            this.InstructorLabel.Size = new System.Drawing.Size(51, 13);
            this.InstructorLabel.TabIndex = 18;
            this.InstructorLabel.Text = "Instructor";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(46, 149);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(213, 32);
            this.CourseComboBox.TabIndex = 17;
            // 
            // InstructorComboBox
            // 
            this.InstructorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorComboBox.FormattingEnabled = true;
            this.InstructorComboBox.Location = new System.Drawing.Point(46, 58);
            this.InstructorComboBox.Name = "InstructorComboBox";
            this.InstructorComboBox.Size = new System.Drawing.Size(213, 32);
            this.InstructorComboBox.TabIndex = 16;
            // 
            // CourseInstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 351);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.UpdateCourseInstructorButton);
            this.Controls.Add(this.DeleteCourseInstructorButton);
            this.Controls.Add(this.AddCourseInstructorButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.InstructorLabel);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.InstructorComboBox);
            this.Name = "CourseInstructorForm";
            this.Text = "CourseInstructorForm";
            this.Load += new System.EventHandler(this.CourseInstructorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button UpdateCourseInstructorButton;
        private System.Windows.Forms.Button DeleteCourseInstructorButton;
        private System.Windows.Forms.Button AddCourseInstructorButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label InstructorLabel;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.ComboBox InstructorComboBox;
    }
}