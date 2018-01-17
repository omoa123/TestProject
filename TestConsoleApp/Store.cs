using System.Collections.Generic;

namespace TestConsoleApp
{
    public class Store
    {
        public string Date;
        public string StoreID;
        public string StoreName;

        public static List<Store> QueryStoreList(string parentId, string shipmentNo)
        {
            var StoreList = new List<Store>();
            using (System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(AppConnectionString.B2C))
            {
                string querySQL = @"SELECT TOP 100  * 
                                FROM [eService_B2C].[dbo].[ec_eshop_eta]
                                WHERE (parentId = @parentId) and (shipmentNo = @shipmentNo)";

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(querySQL, cn))
                {
                    cn.Open();
                    cmd.CommandTimeout = 600;
                    cmd.Parameters.AddWithValue("@parentId", parentId);
                    cmd.Parameters.AddWithValue("@shipmentNo", shipmentNo);
                    System.Data.SqlClient.SqlDataReader sr = cmd.ExecuteReader();

                    while (sr.Read())
                    {
                        StoreList.Add(new Store
                        {
                            StoreID = sr["storeId"].ToString(),
                            StoreName = sr["storeName"].ToString(),
                            //Date = sr.ToTimeFormat("pickUpDeadline"),
                        });
                    }
                    cn.Close();
                }
            }
            return StoreList;
        }
    }
}
