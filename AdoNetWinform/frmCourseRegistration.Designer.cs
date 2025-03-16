namespace AdoNetWinform
{
    partial class frmCourseRegistration
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCourseRegistration = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgviewCourseRegistration = new System.Windows.Forms.DataGridView();
            this.dgviewSubject = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCourseRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCourseRegistration});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCourseRegistration
            // 
            this.btnCourseRegistration.Image = global::AdoNetWinform.Properties.Resources.plus;
            this.btnCourseRegistration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCourseRegistration.Name = "btnCourseRegistration";
            this.btnCourseRegistration.Size = new System.Drawing.Size(75, 22);
            this.btnCourseRegistration.Text = "수강신청";
            this.btnCourseRegistration.Click += new System.EventHandler(this.btnCourseRegistration_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxStudent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 51);
            this.panel1.TabIndex = 2;
            // 
            // cboxStudent
            // 
            this.cboxStudent.FormattingEnabled = true;
            this.cboxStudent.Location = new System.Drawing.Point(94, 16);
            this.cboxStudent.Name = "cboxStudent";
            this.cboxStudent.Size = new System.Drawing.Size(121, 20);
            this.cboxStudent.TabIndex = 1;
            this.cboxStudent.SelectionChangeCommitted += new System.EventHandler(this.cboxStudent_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "학생선택:";
            // 
            // dgviewCourseRegistration
            // 
            this.dgviewCourseRegistration.AllowUserToAddRows = false;
            this.dgviewCourseRegistration.AllowUserToDeleteRows = false;
            this.dgviewCourseRegistration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgviewCourseRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewCourseRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgviewCourseRegistration.Location = new System.Drawing.Point(0, 76);
            this.dgviewCourseRegistration.MultiSelect = false;
            this.dgviewCourseRegistration.Name = "dgviewCourseRegistration";
            this.dgviewCourseRegistration.ReadOnly = true;
            this.dgviewCourseRegistration.RowHeadersVisible = false;
            this.dgviewCourseRegistration.RowTemplate.Height = 23;
            this.dgviewCourseRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewCourseRegistration.Size = new System.Drawing.Size(289, 374);
            this.dgviewCourseRegistration.TabIndex = 3;
            // 
            // dgviewSubject
            // 
            this.dgviewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewSubject.Location = new System.Drawing.Point(289, 76);
            this.dgviewSubject.Name = "dgviewSubject";
            this.dgviewSubject.RowTemplate.Height = 23;
            this.dgviewSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewSubject.Size = new System.Drawing.Size(375, 374);
            this.dgviewSubject.TabIndex = 4;
            // 
            // frmCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.dgviewSubject);
            this.Controls.Add(this.dgviewCourseRegistration);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCourseRegistration";
            this.Text = "수강신청";
            this.Load += new System.EventHandler(this.frmCourseRegistration_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCourseRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgviewCourseRegistration;
        private System.Windows.Forms.DataGridView dgviewSubject;
        private System.Windows.Forms.ToolStripButton btnCourseRegistration;
    }
}