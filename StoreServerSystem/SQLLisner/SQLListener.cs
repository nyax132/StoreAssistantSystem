using System.Diagnostics;

namespace StoreServerSystem.SQLLisner
{
    internal class SQLListener
    {
        //<通信構文>
        //[データベースの名前] [実行する処理の名前] [内容１] ～
        //productmaster serachjan 004
        //productmaster insert 001 たばこ 300 250 5 1 5 2020年4月23日 1000:1:1

        private static List<string> result = new();

        /// <summary>
        /// 送られてきた情報から何のデータベースの処理情報なのかを確認
        /// </summary>
        /// <param name="sqldata">通信構文</param>
        public static List<string> Classification(string sqldata)
        {
            var SQLDatas = sqldata.Split(new string[] { " ", "　" }, StringSplitOptions.RemoveEmptyEntries);

            switch (SQLDatas[0])
            {
                case "productmaster":
                    Debug.WriteLine("Classifi => product");
                    ProductMasterSyntaxAnalysis(SQLDatas);
                    break;
                case "ordermaster":
                    Debug.WriteLine("Classifi => order");
                    break;
            }

            //TcpServerに結果を上げる
            return result;
        }

        /// <summary>
        /// ProductMasterデータベースの処理を実行します
        /// </summary>
        /// <param name="SQLDatas"></param>
        private static void ProductMasterSyntaxAnalysis(string[] SQLDatas)
        {
            switch (SQLDatas[1])
            {
                case "insert":
                    Debug.WriteLine("ProductMasterSyntaxAnalysis => insert");
                    Insert();
                    break;
                case "serachjan":
                    Debug.WriteLine("ProductMasterSyntaxAnalysis => serachjan");
                    SerachJAN();
                    break;
            }

            void Insert()
            {
                ProductMasterList.InsertRecord(int.Parse(SQLDatas[2]), SQLDatas[3], int.Parse(SQLDatas[4]), int.Parse(SQLDatas[5]),
                                int.Parse(SQLDatas[6]), int.Parse(SQLDatas[7]), int.Parse(SQLDatas[8]), SQLDatas[9], SQLDatas[10]);
                result.Add("INSERT_SUCCESS");
            }

            void SerachJAN()
            {
                Debug.WriteLine("SerachJAN => " + string.Join(" ", ProductMasterList.SerachJANData(int.Parse(SQLDatas[2]))));
                //グローバル変数のresultに結果を代入
                result = ProductMasterList.SerachJANData(int.Parse(SQLDatas[2]));
                if (result.Count == 0)
                {
                    result.Add("notfound");
                }
            }
        }
    }
}
