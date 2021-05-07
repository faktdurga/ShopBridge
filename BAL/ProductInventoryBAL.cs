using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MODEL;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
   public class ProductInventoryBAL
    {
        ProductInventoryDAL dal = new ProductInventoryDAL();

        public int AddInventory(ProductInventoryModel model)
        {
            return dal.AddInventory(model);
        }

        public DataTable BindByProductID(int ProductID)
        {
            return dal.BindByProductID(ProductID);
        }

        public int UpdateInventory(ProductInventoryModel model)
        {
            return dal.UpdateInventory(model);
        }
        public int Delete(ProductInventoryModel model)
        {
            return dal.Delete(model);
        }
    }
}
