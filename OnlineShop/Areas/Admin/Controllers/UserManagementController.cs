using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Authorize]

    public class UserManagementController : Controller
    {
        // GET: Admin/Utilities_border
        public ActionResult Index()
        {
            var iplUser=new UserModel();
            var model = iplUser.ListAll();
            return View(model);
        }
        public ActionResult ExportToXml()
        {
            // Kết nối đến SQL Server và lấy dữ liệu từ bảng BaiHat
            string connectionString = "Data Source=Thanh;Initial Catalog=OnlineShop;User ID=sa;Password=123456789;TrustServerCertificate=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            string query = "SELECT * FROM [User]";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }

            // Tạo tài liệu XML
            XDocument xmlDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Users") 
            );

            // Thêm các phần tử bài hát vào tài liệu XML
            foreach (DataRow row in dt.Rows)
            {
                XElement songElement = new XElement("User", 
                    new XElement("MaThanhVien", row["MaThanhVien"]), 
                    new XElement("HoVaTen", row["HoVaTen"]),
                    new XElement("SoDienThoai", row["SoDienThoai"]),
                    new XElement("Email", row["Email"]),
                    new XElement("MatKhau", row["MatKhau"]),
                    new XElement("GoiThanhVien", row["GoiThanhVien"]),
                    new XElement("NgayDangKy", Convert.ToDateTime(row["NgayDangKy"]).ToString("M/d/yyyy h:mm:ss tt"))
                );

                xmlDoc.Root.Add(songElement);
            }

            // Lưu file XML
            string filePath = Server.MapPath("~/App_Data/User.xml");
            xmlDoc.Save(filePath);

            // Hiển thị nội dung XML lên trình duyệt
            Response.ContentType = "application/xml";
            Response.Write(xmlDoc.ToString());
            Response.End();
            return null;
        }
    }
}