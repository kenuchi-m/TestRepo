using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KLib2;
using System.Data.OleDb;

namespace MediaPreviewer
{
    //public class Test
    //{
    //}
    public static class Test
    {
        public static void TestDbRead()
        {
            Log.t("ログテスト");

            using (var conn = new OleDbConnection())
            {

                //                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WORK\開発\VSCommunity2022\MediaManager\bin\Debug\Database.accdb";
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb";
                conn.Open();

                using (var cmd = new OleDbCommand("SELECT ID, Field1 FROM Table1", conn))
                {
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int ID;
                        string sField1;

                        //                        ID = reader.GetInt32(0);
                        //                        sField1 = reader.GetString(1);
                        ID = (int)reader["ID"];
                        sField1 = reader["Field1"].ToString();
                        //                        ID = (int)reader[0];
                        //                        sField1 = reader[1].ToString();

                        Log.t("ID={0}: Field1=[{1}]", ID, sField1);
                    }
                }

            }

            Log.t("処理正常終了");
        }

        public static void TestDbWrite()
        {
            Log.t("データベース書込みテスト");

            using (var conn = new OleDbConnection())
            {

                //                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WORK\開発\VSCommunity2022\MediaManager\bin\Debug\Database.accdb";
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb";
                conn.Open();

                using (var cmd = new OleDbCommand("UPDATE Table1 SET Field1='Write Data' WHERE ID=1", conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }

            Log.t("処理正常終了");
        }

        public class TPerson
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void TestLinq()
        {
            Log.t("Linqのテスト");

            var aPersons = new List<TPerson>();

            TPerson person;
            for (int i = 0; i < 10; i++)
            {
                person = new TPerson();
                person.Name = String.Format("Name{0}", i);
                person.Age = 20 - i;

                aPersons.Add(person);
            }

            // var aOuts = aPersons.Select(x => x);
            // var aOuts = aPersons.OrderBy(x => x.Age).Select(x => x);
            var aOuts = aPersons.Where(x => x.Age > 15).OrderBy(x => x.Age).Select(x => x);

            int j = 0;
            foreach (TPerson pe in aOuts)
            {
                Log.t("Person[{0}]: Name=[{1}]: Age={2}", j, pe.Name, pe.Age);

                j++;
            }
        }
    }
}

