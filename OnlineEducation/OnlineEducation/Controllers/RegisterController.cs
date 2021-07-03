using OnlineEducation.Model;
using OnlineEduDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineEducation.Controllers
{
    public class RegisterController : Controller
    {
        UserDAO userDAO = new UserDAO();

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckRegister(string username, string fulname, string phone,string email,string password,string re_password)
        {

            string message = "";
            User user = userDAO.getUserByUserName(username);
            if (username == "" || fulname==""||phone==""||email==""||password == ""||re_password=="")
            {
                message = "Thông tin không được để trống";
            }
            else if (!password.Equals(re_password))
            {
                message = "Nhập lại mật khẩu không khớp";
            }
            else if (user!=null)
            {
                message = "Tên tài khoản đã tồn tại";
            }
            else
            {
                User userModel = new User();
                userModel.Username =username;
                userModel.Password = re_password;
                userModel.FullName = fulname;
                userModel.Email = email;
                userModel.PhoneNumber = phone;
                userModel.Role_ID = 2;
                userDAO.addUser(userModel);
                if (userDAO.getUser(username, password)==null)
                {
                    message = "Đăng ký thất bại, hệ thống đang bị lỗi";
                }
                else
                {
                    message = "Đăng ký tài khoản thành công";
                    Session["UserModel"] = userModel;
                    Session.Timeout = 15;
                }
            }
            Session.Add("message", message);
            return RedirectToAction("Index", "Register");// có thể thay bằng foward
        }
    }
}