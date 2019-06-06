using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.Models;
using Microsoft.Ajax.Utilities;
using ProxyManager;
using Torrent_Server_Side.Commom.Models;

namespace WebPortal
{
    public partial class SignUp : System.Web.UI.Page
    {
        public const string USER_CONTROLLER_SIGNUP = "User_Controller-SignUp";
        public const string USERSMARTSPACE = "User_SmartSpace";
        private Proxy _proxy;

        protected void Page_Load(object sender, EventArgs e)
        {
            _proxy = new Proxy();
            txt_UserSmartspace.Value = ConfigurationManager.ConnectionStrings[USERSMARTSPACE].ToString();
            // TODO - empty modal message text value
        }

        protected async void SignUp_ClickAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_UserName.Value) || string.IsNullOrEmpty(txt_Avatar.Value)
                                                         || string.IsNullOrEmpty(txt_Role.Value) 
                                                         || string.IsNullOrEmpty(txt_UserSmartspace.Value)
                                                         || string.IsNullOrEmpty(txt_Email.Value))
            {
                Msg_For_User("please fill all the details");
                return;
            }

            UserForm userForm = GetUserFormFromComponent();
            UserBoundary user = null;
            try
            {

                string requestURI = ConfigurationManager.ConnectionStrings[USER_CONTROLLER_SIGNUP].ToString();
                user = await _proxy.SignUp_Async(userForm, requestURI);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }


            if (user.key == null)
            {
                Msg_For_User("Did NOT Signup- User might be already exist");
                return;
            }
            Msg_For_User("Signup Successfully");
            Response.Redirect("HomePage.aspx");
        }

        private UserForm GetUserFormFromComponent()
        {
            string theUserName = txt_UserName.Value;
            string avatar =      txt_Avatar.Value;
            string role =        txt_Role.Value;
            string smartspace =  txt_UserSmartspace.Value;
            string email =       txt_Email.Value;
            UserForm userForm = new UserForm();

            userForm.avatar = avatar;
            userForm.role = role;
            userForm.username = theUserName;
            userForm.email = email;
            userForm.smartspcae = smartspace;
            return userForm;
        }

        protected void HomePage_Button_ClickAsync(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

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
            return;
        }
    }
}
