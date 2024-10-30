using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using OnlineShop.Models;
using System.Data.SqlTypes;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Authorize]

    public class MusicManagementController : Controller
    {
        // GET: Admin/Utilities_animation
        public ActionResult Index()
        {
            var iplbaihat = new BaihatModel();
            var model = iplbaihat.ListAll();
            return View(model);
        }
        // Action để xuất dữ liệu ra file XML
        public ActionResult ExportToXml()
        {
            // Kết nối đến SQL Server và lấy dữ liệu từ bảng BaiHat
            string connectionString = "Data Source=Thanh;Initial Catalog=OnlineShop;User ID=sa;Password=123456789;TrustServerCertificate=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            string query = "SELECT maBaiHat, tenBaiHat, ngheSi, theLoai, ngayPhatHanh FROM BaiHat";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }

            // Tạo tài liệu XML
            XDocument xmlDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Songs") // Phần tử gốc là "Songs"
            );

            // Thêm các phần tử bài hát vào tài liệu XML
            foreach (DataRow row in dt.Rows)
            {
                XElement songElement = new XElement("Song", // Đổi tên phần tử con thành "Song"
                    new XElement("MaBaiHat", row["maBaiHat"]), // Sử dụng XElement để giữ lại cấu trúc
                    new XElement("TenBaiHat", row["tenBaiHat"]),
                    new XElement("NgheSi", row["ngheSi"]),
                    new XElement("TheLoai", row["theLoai"]),
                    new XElement("NgayPhatHanh", Convert.ToDateTime(row["ngayPhatHanh"]).ToString("M/d/yyyy h:mm:ss tt")) // Định dạng ngày tháng
                );

                xmlDoc.Root.Add(songElement);
            }

            // Lưu file XML
            string filePath = Server.MapPath("~/App_Data/BaiHat.xml");
            xmlDoc.Save(filePath);

            // Hiển thị nội dung XML lên trình duyệt
            Response.ContentType = "application/xml";
            Response.Write(xmlDoc.ToString());
            Response.End();
            return null;
        }


    }
}