using AdoNetWindow.Model;
using AdoNetWindow.View;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWinform
{
    public partial class frmSubjectAdd : AplicationRoot
    {
        iSubjectRepository subjectRepository;
        public frmSubjectAdd()
        {
            InitializeComponent();
        }

        private void frmSubjectAdd_Load(object sender, EventArgs e)
        {
            subjectRepository = new SubjectRepository();
            V_ShowSubject();
        }

        private void btnSubjectAdd_Click(object sender, EventArgs e)
        {
            if (SubjectModelHasError())
                return;

            SubjectAdd();
            V_ShowSubject();
        }

        private void SubjectAdd()
        {
            SubjectModel model = new SubjectModel
            {
                SubjectName = txtSubjectAdd.Text.Trim()
            };

            subjectRepository.Add(model);
        }

        private bool SubjectModelHasError()
        {

            errorProvider1.Clear();
            bool error = false;

            if(txtSubjectAdd.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txtSubjectAdd, "과목명을 입력하세요.");
                error = true;
            }

            return error;
        }

        private void dgviewSubject_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void V_ShowSubject()
        {
            SubjectView subjectView = new SubjectView();
            subjectView.ShowOnGrid(dgviewSubject, subjectRepository.GetAll());
        }

        private void btnSubjectDelete_Click(object sender, EventArgs e)
        {
            if(dgviewSubject.Rows.Count == 0 || dgviewSubject.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 과목을 하나 선택하세요");
                return;
            }
            SubjectModel model = dgviewSubject.SelectedRows[0].DataBoundItem as SubjectModel;
            SubjectDelete(model.SubjectId);
            V_ShowSubject();
        }

        private void SubjectDelete(int subject_id)
        {
            subjectRepository.Delete(subject_id);
        }
    }
}
