﻿using AdoNetWindow.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface iStudentDsRepository
    {
        int Add(StudentModel model, IDbTransaction transaction = null);

        int Delete(int student_id, IDbTransaction transaction = null);

        int Update(StudentModel model, IDbTransaction transaction = null);

        StudentModel GetById(int student_model, IDbTransaction transaction = null);

        DataSet GetAll(IDbTransaction transaction = null);
    }
}
