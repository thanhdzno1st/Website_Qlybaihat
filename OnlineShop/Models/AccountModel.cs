using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OnlineShop.Models.Framework;

namespace OnlineShop.Models
{
    public class AccountModel
    {
        private OnlineShopDBContext context = null;
        public AccountModel() 
        {
            context  = new OnlineShopDBContext();
        }
        public bool login(String username, String password)
        {

            object[] sqlParams =
            {
                    new SqlParameter("@Username", string.IsNullOrEmpty(username) ? DBNull.Value : (object)username),
                    new SqlParameter("@Password", string.IsNullOrEmpty(password) ? DBNull.Value : (object)password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @Username,@Password",sqlParams).SingleOrDefault();
            return res;
        }
    }
}