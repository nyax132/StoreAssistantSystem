using System.Data.SQLite;
using System.Diagnostics;
using System.Text;

namespace StoreServerSystem.SQLLisner
{
    internal class SQLListener
    {
        //https://marunaka-blog.com/use-sqlite-sample/1025/　参考にさせていただきましたm(_ _)m

        //<通信構文>
        //[データベースの名前] [実行する処理の名前] [内容１]・・・ 
        //productmaster serachjan 004
        //productmaster insert 001 たばこ 300 250 5 1 5 2020年4月23日 1000:1:1
        //    ↑            ↑    
        //SQLDatas[0] SQLDatas[1]   [2]～

        /// <summary>
        /// 送られてきた情報から何のデータベースの処理情報なのかを確認、その後構文に合わせて処理を実行します。
        /// </summary>
        /// <param name="sqldata">通信構文</param>
        public static List<string> ParseDatabaseAction(string sqldata)
        {
            //送られてきた情報をスペースで区切ります。
            var SQLDatas = sqldata.Split(new string[] { " ", "　" }, StringSplitOptions.RemoveEmptyEntries);

            switch (SQLDatas[0])
            {
                case "productmaster":
                    Debug.WriteLine("ParseDatabaseAction => product");
                    return ProductMaster_ExecuteTableOperation(SQLDatas);

                case "ordermaster":
                    Debug.WriteLine("ParseDatabaseAction => order");
                    return OrderMaster_ExecuteTableOperation(SQLDatas);
            }

            return new List<string>();
        }

        /// <summary>
        /// OrderMasterテーブルの処理を実行します
        /// </summary>
        /// <param name="SQLDatas"></param>
        /// <returns></returns>
        private static List<string> OrderMaster_ExecuteTableOperation(string[] SQLDatas)
        {
            const string TableName = "ORDERMASTER";
            List<string> result = new();

            switch (SQLDatas[1])
            {
                case "insert":
                    Debug.WriteLine("OrderMaster_ExecuteTableOperation => insert");
                    Insert();
                    break;

                case "update":
                    Debug.WriteLine("OrderMaster_ExecuteTableOperation => update");
                    Update();
                    break;

                case "delete":
                    Debug.WriteLine("OrderMaster_ExecuteTableOperation => delete");
                    Delete();
                    break;

                case "serachjan":
                    Debug.WriteLine("OrderMaster_ExecuteTableOperation => serachjan");
                    SerachJAN();
                    break;

                case "createtable":
                    Debug.WriteLine("OrderMaster_ExecuteTableOperation => createtable");
                    CreateTable();
                    break;
            }
            return result;

            void Insert()
            {
                string q = $"INSERT INTO {TableName}   (JAN,QUANTITY,DETE,PERSON_NAME) VALUES (" +
                    $"{SQLDatas[2]},'{SQLDatas[3]}',{SQLDatas[4]},{SQLDatas[5]}')";
                result.Add(
                    ExecuteNonQuery(q));
            }

            void Update()
            {
                string q = $"UPDATE {TableName} SET QUANTITY = '{SQLDatas[3]}', DETE = '{SQLDatas[4]}', PERSON_NAME = '{SQLDatas[5]};";
                result.Add(
                    ExecuteNonQuery(q));
            }

            void Delete()
            {
                string q = $"DELETE FROM {TableName} WHERE JAN = '{SQLDatas[2]}'";
                result.Add(
                    ExecuteNonQuery(q));
            }

            void SerachJAN()
            {
                result = SerachJANData(int.Parse(SQLDatas[2]), TableName);
                if (result.Count == 0)
                {
                    result.Add("notfound");
                }
            }

            void CreateTable()
            {
                StringBuilder q = new();
                q.Clear();
                q.Append($"CREATE TABLE IF NOT EXISTS {TableName} (");
                q.Append(" JAN INTEGER NOT NULL"); //JAN
                q.Append(" ,QUANTITY INTEGER NOT NULL"); //発注数
                q.Append(" ,DETE TEXT NOT NULL"); //発注日
                q.Append(" ,PERSON_NAME TEXT NOT NULL"); //発注者名
                q.Append(" ,primary key (JAN)");
                q.Append(")");

                result.Add(
                    ExecuteNonQuery(q.ToString()));
            }
        }

        /// <summary>
        /// ProductMasterテーブルの処理を実行します
        /// </summary>
        /// <param name="SQLDatas"></param>
        private static List<string> ProductMaster_ExecuteTableOperation(string[] SQLDatas)
        {
            const string TableName = "PRODUCTMASTER";
            List<string> result = new();

            switch (SQLDatas[1])
            {
                case "insert":
                    Debug.WriteLine("ProductMaster_ExecuteTableOperation => insert");
                    Insert();
                    break;

                case "update":
                    Debug.WriteLine("ProductMaster_ExecuteTableOperation => update");
                    Update();
                    break;

                case "delete":
                    Debug.WriteLine("ProductMaster_ExecuteTableOperation => delete");
                    Delete();
                    break;

                case "serachjan":
                    Debug.WriteLine("ProductMaster_ExecuteTableOperation => serachjan");
                    SerachJAN();
                    break;

                case "createtable":
                    Debug.WriteLine("ProductMaster_ExecuteTableOperation => createtable");
                    CreateTable();
                    break;
            }
            return result;

            void Insert()
            {
                string q = $"INSERT INTO {TableName}   (JAN,NAME,ORDER_PRICE,PRICE,ORDER_MINIMUM,ORDER_PER_QUANTITY,STOCK,START_OF_HANDLING,LOCATION) VALUES (" +
                    $"{SQLDatas[2]},'{SQLDatas[3]}',{SQLDatas[4]},{SQLDatas[5]},{SQLDatas[6]},{SQLDatas[7]},{SQLDatas[8]},'{SQLDatas[9]}','{SQLDatas[10]}')";
                result.Add(
                    ExecuteNonQuery(q));
            }

            void Update()
            {
                string q = $"UPDATE {TableName} SET NAME = '{SQLDatas[3]}', ORDER_PRICE = '{SQLDatas[4]}', PRICE = '{SQLDatas[5]}', ORDER_MINIMUM = '{SQLDatas[6]}'" +
                    $", ORDER_PER_QUANTITY = '{SQLDatas[7]}', STOCK = '{SQLDatas[8]}', START_OF_HANDLING = '{SQLDatas[9]}', LOCATION = '{SQLDatas[10]}' WHERE JAN = {SQLDatas[2]};";
                result.Add(
                    ExecuteNonQuery(q));
            }

            void Delete()
            {
                string q = $"DELETE FROM {TableName} WHERE JAN = '{SQLDatas[2]}'";
                result.Add(
                    ExecuteNonQuery(q));
            }

            void SerachJAN()
            {
                result = SerachJANData(int.Parse(SQLDatas[2]), TableName);
                if (result.Count == 0)
                {
                    result.Add("notfound");
                }
            }

            void CreateTable()
            {
                StringBuilder q = new();
                q.Clear();
                q.Append($"CREATE TABLE IF NOT EXISTS {TableName} (");
                q.Append(" JAN INTEGER NOT NULL"); //JAN
                q.Append(" ,NAME TEXT NOT NULL"); //商品名
                q.Append(" ,ORDER_PRICE INTEGER NOT NULL"); //仕入れ値
                q.Append(" ,PRICE INTEGER NOT NULL"); //売価
                q.Append(" ,ORDER_MINIMUM INTEGER NOT NULL"); //最低発注数
                q.Append(" ,ORDER_PER_QUANTITY INTEGER NOT NULL"); //発注数あたり
                q.Append(" ,STOCK INTEGER NOT NULL"); //在庫数
                q.Append(" ,START_OF_HANDLING TEXT NOT NULL"); //取り扱い開始日
                q.Append(" ,LOCATION TEXT NOT NULL"); //ゴンドラ
                q.Append(" ,primary key (JAN)");
                q.Append(")");

                result.Add(
                    ExecuteNonQuery(q.ToString()));
            }
        }

        /// <summary>
        /// SQLに送信します。戻り値はSUCCESSかUNSUCCESSです。
        /// </summary>
        /// <param name="query"></param>
        private static string ExecuteNonQuery(string query)
        {
            try
            {
                // 接続先を指定
                using (var conn = new SQLiteConnection("Data Source=" + Program.DataBaseName + ".sqlite"))
                using (var command = conn.CreateCommand())
                {
                    // 接続
                    conn.Open();

                    // コマンドの実行処理
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                //例外が発生した時はメッセージボックスを表示
                MessageBox.Show(ex.Message, "SQLListener");
                return "UNSUCCESS";
            }
        }

        /// <summary>
        /// JANから情報を検索します。戻り値は情報がスペースで区切られて出てきます。
        /// </summary>
        /// <param name="jan"></param>
        /// <param name="tablename"></param>
        /// <returns></returns>
        private static List<string> SerachJANData(int jan, string tablename)
        {
            // 検索条件
            var query = "SELECT * FROM " + tablename + " WHERE JAN = " + jan;

            var Serachresult = new List<string>();
            // 接続先を指定
            using (var conn = new SQLiteConnection("Data Source=" + Program.DataBaseName + ".sqlite"))
            using (var command = conn.CreateCommand())
            {
                // 接続
                conn.Open();

                // コマンドの実行処理
                command.CommandText = query;
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var array = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            array[i] = reader.GetValue(i).ToString();
                        }
                        Serachresult.AddRange(array);
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return Serachresult;
        }
    }
}
