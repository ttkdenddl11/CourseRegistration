using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Libs
{
    public class StudentDeleteHandler : ClassRoot, iStudentDeleteHandler
    {
        public void Delete(int student_id)
        {
            IDbTransaction transaction = dbInstance.Connection.BeginTransaction();

            try
            {
                DeleteCourseRegistration(student_id, transaction);
                DeleteStudent(student_id, transaction);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }

        private void DeleteStudent(int student_id, IDbTransaction transaction)
        {
            StringBuilder qry = new StringBuilder();
            qry.Append(" DELETE FROM TB_Student");
            qry.Append(" WHERE StudentId = " + student_id);
            transaction.Connection.Execute(qry.ToString(), transaction: transaction);

        }

        private void DeleteCourseRegistration(int student_id, IDbTransaction transaction)
        {
            StringBuilder qry = new StringBuilder();
            qry.Append(" DELETE FROM TB_CourseRegistration");
            qry.Append(" WHERE StudentId = " + student_id);
            transaction.Connection.Execute(qry.ToString(), transaction: transaction);

        }
    }
}
