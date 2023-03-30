using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer
{
    public class ReservationDAOimpl : ReservationDAO
    {
        public void addReservationToDB(int resId, DateTime resDate, int stationNo, String custName, int sitting, String custNum, int seatingRequired)
        {
            String commandText = "INSERT INTO RESERVATIONS VALUES (:resID,:resDate,:resStationNo,:custName,:resSitting,:custNum,0,'N')";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand command = new OracleCommand(commandText, conn))
            {
                command.Parameters.Add("resID", resId);
                command.Parameters.Add("resDate", resDate.Date);
                command.Parameters.Add("resStationNo", stationNo);
                command.Parameters.Add("custName", custName);
                command.Parameters.Add("resSitting", sitting);
                command.Parameters.Add("custNum", custNum);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
        public void deleteFromDatabase(int resId)
        {
            String deleteQuery = "DELETE FROM RESERVATIONS WHERE RESID = :resid";
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(deleteQuery, conn);
            cmd.Parameters.Add("resid", resId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void checkIntoSystem(int resID)
        {
            String sqlQuery = "UPDATE RESERVATIONS SET ACTIVE = 'Y' WHERE RESID = :resID";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("resID", resID);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public void checkOutSystem(float cost, int resID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand cmd = new OracleCommand("UPDATE RESERVATIONS SET ACTIVE = 'C',cost = :cost WHERE resID = :resID", conn))
            {
                cmd.Parameters.Add("cost", OracleDbType.Decimal, cost, ParameterDirection.Input);
                cmd.Parameters.Add("resID", OracleDbType.Int32, resID, ParameterDirection.Input);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public DataTable reservationSearch(string custName)
        {
            String custNameEntered = custName;
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand("SELECT * FROM RESERVATIONS WHERE CUSTNAME = :custName and ACTIVE = 'N'", conn);
                cmd.BindByName = true;
                cmd.Parameters.Add("custname", OracleDbType.Char, custNameEntered, ParameterDirection.Input);

                OracleDataAdapter oracleDA = new OracleDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                oracleDA.Fill(dtbl);
                conn.Close();
                return dtbl;
            }
        }

        public DataTable fillResIDCboOnSearch(string custName)
        {
            string custNameString = custName;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand("SELECT RESID FROM RESERVATIONS WHERE CUSTNAME = :custname and ACTIVE = 'N' ORDER BY RESID", conn);
            cmd.Parameters.Add("custnameString", OracleDbType.Char, custName, ParameterDirection.Input);

            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            oda.Fill(dtbl);
            conn.Close();

            return dtbl;
        }

        public int getNextResID()
        {
            int nextResID = 0;
            String StrSQL = "SELECT MAX(RESID) FROM RESERVATIONS";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(StrSQL, conn);
            conn.Open();

            object result = cmd.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            nextResID = Convert.ToInt32(result) + 1;

            conn.Close();

            return nextResID;
        }

        public DataTable getRevenueData(int givenYear)
        {
            String strSQL = "SELECT to_Char(resdate,'MM') AS MONTH, SUM(COST) AS TOTAL from reservations WHERE to_Char(resdate,'YY') = :year GROUP BY to_Char(resdate, 'MM') ORDER BY MONTH";

            DataTable dtbl = new DataTable();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.Parameters.Add("year", givenYear);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dtbl);
            conn.Close();
            return dtbl;
        }

        public DataTable returnTable(string query)
        {
            String oracleQuery = query;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(oracleQuery, conn);
            OracleDataAdapter oracleDA = new OracleDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            oracleDA.Fill(dtbl);
            return dtbl;
        }

        public DataTable getAnyCboData(string sql)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);
            OracleDataAdapter oracleDA = new OracleDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            oracleDA.Fill(dtbl);
            return dtbl;
        }
    }
}
