using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector;


namespace Interface
{
    class Connection
    {
        public static MySqlConnection con = null;
        static MySqlCommand cmd = null;

        public static void Connect(string dbname, string server = "127.0.0.1", string user = "root", string password = "NIKE1999")
        {

            //con = new MySqlConnection();
            //cmd = new MySqlCommand();
            //cmd.ExecuteReader();//
            if (con == null)
            {
                con = new MySqlConnection("server=" + server + ";user id=" + user + ";database=" + dbname + ";password="+ password);
                cmd = new MySqlCommand();
            }
            if (con.State.ToString() == "Closed")
            {
                con.Open();
                cmd.Connection = con;
            }



        }

        public static int IUD(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteNonQuery();


        }

        public static MySqlDataReader Select(string req)
        {

            cmd.CommandText = req;
            return cmd.ExecuteReader();




        }

        public static List<dynamic> Get_champs(string table)
        {
            int i;
            List<dynamic> list;
            string sql = "select * from " + table;
            list = new List<dynamic>();
            cmd = new MySqlCommand(sql, Connection.con);
            cmd.CommandText = sql;
            MySqlDataReader rd = cmd.ExecuteReader();


            for (i = 0; i < rd.FieldCount; i++)
            {
                list.Add(rd.GetName(i));
            }

            rd.Close();

            return list;
        }

        static public List<Dictionary<string, Object>> Get(string sql)
        {
            List<Dictionary<string, Object>> list = new List<Dictionary<string, Object>>();
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Dictionary<string, Object> _data = new Dictionary<string, Object>();
                for (int i = 0; i < (dr.FieldCount); i++)
                {
                    _data.Add(dr.GetName(i), dr[i].ToString());
                }

                list.Add(_data);
            }
            dr.Close();
            return list;
        }
    }
    }
