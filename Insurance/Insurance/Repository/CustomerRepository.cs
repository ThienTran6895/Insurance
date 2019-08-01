using Dapper;
using Insurance.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Insurance.Repository
{
    public class CustomerRepository
    {
        public void GetByUserLogin(Customer customer)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Name", customer.Name, DbType.String);
                param.Add("@Job", customer.Job, DbType.String);
                param.Add("@Money", customer.Money, DbType.String);
                param.Add("@Age", customer.Age, DbType.Int32);
                param.Add("@Money", customer.Money, DbType.String);
                var enumResult = DapperHelper.Execute("HR_Employees_GetByUserLogin", param);               
            }
            catch (Exception ex)
            {
                // ghi log
                throw ex;
            }
        }
    }
}