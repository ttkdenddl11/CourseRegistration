namespace AdoNetWinform
{
    partial class frmSubjectAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubjectAdd = new System.Windows.Forms.Button();
            this.txtSubjectAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgviewSubject = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSubjectDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSubjectDelete);
            this.panel1.Controls.Add(this.btnSubjectAdd);
            this.panel1.Controls.Add(this.txtSubjectAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 0;
            // 
            // btnSubjectAdd
            // 
            this.btnSubjectAdd.Location = new System.Drawing.Point(280, 18);
            this.btnSubjectAdd.Name = "btnSubjectAdd";
            this.btnSubjectAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSubjectAdd.TabIndex = 2;
            this.btnSubjectAdd.Text = "등록";
            this.btnSubjectAdd.UseVisualStyleBackColor = true;
            this.btnSubjectAdd.Click += new System.EventHandler(this.btnSubjectAdd_Click);
            // 
            // txtSubjectAdd
            // 
            this.txtSubjectAdd.Location = new System.Drawing.Point(87, 20);
            this.txtSubjectAdd.Name = "txtSubjectAdd";
            this.txtSubjectAdd.Size = new System.Drawing.Size(187, 21);
            this.txtSubjectAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "과목명:";
            // 
            // dgviewSubject
            // 
            this.dgviewSubject.AllowUserToAddRows = false;
            this.dgviewSubject.AllowUserToDeleteRows = false;
            this.dgviewSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgviewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewSubject.Location = new System.Drawing.Point(0, 72);
            this.dgviewSubject.MultiSelect = false;
            this.dgviewSubject.Name = "dgviewSubject";
            this.dgviewSubject.RowHeadersVisible = false;
            this.dgviewSubject.RowTemplate.Height = 23;
            this.dgviewSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewSubject.Size = new System.Drawing.Size(800, 378);
            this.dgviewSubject.TabIndex = 1;
            this.dgviewSubject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgviewSubject_MouseClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSubjectDelete
            // 
            this.btnSubjectDelete.Location = new System.Drawing.Point(361, 18);
            this.btnSubjectDelete.Name = "btnSubjectDelete";
            this.btnSubjectDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSubjectDelete.TabIndex = 3;
            this.btnSubjectDelete.Text = "삭제";
            this.btnSubjectDelete.UseVisualStyleBackColor = true;
            this.btnSubjectDelete.Click += new System.EventHandler(this.btnSubjectDelete_Click);
            // 
            // frmSubjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgviewSubject);
            this.Controls.Add(this.panel1);
            this.Name = "frmSubjectAdd";
            this.Text = "frmSubjectAdd";
            this.Load += new System.EventHandler(this.frmSubjectAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubjectAdd;
        private System.Windows.Forms.TextBox txtSubjectAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgviewSubject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSubjectDelete;
    }
}