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
        public int GetByUserLogin(Customer customer)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Name", customer.Name, DbType.String);
                param.Add("@Dob", customer.Dob, DbType.Date);               
                param.Add("@Age", customer.Age, DbType.Int32);
                param.Add("@Job", customer.Job, DbType.String);
                param.Add("@PayMoney", customer.PayMoney, DbType.Int32);
                param.Add("@Duration", customer.Duration, DbType.Int32);
                param.Add("@PayDuration", customer.PayDuration, DbType.Int32);
                param.Add("@TaxPerYear", customer.TaxPerYear, DbType.Int32);

                var enumResult = DapperHelper.Execute("insurance_AddNewCustomer @Name,@Dob,@Age,@Job,@PayMoney,@Duration,@PayDuration,@TaxPerYear", userLogin: "asdasdasda", param);
                return enumResult;
            }
            catch (Exception ex)
            {
                // ghi log
                throw ex;
            }
        }
    }
}