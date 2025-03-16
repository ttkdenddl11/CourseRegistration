using AdoNet;
using AdoNetWindow.Model;
using AdoNetWindow.View;
using AppConfiguration;
using Libs;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWinform
{
    public partial class frmStudentAdd : AplicationRoot
    {
        iStudentRepository studentRepository;
        public frmStudentAdd()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            studentRepository = new StudentRepository();
            V_ShowStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentAdd();
            V_ShowStudent();
        }
        
        private void StudentAdd()
        {
            StudentModel studentModel = new StudentModel();
            studentModel.StudentName = txtStudentName.Text.Trim();
            studentModel.Address = txtAddress.Text.Trim();

            studentRepository.Add(studentModel);
        }
        
        private void V_ShowStudent()
        {
            StudentView studentView = new StudentView();
            studentView.ShowOnGrid(dgviewStudent, studentRepository.GetAll());
            //dgviewStudent.DataSource = studentRepository.GetAll();
            
            //dgviewStudent.Columns["StudentId"].HeaderText = "학생Id";
            //dgviewStudent.Columns["StudentId"].ReadOnly = true;
            //dgviewStudent.Columns["StudentName"].HeaderText = "학생성명";
            //dgviewStudent.Columns["Address"].HeaderText = "주소";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgviewStudent.SelectedRows.Count == 0) return;

            StudentModel model = dgviewStudent.SelectedRows[0].DataBoundItem as StudentModel;
            //int student_id = int.Parse(dgviewStudent.SelectedRows[0].Cells["StudentId"].Value.ToString());
            StudentDelete(model.StudentId);
        }

        private void StudentDelete(int student_id)
        {
            // studentRepository.Delete(student_id);
            iStudentDeleteHandler studentDeleteHandler = new StudentDeleteHandler();
            try
            {
                studentDeleteHandler.Delete(student_id);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            V_ShowStudent();
        }

        
        private void DgviewStudent_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgviewStudent.Rows.Count == 0 || dgviewStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("학생을 한명 선택해주세요.");
                return;
            }

            StudentModel studentModel = dgviewStudent.SelectedRows[0].DataBoundItem as StudentModel;
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                studentRepository.UpdateName(studentModel.StudentId, studentModel.StudentName);
            }
            V_ShowStudent();
        }
    }
}
