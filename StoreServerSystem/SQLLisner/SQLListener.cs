using System.Data.SQLite;
using System.Diagnostics;

namespace StoreServerSystem.SQLLisner
{
    internal class SQLListener
    {
        //<通信構文>
        //[データベースの名前] [実行する処理の名前] [内容１] ～
        //productmaster serachjan 004
        //productmaster insert 001 たばこ 300 250 5 1 5 2020年4月23日 1000:1:1

        /// <summary>
        /// 送られてきた情報から何のデータベースの処理情報なのかを確認
        /// </summary>
        /// <param name="sqldata">通信構文</param>
        public static List<string> ParseDatabaseAction(string sqldata)
        {
            //送られてきた情報をスペースで区切ります。
            var SQLDatas = sqldata.Split(new string[] { " ", "　" }, StringSplitOptions.RemoveEmptyEntries);

            switch (SQLDatas[0])
            {
                case "productmaster":
                    Debug.WriteLine("Classifi => product");
                    return ProductMasterExecuteTableOperation(SQLDatas);

                case "ordermaster":
                    Debug.WriteLine("Classifi => order");
                    return OrderMasterExecuteTableOperation(SQLDatas);
            }

            return new List<string>();
        }

        /// <summary>
        /// OrderMasterテーブルの処理を実行します
        /// </summary>
        /// <param name="SQLDatas"></param>
        /// <returns></returns>
        private static List<string> OrderMasterExecuteTableOperation(string[] SQLDatas)
        {
            List<string> result = new();
            return result;
        }

        /// <summary>
        /// ProductMasterテーブルの処理を実行します
        /// </summary>
        /// <param name="SQLDatas"></param>
        private static List<string> ProductMasterExecuteTableOperation(string[] SQLDatas)
        {
            List<string> result = new();

            switch (SQLDatas[1])
            {
                case "insert":
                    Debug.WriteLine("ProductMasterExecuteTableOperation => insert");
                    Insert();
                    break;

                case "serachjan":
                    Debug.WriteLine("ProductMasterExecuteTableOperation => serachjan");
                    SerachJAN();
                    break;

                case "createtable":
                    Debug.WriteLine("ProductMasterExecuteTableOperation => createtable");
                    CreateTable();
                    break;
            }
            return result;

            void Insert()
            {
                string q = ProductMasterQueryCreate.InsertRecord(int.Parse(SQLDatas[2]), SQLDatas[3], int.Parse(SQLDatas[4]), int.Parse(SQLDatas[5]),
                                int.Parse(SQLDatas[6]), int.Parse(SQLDatas[7]), int.Parse(SQLDatas[8]), SQLDatas[9], SQLDatas[10]);
                if (ExecuteNonQuery(q) == 0)
                {
                    result.Add("ProductMaster_INSERT_SUCCESS");
                }
                else
                {
                    result.Add("ProductMaster_INSERT_UNSUCCESS");
                }
            }

            void SerachJAN()
            {
                result = SerachJANData(int.Parse(SQLDatas[2]), "PRODUCTMASTER");
                Debug.WriteLine("SerachJAN => " + string.Join(" ", result));
                if (result.Count == 0)
                {
                    result.Add("notfound");
                }
            }

            void CreateTable()
            {
                string q = ProductMasterQueryCreate.CreateTable();
                ExecuteNonQuery(q);
                result.Add("ProductMaster_CREATETABLE_SUCCESS");
            }
        }

        /// <summary>
        /// SQLに送信します。戻り値は0か1です。
        /// </summary>
        /// <param name="query"></param>
        private static int ExecuteNonQuery(string query)
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
                return 0;
            }
            catch (Exception ex)
            {
                //例外が発生した時はメッセージボックスを表示
                MessageBox.Show(ex.Message);
                return 1;
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

            var result = new List<string>();
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
                        result.AddRange(array);
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return result;
        }
    }
}
