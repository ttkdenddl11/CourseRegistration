﻿using AdoNetWindow.Model;
using Dapper;
using Libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class StudentRepository : ClassRoot, iStudentRepository
    {
        // 직접 쿼리문 작성한 Add 함수, 프로시저 호출 함수
        //public int Add(StudentModel model, IDbTransaction transaction = null)
        //{
        //    StringBuilder qry = new StringBuilder();
        //    qry.Append($" INSERT INTO TB_Student (StudentName, Address)");
        //    qry.Append($" VALUES ('{model.StudentName}', '{model.Address}');");
        //    qry.Append($" SELECT SCOPE_IDENTITY()");

        //    SqlCommand command = new SqlCommand(qry.ToString(), (SqlConnection)dbInstance.Connection);
        //    model.StudentId = int.Parse(command.ExecuteScalar().ToString());

        //    return model.StudentId;
        //}
        
      
        //public int Add(StudentModel model, IDbTransaction transaction = null)
        //{

        //    SqlCommand command = new SqlCommand("SP_Student_Add", (SqlConnection)dbInstance.Connection);
        //    command.CommandType = CommandType.StoredProcedure;

        //    SqlParameter[] sp = new SqlParameter[] {
        //        new SqlParameter("@StudentName", SqlDbType.VarChar, 50),
        //        new SqlParameter("@Address", SqlDbType.VarChar, 200)
        //    };

        //    sp[0].Value = model.StudentName;
        //    sp[1].Value = model.Address;

        //    foreach (var i in sp)
        //    {
        //        command.Parameters.Add(i);
        //    }

        //    model.StudentId = int.Parse(command.ExecuteScalar().ToString());

        //    return model.StudentId;
        //}
        public void Add(StudentModel model, IDbTransaction transaction = null)
        {
            //위에랑 다르게 DAPPER 사용 (ORM)
            string spName = "SP_Student_Add";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            parameters.Add("@StudentName", value: model.StudentName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Address", value: model.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            int newId = dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
            model.StudentId = parameters.Get<int>("@StudentId");
        }

        //public int Delete(int student_id, IDbTransaction transaction = null)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append($" DELETE FROM TB_Student WHERE StudentId = {student_id};");

        //    SqlCommand command = new SqlCommand(sql.ToString(), (SqlConnection)dbInstance.Connection);
        //    return command.ExecuteNonQuery();
        //}
        public int Delete(int student_id, IDbTransaction transaction = null)
        {
            string spName = "SP_Student_Delete";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: student_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        //public DataSet GetAll(IDbTransaction transaction = null)
        //{
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter();

        //    StringBuilder qry = new StringBuilder();
        //    qry.Append(" SELECT * FROM TB_Student;");

        //    da.SelectCommand = new SqlCommand(qry.ToString(), (SqlConnection)dbInstance.Connection);
        //    da.Fill(ds);

        //    return ds;
        //}

        //public List<StudentModel> GetAll(IDbTransaction transaction = null)
        //{
        //    StringBuilder qry = new StringBuilder();
        //    qry.Append(" SELECT StudentId, StudentName, Address");
        //    qry.Append(" FROM TB_Student ORDER BY StudentName;");

        //    SqlCommand command = new SqlCommand(qry.ToString(), (SqlConnection)dbInstance.Connection);
        //    SqlDataReader rd = command.ExecuteReader(CommandBehavior.CloseConnection);

        //    return GetStudentModel(rd);
        //}
        public List<StudentModel> GetAll(IDbTransaction transaction = null)
        {
            string spName = "SP_Student_GetAll";
            var parameters = new DynamicParameters();
            return dbInstance.Connection.Query<StudentModel>(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure).AsList();
        }

        public StudentModel GetById(int student_id, IDbTransaction transaction = null)
        {
            string spName = "SP_Student_GetById";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: student_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbInstance.Connection.Query<StudentModel>(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public int Update(StudentModel model, IDbTransaction transaction = null)
        {
            string spName = "SP_Student_Update";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: model.StudentId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@StudentName", value: model.StudentName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Address", value: model.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        public int UpdateName(int student_id, string student_name, IDbTransaction transaction = null)
        {
            string spName = "SP_Student_UpdateName";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: student_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@StudentName", value: student_name, dbType: DbType.String, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        private List<StudentModel> GetStudentModel(SqlDataReader rd)
        {
            List<StudentModel> studentLists = new List<StudentModel>();
            while (rd.Read())
            {
                StudentModel model = new StudentModel();
                model.StudentId = int.Parse(rd["StudentId"].ToString());
                model.StudentName = rd["StudentName"].ToString();
                model.Address = rd["Address"].ToString();
                studentLists.Add(model);
            }
            rd.Close();
            return studentLists;
        }
    }
}
