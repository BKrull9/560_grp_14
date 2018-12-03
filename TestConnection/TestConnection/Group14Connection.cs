﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace TestConnection
{
    class Group14Connection
    {
        SqlConnection conn;

        public Group14Connection()
        {
            string conn_str = @"Server=mssql.cs.ksu.edu;Database=cis560_team14;Integrated Security=SSPI;";
            conn = new SqlConnection(conn_str);
        }
        public DataSet CarInformation(int carID)
        {
            return ExecQuery($"EXEC Demo.CarInformation @CarId = {carID};");
        }
        public DataSet CarSearch(string make, string model, string color,
            int? milage, int? ownerCount, int? askPrice)
        {
            return ExecQuery($"EXEC Demo.CarSearch " +
                $"@Make={HandlePossibleEmptyString(make)}, " +
                $"@Model={HandlePossibleEmptyString(model)}, " +
                $"@Color={HandlePossibleEmptyString(color)}, " +
                $"@Milage={HandleNullableInt(milage)}, " +
                $"@OwnerCnt={HandleNullableInt(ownerCount)}, " +
                $"@AskPrice={HandleNullableInt(askPrice)}");
        }
        public DataSet CarWithFeature(int[] featureIDs)
        {
            string qString = $"EXEC Demo.CarWithFeature";
            foreach (int id in featureIDs)
            {
                qString += $" @Feature{id} = 1,";
            }
            // remove the last comma to avoid syntax error
            qString = qString.Substring(0, qString.Length - 1);
            return ExecQuery(qString);
        }
        public DataSet DealershipPerformance(int dealershipID,
            DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return ExecQuery($"EXEC Demo.DealershipPerformance " +
                $"@DealershipId={dealershipID}, " +
                $"@StartDate='{startDate.ToString()}', " +
                $"@EndDate='{endDate.ToString()}'");
        }
        public DataSet EmployeePerformance(int employeeID,
            DateTimeOffset startDate, DateTimeOffset endDate)
        {
            return ExecQuery($"EXEC Demo.EmployeePerformance " +
                $"@EmployeeId={employeeID}, " +
                $"@StartDate='{startDate.ToString()}', " +
                $"@EndDate='{endDate.ToString()}'");
        }
        public DataSet GetCarFeatures(int carId)
        {
            return ExecQuery($"EXEC Demo.GetCarFeatures @CarId={carId}");
        }
        public DataSet GetCustomerInformation(int customerId)
        {
            return ExecQuery($"EXEC Demo.GetCustomerInformation @customerId={customerId}");
        }
        public DataSet GetMakeTypes()
        {
            return ExecQuery($"EXEC Demo.GetMakeTypes");
        }
        public DataSet GetStockTotalValue()
        {
            return ExecQuery($"EXEC Demo.GetStockTotalValue");
        }
        public DataSet GetTopEmployees(int employeeNumber)
        {
            return ExecQuery($"EXEC Demo.GetTopEmployees @EmployeeNumber={employeeNumber}");
        }
        public DataSet ListEmployee()
        {
            return ExecQuery($"EXEC Demo.ListEmployee");
        }
        private DataSet ExecQuery(string sql)
        {
            DataSet dataSet = new DataSet();
            conn.Open();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn))
            {
                dataAdapter.Fill(dataSet);
            }

            conn.Close();
            return dataSet;
        }
        private string HandlePossibleEmptyString(string s)
        {
            if (s.Length > 0)
            {
                return s;
            } else {
                return "N'%'";
            }
        }
        private string HandleNullableInt(int? i)
        {
            if (i == null)
            {
                return "null";
            } else {
                return i.ToString();
            }
        }
    }
}