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
    public partial class frmCourseRegistration : Form
    {
        StudentModel selectedStudent;
        iCourseRegistrationRepository courseRegistrationRepository;
        public frmCourseRegistration()
        {
            InitializeComponent();
        }

        private void frmCourseRegistration_Load(object sender, EventArgs e)
        {
            courseRegistrationRepository = new CourseRegistrationRepository();

            V_ShowStudentOnCombo();
        }

        private void V_ShowStudentOnCombo()
        {
            StudentView studentView = new StudentView();

            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { StudentId = -1, StudentName = "--선택하세요--" });
            students.AddRange((new StudentRepository()).GetAll());
            studentView.ShowStudentOnCombo(cboxStudent, students);
        }

        private void cboxStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedStudent = cboxStudent.SelectedItem as StudentModel;
            V_ShowCourseRegistrationOnGrid();
            V_ShowSubject();
        }

        private void V_ShowSubject()
        {
            SubjectView subjectView = new SubjectView();
            subjectView.ShowOnGrid(dgviewSubject, ((new SubjectRepository().GetAll())));
        }

        private void V_ShowCourseRegistrationOnGrid()
        {
            CourseRegistrationView courseRegistrationView = new CourseRegistrationView();
            List<CourseRegistrationModel> list = courseRegistrationRepository.GetByUser(selectedStudent.StudentId);

            courseRegistrationView.ShowOnGrid(dgviewCourseRegistration, list);
        }

        private void btnCourseRegistration_Click(object sender, EventArgs e)
        {
            DoCourseRegistration();
            V_ShowCourseRegistrationOnGrid();
        }

        private void DoCourseRegistration()
        {
            foreach (DataGridViewRow dgvr in dgviewSubject.SelectedRows)
            {
                SubjectModel subjectModel = dgvr.DataBoundItem as SubjectModel;
                try
                {
                    courseRegistrationRepository.Add(selectedStudent.StudentId, subjectModel.SubjectId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("같은 과목은 두번 이상 신청할 수 없습니다.");
                }
            }
        }
    }
}
