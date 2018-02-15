namespace SchoolMascotFormsKeithMO
{
    partial class frmSchoolMascots
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
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblSchoolMascot = new System.Windows.Forms.Label();
            this.grbSchool.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSchools
            // 
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(394, 24);
            this.mnuSchools.TabIndex = 0;
            this.mnuSchools.Text = "Schools";
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblSchoolMascot);
            this.grbSchool.Controls.Add(this.lblSchoolName);
            this.grbSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSchool.Location = new System.Drawing.Point(28, 95);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(304, 106);
            this.grbSchool.TabIndex = 1;
            this.grbSchool.TabStop = false;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Location = new System.Drawing.Point(36, 22);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(102, 20);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "Immaculata";
            // 
            // lblSchoolMascot
            // 
            this.lblSchoolMascot.AutoSize = true;
            this.lblSchoolMascot.Location = new System.Drawing.Point(36, 59);
            this.lblSchoolMascot.Name = "lblSchoolMascot";
            this.lblSchoolMascot.Size = new System.Drawing.Size(60, 20);
            this.lblSchoolMascot.TabIndex = 1;
            this.lblSchoolMascot.Text = "Saints";
            // 
            // frmSchoolMascots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuSchools);
            this.MainMenuStrip = this.mnuSchools;
            this.Name = "frmSchoolMascots";
            this.Text = "School Mascot Forms by Keith";
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblSchoolMascot;
        private System.Windows.Forms.Label lblSchoolName;
    }
}

