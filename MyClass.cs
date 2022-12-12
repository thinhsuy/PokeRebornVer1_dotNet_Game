using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PokeWar
{
    class DBSQLServer
    {
        public static SqlConnection
            GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
    class DBC
    {
        public static SqlConnection GetConnectByString(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
        //hàm trả về biến SqlConnection với database cho trước
        public static SqlConnection GetConnect(string database)
        {
            string datasource = @"DESKTOP-2T77F44\SQLEXPRESS";
            string username = "sa";
            string password = "Knife513755";
            return DBSQLServer.GetDBConnection(datasource, database, username, password);
        }

        //Hàm trả về true nếu mở DB thành công
        public static bool OpenDB(SqlConnection conn)
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }

        //Hàm đóng db
        public static void CloseDB(SqlConnection conn) { conn.Close(); }

        //Hàm trả về chuỗi các ký tự có trong 1 bảng thông qua lệnh select
        public static string ReadInforFromDB(string SQL, SqlConnection conn, int col)
        {
            SqlCommand command = new SqlCommand(SQL, conn);
            command.CommandType = CommandType.Text;
            SqlDataReader read = command.ExecuteReader(); //create read variable, only created after connect to server
            string str = "";
            while (read.Read())
            {
                for (int i = 0; i < col; i++) { str += read.GetValue(i) + "\n"; }
            }
            read.Close();
            command.Dispose();
            return str;
        }

        //Hàm trả về dataset thông qua lệnh select
        public static DataSet SelectDataSet(string SQL, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, conn);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }


        //Hàm trả về số lượng row bị ảnh hưởng bởi lệnh insert, delete, update
        public static int GetAffectiveRows(string SQL, SqlConnection conn, string type)
        {
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapt = new SqlDataAdapter();
            int result = 0;
            if (type == "insert")
            {
                adapt.InsertCommand = cmd;
                result = adapt.InsertCommand.ExecuteNonQuery();
            }
            else if (type == "delete")
            {
                adapt.DeleteCommand = cmd;
                result = adapt.DeleteCommand.ExecuteNonQuery();
            }
            else if (type == "update")
            {
                adapt.UpdateCommand = cmd;
                result = adapt.UpdateCommand.ExecuteNonQuery();
            }
            cmd.Dispose();
            return result;
        }

        //Hàm lấy về các đơn giá trị SQL count(), sum(), max(),...
        //Nếu là int hay float, dùng int.Parse() hay float.Parse() để convert 
        public static string GetValueReturn(string SQL, SqlConnection conn)
        {
            string str = "";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                str += read.GetValue(0);
                break;
            }
            read.Close();
            cmd.Dispose();
            return str;
        }

        //hàm để khử khoản trống trong chuỗi
        public static string ClearString(string target)
        {
            string str = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != ' ') str += target[i];
            }
            return str;
        }

        //hàm để nối dài đoạn SQL với điều kiện thêm trong list 
        //args=> (list, sql, name of column, or/and)
        public static string expandSQL(List<string> list, string str, string responName, string expression)
        {
            str += " (";
            for (int i = 0; i < list.Count; i++)
            {
                str += responName + " = '" + DBC.ClearString(list[i]) + "'";
                if (i != list.Count - 1) { str += " " + expression + " "; }
            }
            str += ")";
            return str;
        }

        //Hàm để catch exception của SQL
        public static string CatchSqlExeption(SqlException ex)
        {
            string errorMess = "";
            for (int i = 0; i < ex.Errors.Count; i++)
            {
                errorMess += "Index #" + i + "\n" +
                "Message: " + ex.Errors[i].Message + "\n" +
                "Error Number: " + ex.Errors[i].Number + "\n" +
                "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                "Source: " + ex.Errors[i].Source + "\n" +
                "Procedure: " + ex.Errors[i].Procedure + "\n";
            }
            return errorMess;
        }


        //Thực thi Stored Procedurem, args => (tên proc, connection, danh sách tham biến)
        //Tao SqlParameter roi dung list add vao

        /*
         
         create proc Dosomething(@text varchar(10), @a int)
         as
           print @text
        go

        ------------------------------

        List<SqlParameter> paralist = new List<SqlParameter>();

        SqlParameter para1 = new SqlParameter(){
            ParameterName = '@text',
            SqlDbType = SqlDbType.varchar,
            value = 'Hello world',
            Direction = ParameterDirection.Input
        };

        SqlParameter para2 = new SqlParameter(){
            ParameterName = '@a',
            SqlDbType = SqlDbType.int,
            value = 1
            Direction = ParameterDirection.Input
        };

        paraList.Add(para1);
        paraList.Add(para2);


        DBC.ProcessProc('Insert', conn, paralist);
         
         */
        public static void ProcessProc(string ProcName, SqlConnection conn, List<SqlParameter> paraList)
        {
            SqlCommand cmd = new SqlCommand()
            {
                CommandText = ProcName,
                CommandType = CommandType.StoredProcedure,
                Connection = conn
            };
            if (paraList.Count != 0)
            {
                foreach (SqlParameter para in paraList) cmd.Parameters.Add(para);
            }

            cmd.ExecuteNonQuery();
        }
    }
}