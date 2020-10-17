using Dapper;
using System.Data.SqlClient;
using MyWeb.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using MyWeb.Common;

namespace MyWeb.Dao.Sql
{
    public class ProductsDA
    {
        private readonly string connectionString;
        public ProductsDA()
        {
            connectionString = ConfigTool.GetDBConnectionString("NorthwindConn");
        }
        public List<vw_Products> GetProductsData(int ProductID)
        {
            List<vw_Products> list = new List<vw_Products>();
            string sql = @"
                    SELECT [ProductID]
                        ,[ProductName]
                        ,M1.[SupplierID]
                        ,M1.[CategoryID]
                        ,[QuantityPerUnit]
                        ,[UnitPrice]
                        ,[UnitsInStock]
                        ,[UnitsOnOrder]
                        ,[ReorderLevel]
                        ,[Discontinued]
                        ,M2.CategoryName
                        ,M3.CompanyName
                    FROM 
                        [Northwind].[dbo].[Products] M1
                        INNER JOIN Categories M2 ON M1.CategoryID=M2.CategoryID
                        INNER JOIN Suppliers M3 ON M1.SupplierID=M3.SupplierID
                    WHERE
                        {0}
            ";
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    if (ProductID == 0)
                    {
                        sql = string.Format(sql, "1=1");
                        list = conn.Query<vw_Products>(sql).ToList();
                    }
                    else
                    {
                        sql = string.Format(sql, "ProductID=@ProductID");
                        list = conn.Query<vw_Products>(sql, new { ProductID }).ToList();
                    }
                }
            }
            catch (Exception)
            {
                return list;
            }
            return list;
        }        
    }
}
