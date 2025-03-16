using AdoNetWindow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWindow.View
{
    public class StudentView
    {
        public void ShowOnGrid(DataGridView control, List<StudentModel> list)
        {
            control.DataSource = list;
            control.Columns["StudentId"].HeaderText = "학생Id";
            control.Columns["StudentId"].ReadOnly = true;
            control.Columns["StudentName"].HeaderText = "학생성명";
            control.Columns["Address"].HeaderText = "주소";
        }

        public void ShowStudentOnCombo(ComboBox control, List<StudentModel> list)
        {
            control.DataSource = list;
            control.DisplayMember = "StudentName";
            control.ValueMember = "StudentId";
        }
    }
}
