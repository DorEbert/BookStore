using ProxyManager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Torrent_Server_Side.Commom.Models;

namespace WebPortal
{
    public partial class MenuPage : System.Web.UI.Page
    {
        public const string LOGIN_CONNECTION_STRING = "Login_Connection_String";
        public const string USER_EMAIL = "User_Email";
        public const string USERSMARTSPACE = "User_SmartSpace";
        private UserBoundary _user;
        private Proxy _proxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            _proxy = new Proxy();
           
        }

        protected async void LoginButtonAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_UserEmail.Text))
                txt_UserEmail.Text = ConfigurationManager.ConnectionStrings[USER_EMAIL].ToString();
            if (string.IsNullOrEmpty(txt_Smartspace.Text))
                txt_Smartspace.Text = ConfigurationManager.ConnectionStrings[USERSMARTSPACE].ToString();
            string UserEmail = txt_UserEmail.Text;
            string SmartSpace = txt_Smartspace.Text;
            if (string.IsNullOrEmpty(UserEmail) || string.IsNullOrEmpty(SmartSpace))
            {
                Msg_For_User("Please insert UserBoundary Email and SmartSpace");
                return;
            }
            string URLAdress = ConfigurationManager.ConnectionStrings[LOGIN_CONNECTION_STRING].ToString();
             _user = await _proxy.Login(UserEmail,SmartSpace, URLAdress);
            if (_user.key == null)
            {
                Msg_For_User("User is not Exist");
                return;
            }

            if (_user.role.Equals("ADMIN") || (!_user.role.Equals("PLAYER") && !_user.role.Equals("MANAGER")))
            {
                Msg_For_User("ONLY MANAGER and PLAYER are allowed");
               return;         
            }

            Msg_For_User("Succeed");
            Session["User_Logged"] = _user;
            Response.Redirect("BookStore.aspx", false);
        }

        protected void SignUpButtonAsync(object sender, EventArgs e)
        {

            Response.Redirect("SignUp.aspx");
          
        }
        private void Msg_For_User(string msg)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            if (msg.Contains(":"))
            {
                string[] massage = msg.Split(':');
                msg = massage[1];
            }
            lblModalMessage.Text = msg;

        }
    }
}