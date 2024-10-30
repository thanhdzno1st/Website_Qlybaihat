using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShop.Models.Framework;

namespace OnlineShop.Models
{
    public class BaihatModel
    {
        private OnlineShopDBContext context = null;
        public BaihatModel()
        {
            context = new OnlineShopDBContext();
        }
        public List<BaiHat> ListAll()
        {
            var list = context.Database.SqlQuery<BaiHat>("SELECT * FROM BaiHat").ToList();
            return list;
        }
    }
}