using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShop.Models.Framework;

namespace OnlineShop.Models
{
    public class UserModel
    {
        private OnlineShopDBContext context = null;
        public UserModel() 
        {
            context = new OnlineShopDBContext();
        }
        public List<User> ListAll()
        {
            var list = context.Database.SqlQuery<User>("SELECT * FROM [User]").ToList();
            return list;
        }
    }
}