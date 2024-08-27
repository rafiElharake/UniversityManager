namespace UniversityManager.Forms
{
    partial class MainForm
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
            this.StudentFormButton = new System.Windows.Forms.Button();
            this.InstructorFormButton = new System.Windows.Forms.Button();
            this.CourseFormButton = new System.Windows.Forms.Button();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.CourseInstructorButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentFormButton
            // 
            this.StudentFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFormButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StudentFormButton.Location = new System.Drawing.Point(20, 94);
            this.StudentFormButton.Name = "StudentFormButton";
            this.StudentFormButton.Size = new System.Drawing.Size(240, 56);
            this.StudentFormButton.TabIndex = 8;
            this.StudentFormButton.Text = "Student Form";
            this.StudentFormButton.UseVisualStyleBackColor = true;
            this.StudentFormButton.Click += new System.EventHandler(this.StudentFormButton_Click);
            // 
            // InstructorFormButton
            // 
            this.InstructorFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorFormButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.InstructorFormButton.Location = new System.Drawing.Point(280, 94);
            this.InstructorFormButton.Name = "InstructorFormButton";
            this.InstructorFormButton.Size = new System.Drawing.Size(240, 56);
            this.InstructorFormButton.TabIndex = 9;
            this.InstructorFormButton.Text = "Instructor Form";
            this.InstructorFormButton.UseVisualStyleBackColor = true;
            this.InstructorFormButton.Click += new System.EventHandler(this.InstructorFormButton_Click);
            // 
            // CourseFormButton
            // 
            this.CourseFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseFormButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CourseFormButton.Location = new System.Drawing.Point(540, 94);
            this.CourseFormButton.Name = "CourseFormButton";
            this.CourseFormButton.Size = new System.Drawing.Size(240, 56);
            this.CourseFormButton.TabIndex = 10;
            this.CourseFormButton.Text = "Course Form";
            this.CourseFormButton.UseVisualStyleBackColor = true;
            this.CourseFormButton.Click += new System.EventHandler(this.CourseFormButton_Click);
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EnrollmentButton.Location = new System.Drawing.Point(150, 203);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(240, 56);
            this.EnrollmentButton.TabIndex = 11;
            this.EnrollmentButton.Text = "Enrollment Form";
            this.EnrollmentButton.UseVisualStyleBackColor = true;
            this.EnrollmentButton.Click += new System.EventHandler(this.EnrollmentButton_Click);
            // 
            // CourseInstructorButton
            // 
            this.CourseInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseInstructorButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CourseInstructorButton.Location = new System.Drawing.Point(410, 203);
            this.CourseInstructorButton.Name = "CourseInstructorButton";
            this.CourseInstructorButton.Size = new System.Drawing.Size(240, 56);
            this.CourseInstructorButton.TabIndex = 12;
            this.CourseInstructorButton.Text = "Course Instructor Form";
            this.CourseInstructorButton.UseVisualStyleBackColor = true;
            this.CourseInstructorButton.Click += new System.EventHandler(this.CourseInstructorButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SignInButton.Location = new System.Drawing.Point(280, 12);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(240, 56);
            this.SignInButton.TabIndex = 13;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.CourseInstructorButton);
            this.Controls.Add(this.EnrollmentButton);
            this.Controls.Add(this.CourseFormButton);
            this.Controls.Add(this.InstructorFormButton);
            this.Controls.Add(this.StudentFormButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentFormButton;
        private System.Windows.Forms.Button InstructorFormButton;
        private System.Windows.Forms.Button CourseFormButton;
        private System.Windows.Forms.Button EnrollmentButton;
        private System.Windows.Forms.Button CourseInstructorButton;
        private System.Windows.Forms.Button SignInButton;
    }
}