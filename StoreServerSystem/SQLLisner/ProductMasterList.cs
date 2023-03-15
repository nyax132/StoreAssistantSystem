using System.Data.SQLite;
using System.Text;

namespace StoreServerSystem.SQLLisner
{
    internal class ProductMasterList
    {
        public static void DeleteTable()
        {

        }
        public static void ResetTable()
        {

        }

        /// <summary>
        /// デーブル"ProductMaster"がない場合は作成します。
        /// </summary>
        public static void CreateTable()
        {
            StringBuilder query = new();
            query.Clear();
            query.Append("CREATE TABLE IF NOT EXISTS PRODUCTMASTER (");
            query.Append(" JAN INTEGER NOT NULL"); //JAN
            query.Append(" ,NAME TEXT NOT NULL"); //商品名
            query.Append(" ,ORDER_PRICE INTEGER NOT NULL"); //仕入れ値
            query.Append(" ,PRICE INTEGER NOT NULL"); //売価
            query.Append(" ,ORDER_MINIMUM INTEGER NOT NULL"); //最低発注数
            query.Append(" ,ORDER_PER_QUANTITY INTEGER NOT NULL"); //発注数あたり
            query.Append(" ,STOCK INTEGER NOT NULL"); //在庫数
            query.Append(" ,START_OF_HANDLING TEXT NOT NULL"); //取り扱い開始日
            query.Append(" ,LOCATION TEXT NOT NULL"); //ゴンドラ
            query.Append(" ,primary key (JAN)");
            query.Append(")");

            // クエリー実行
            ExecuteNonQuery(query.ToString());
        }
        public static List<string> SerachJANData(int jan)
        {
            // 検索条件
            var query = "SELECT * FROM PRODUCTMASTER WHERE JAN = " + jan;

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
                        var array = new string[]
                        {
                            reader.GetValue(0).ToString(),
                            reader.GetValue(1).ToString(),
                            reader.GetValue(2).ToString(),
                            reader.GetValue(3).ToString(),
                            reader.GetValue(4).ToString(),
                            reader.GetValue(5).ToString(),
                            reader.GetValue(6).ToString(),
                            reader.GetValue(7).ToString(),
                            reader.GetValue(8).ToString()
                        };
                        result.AddRange(array);
                    }
                    reader.Close();
                }
                conn.Close();
            }

            return result;
        }
        public static void InsertRecord(int jan, string name, int orderprice, int price,
                                int orderminimum, int orderperquantity, int stock, string startofhandling, string location)
        {
            // レコードの登録
            var query = "INSERT INTO PRODUCTMASTER   (JAN,NAME,ORDER_PRICE,PRICE,ORDER_MINIMUM,ORDER_PER_QUANTITY,STOCK,START_OF_HANDLING,LOCATION) VALUES (" +
                $"{jan},'{name}',{orderprice},{price},{orderminimum},{orderperquantity},{stock},'{startofhandling}','{location}')";

            // クエリー実行
            ExecuteNonQuery(query.ToString());
        }
        private static void ExecuteNonQuery(string query)
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
                    //var value = command.ExecuteNonQuery();
                    //MessageBox.Show($"更新されたレコード数は {value} です。");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //例外が発生した時はメッセージボックスを表示
                MessageBox.Show(ex.Message);
            }
        }
    }
}
