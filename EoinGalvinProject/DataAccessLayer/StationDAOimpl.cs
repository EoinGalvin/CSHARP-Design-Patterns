using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer
{
    public class StationDAOimpl : StationDAO
    {
        public void addStationToDB(int stationNo, int stationCapacity, char stationType, char stationStatus)
        {
            String sql = "INSERT INTO STATIONS VALUES (:stationNo,:stationCapacity,:stationType,:stationStatus)";

            using (OracleConnection connection = new OracleConnection(DBConnect.oradb))
            using (OracleCommand command = new OracleCommand(sql, connection))
            {
                command.Parameters.Add("stationNo", stationNo);
                command.Parameters.Add("stationCapacity", stationCapacity);
                command.Parameters.Add("stationType", stationType);
                command.Parameters.Add("stationStatus", stationStatus);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
        public void updateStation(int stationNo, int stationCapacity, char stationType, char stationStatus)
        {
            String updateQuery = "UPDATE STATIONS SET STATIONCAPACITY = :stationCap, STATIONTYPE = :stationType, STATIONSTATUS = :stationStatus WHERE STATIONNO = :stationNo";

            using (OracleConnection connection = new OracleConnection(DBConnect.oradb))
            using (OracleCommand command = new OracleCommand(updateQuery, connection))
            {
                command.Parameters.Add(":stationCap", stationCapacity);
                command.Parameters.Add(":stationType", stationType);
                command.Parameters.Add(":stationStatus", stationStatus);
                command.Parameters.Add(":stationNo", stationNo);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
        public void deleteStation(int stationNo)
        {
            String deleteQuery = "DELETE FROM STATIONS WHERE STATIONNO = :stationNo";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand command = new OracleCommand(deleteQuery, conn))
            {
                command.Parameters.Add("stationNo", stationNo);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public int getNextStationId()
        {
            int nextStationNo = 0;
            String strSQL = "SELECT MAX(stationNo) FROM stations";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            nextStationNo = Convert.ToInt32(result) + 1;

            conn.Close();
            return nextStationNo;
        }

        public DataTable loadStationsNoFutureRes()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();
                OracleDataAdapter oracleDA = new OracleDataAdapter("SELECT * FROM STATIONS WHERE STATIONNO NOT IN (SELECT STATIONNO FROM RESERVATIONS WHERE resdate >= sysdate) ORDER BY STATIONNO", conn);
                DataTable dtbl = new DataTable();
                oracleDA.Fill(dtbl);
                return dtbl;
            }
        }

        public DataTable returnCheckAvailTable(int stationNo, int sitting, string resDateAsString)
        {
            String query = "SELECT * FROM RESERVATIONS WHERE STATIONNO = :stationNo AND SITTING = :sitting AND RESDATE LIKE :resDate";

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                conn.Open();
                cmd.BindByName = true;
                cmd.Parameters.Add("stationNo", stationNo);
                cmd.Parameters.Add("sitting", sitting);
                cmd.Parameters.Add("resDate", resDateAsString);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dtbl = new DataTable();

                da.Fill(dtbl);
                conn.Close();

                return dtbl;
            }
        }

        public DataTable getAvailableStations(DateTime resDate, int sitting, int stationCapacity, bool includeCapacity)
        {
            String sql = "";
            if (includeCapacity == true) { sql = "SELECT * FROM STATIONS WHERE STATIONNO NOT IN (SELECT STATIONNO FROM RESERVATIONS WHERE RESDATE = :resDate AND SITTING = :sitting) ORDER BY STATIONNO"; }
            if (includeCapacity == false) { sql = "SELECT * FROM STATIONS WHERE STATIONCAPACITY = :stationCapacity AND STATIONNO NOT IN (SELECT STATIONNO FROM RESERVATIONS WHERE RESDATE = :resDate AND SITTING = :sitting) ORDER BY STATIONNO"; }


            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.BindByName = true;
                cmd.Parameters.Add("stationCapacity", stationCapacity);
                cmd.Parameters.Add("resDate", resDate.Date);
                cmd.Parameters.Add("sitting", sitting);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                conn.Close();

                return dtbl;
            }
        }

        public DataTable getStationNoCboNotBkd(int stationCapacity, DateTime resDate, char sitting)
        {
            String sql = "SELECT STATIONNO FROM STATIONS WHERE STATIONCAPACITY = :stationCapacity AND STATIONNO NOT IN(SELECT STATIONNO FROM RESERVATIONS WHERE RESDATE = :resDate AND SITTING = :sitting) ORDER BY STATIONNO";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.BindByName = true;
            cmd.Parameters.Add("stationCapacity", stationCapacity);
            cmd.Parameters.Add("resDate", resDate.Date);
            cmd.Parameters.Add("sitting", sitting);

            OracleDataAdapter oracleDa = new OracleDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            oracleDa.Fill(dtbl);

            return dtbl;
        }
    }

}
