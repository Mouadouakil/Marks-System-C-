using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;


namespace Interface
{
    class model
    {
        public int id = 0;
        private string sql = "";
        public static Dictionary<string, T> ToDictionary<T>(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dico = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
            return dico;
        }
        private dynamic DictionaryToObject(Dictionary<String, object> dico)
        {
            return dico.Aggregate(new ExpandoObject() as IDictionary<string, Object>, (a, p) => { a.Add(p.Key, p.Value); return a; });
        }


        public int save()
        {
            Dictionary<string, dynamic> dico = new Dictionary<string, dynamic>();
            dico = ToDictionary<dynamic>(this);
            string request = "";
            List<dynamic> l = Connection.Get_champs(this.GetType().Name);
            if (id == 0)
            {

                request += "insert into " + this.GetType().Name + " values(";
                int j = 0;
                foreach (KeyValuePair<string, dynamic> kvp in dico)
                {
                    j++;
                    if (kvp.Value is string)
                    {
                        request += " '" + kvp.Value + "' ";
                    }
                    else
                    {
                        request += " " + kvp.Value + " ";
                    }

                    if (j < dico.Count)
                    {
                        request += " , ";
                    }
                }
                request += ");";
                Console.WriteLine(request);
            }
            if (id != 0)
            {
                request = "update " + this.GetType().Name + " set ";
                int i = 0;
                foreach (KeyValuePair<string, dynamic> kvp in dico)
                {
                    i++;

                    if (kvp.Value is string)
                    {
                        request += " " + kvp.Key + "='" + kvp.Value + "' ";
                    }
                    else
                    {
                        request += " " + kvp.Key + "=" + kvp.Value + " ";
                    }

                    if (i < dico.Count)
                    {
                        request += " , ";
                    }
                }

                request += " where  id =" + id;

            }
            Connection.IUD(request);
            return 0;

        }
        public List<Dictionary<string, Object>> All()
        {
            int i;
            List<Dictionary<string, Object>> LE = new List<Dictionary<string, Object>>();

            Dictionary<string, Object> dic;
            string request = "";
            //List<string> l = Connexion.Get_champs(this.GetType().Name);
            request += "select * from " + this.GetType().Name;
            MySqlDataReader rd = Connection.Select(request);

            while (rd.Read())
            {
                dic = new Dictionary<string, Object>();
                for (i = 0; i < rd.FieldCount; i++)
                {
                    dic.Add(rd.GetName(i), rd.GetValue(i).ToString());
                }
                LE.Add(dic);
                dic = null;
            }
            rd.Close();
            return LE;
        }
        public List<Dictionary<string, Object>> Select(Dictionary<string, Object> criteres)
        {
            string request = "select * from " + this.GetType().Name;
            if (criteres.Count != 0)
            {
                request += " where ";
                int i = 0;
                foreach (KeyValuePair<string, Object> kvp in criteres)
                {
                    i++;
                    request += " " + kvp.Key + "='" + kvp.Value + "' ";
                    if (i < criteres.Count)
                    {
                        request += " and ";
                    }
                }
            }

            List<Dictionary<string, Object>> _data = new List<Dictionary<string, Object>>();
            _data = Connection.Get(request);
            return _data;
        }



        public void Delete(Dictionary<string, Object> criteres)
        {
            string request = "delete from " + this.GetType().Name;
            if (criteres.Count != 0)
            {
                request += " where ";
                int i = 0;
                foreach (KeyValuePair<string, Object> kvp in criteres)
                {
                    i++;
                    request += " " + kvp.Key + "='" + kvp.Value + "' ";
                    if (i < criteres.Count)
                    {
                        request += " and ";
                    }
                }
                int a = Connection.IUD(request);
                Console.WriteLine(a);
            }

        
            
        }



        public Dictionary<string, Object> find()
        {

            Dictionary<string, Object> ch = new Dictionary<string, Object>();
            sql = "select * from " + this.GetType().Name + " where id=" + id;
            MySqlDataReader rd = Connection.Select(sql);
            while (rd.Read())
            {
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    ch.Add(rd.GetName(i), rd.GetValue(i).ToString());
                }
            }
            rd.Close();
            return ch;
        }
    }
}
