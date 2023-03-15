using System.Data.SQLite;
using System.Text;

namespace StoreServerSystem.SQLLisner
{
    internal class ProductMasterQueryCreate
    {
        //https://marunaka-blog.com/use-sqlite-sample/1025/　参考にさせていただきました

        public static void ResetTable()
        {

        }

        /// <summary>
        /// デーブル"ProductMaster"がない場合は作成します。
        /// </summary>
        public static string CreateTable()
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

            // クエリーを返す
            return query.ToString();
        }
        public static string InsertRecord(int jan, string name, int orderprice, int price, int orderminimum, int orderperquantity, int stock, string startofhandling, string location)
        {
            // レコードの登録
            string query = "INSERT INTO PRODUCTMASTER   (JAN,NAME,ORDER_PRICE,PRICE,ORDER_MINIMUM,ORDER_PER_QUANTITY,STOCK,START_OF_HANDLING,LOCATION) VALUES (" +
                $"{jan},'{name}',{orderprice},{price},{orderminimum},{orderperquantity},{stock},'{startofhandling}','{location}')";

            // クエリーを返す
            return query;
        }
    }
}
