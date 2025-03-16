﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWinform
{
    public partial class WinMain : Form
    {
        public WinMain()
        {
            InitializeComponent();
        }

        public void ActivateSubForm(Form form)
        {
            form.Activate();
            form.BringToFront();
        }

        public void DisposeSubForm(Form parent)
        {
            foreach (Form _form in parent.MdiChildren)
            {
                if(_form != null) _form.Dispose();
            }
        }

        public Form SearchSubForm(Form parent, string searchText)
        {
            foreach (Form _form in parent.MdiChildren)
            {
                if (searchText == _form.Text) return _form;
            }
            return null;
        }

        public void ShowSubForm(Form parent, Form child)
        {
            Form _form = SearchSubForm(parent, child.Text);

            if (_form != null)
            {
                ActivateSubForm(_form);
                child.Dispose();
                return;
            }
            child.MdiParent = parent;
            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        private void tm종료_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mb학생등록_Click(object sender, System.EventArgs e)
        {
            frmStudentAdd form = new frmStudentAdd();
            ShowSubForm(this, form);
        }

        private void mb과목등록_Click(object sender, EventArgs e)
        {
            frmSubjectAdd form = new frmSubjectAdd();
            ShowSubForm(this, form);
        }

        private void mb수강신청_Click(object sender, EventArgs e)
        {
            frmCourseRegistration form = new frmCourseRegistration();
            ShowSubForm(this, form);
        }
    }
}
