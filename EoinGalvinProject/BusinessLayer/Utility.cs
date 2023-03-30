using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantSystem.DataAccessLayer;
using RestaurantSystem.PresentationLayer;
using Oracle.ManagedDataAccess.Client;

namespace RestaurantSystem.BusinessLayer
{
    public class Utility{
        static ReservationDAO DAO = new ReservationDAOimpl();
        public static void populateAnyCbo(System.Windows.Forms.ComboBox comboBox, String sql, String displayMember){
            DataTable dtbl = DAO.getAnyCboData(sql);

            comboBox.DataSource = dtbl;
            comboBox.Enabled = true;
            comboBox.DisplayMember = displayMember;
        }
        public static DataTable returnTable(string query){
            return DAO.returnTable(query);
        }
    }
}
