using System;
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
            int? milage, int? ownerCount, int? askPrice, int? year)
        {
            return ExecQuery($"EXEC Demo.CarSearch " +
                $"@Make={HandlePossibleEmptyString(make)}, " +
                $"@Model={HandlePossibleEmptyString(model)}, " +
                $"@Year={HandleNullableInt(year)}, " +
                $"@Color={HandlePossibleEmptyString(color)}, " +
                $"@Milage={HandleNullableInt(milage)}, " +
                $"@OwnerCnt={HandleNullableInt(ownerCount)}, " +
                $"@AskPrice={HandleNullableInt(askPrice)}");
        }
        public DataSet CarWithFeature(List<string> featureIDs)
        {
            string qString = $"EXEC Demo.CarWithFeature";
            int i = 1;
            foreach (string id in featureIDs)
            {
                qString += $" @Feature{i} = {id},";
                i++;
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
        public DataSet GetCustomerInformation(int? customerId, string first, string last)
        { 
            return ExecQuery($"EXEC Demo.GetCustomerInformation " +
                $"@CustomerId={HandleNullableInt(customerId)}, " +
                $"@FirstName='%{first}%', " +
                $"@LastName='%{last}%'");
        }
        public DataSet GetCustomerPurchase(int customerId)
        {
            return ExecQuery($"EXEC Demo.GetCustomerPurchase @CustomerId={customerId}");
        }
        public DataSet GetMakeTypes()
        {
            return ExecQuery($"EXEC Demo.GetMakeTypes");
        }
        public DataSet GetStockTotalValue()
        {
            return ExecQuery($"EXEC Demo.GetStockTotalValue");
        }
        public DataSet GetTopEmployees(int employeeNumber, int dealership)
        {
            return ExecQuery($"EXEC Demo.GetTopEmployees @EmployeeNumber={employeeNumber}, @DealershipId={dealership}");
        }
        public DataSet ListEmployee(int? customerId, string firstName, string lastName)
        {
            return ExecQuery($"EXEC Demo.ListEmployee " +
                $"@EmployeeId={HandleNullableInt(customerId)}," +
                $"@FirstName='%{firstName}%', " + 
                $"@LastName='%{lastName}%'");
        }
        public DataSet ListFeature()
        {
            return ExecQuery($"EXEC Demo.ListFeature");
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

            if( dataSet.Tables[0].Rows.Count == 0 )
            {
                dataSet = null;
            }

            return dataSet;
        }
        public DataSet MakePurchase(string employeeEmail, string customerEmail, int carID, int purchaseAmount)
        {
            return ExecQuery($"EXEC Demo.MakePurchase " +
                $"@EmployeeEmail='{employeeEmail}', " +
                $"@CustomerEmail='{customerEmail}', " +
                $"@SalePrice={purchaseAmount.ToString()}, " +
                $"@CarId={carID.ToString()}");
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
