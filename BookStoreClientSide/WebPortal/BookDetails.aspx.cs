using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.Models;
using ProxyManager;
using Torrent_Server_Side.Commom.Models;

namespace WebPortal
{
    public partial class BookDetails : System.Web.UI.Page
    {
        private ElementBoundary _element;
        private UserBoundary _user;
        public const string ACTION_URL = "Action-URL";
        private Proxy _proxy;
        public string Message_From_Server { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            _element = (ElementBoundary)Session["The_Chosen_Book"];
            _user = (UserBoundary)Session["User_Logged"];
            _proxy = new Proxy();
            txt_BookID.Value = _element.key.id;
            txt_BookCreator.Value = _element.creator.ToString();
            txt_BookName.Value = _element.name;
            if (_element.elementProperties != null)
            {
                if(_element.elementProperties.ContainsKey("Genre"))
                     txt_Genre.Value =_element.elementProperties["Genre"].ToString();
                if (_element.elementProperties.ContainsKey("pagesAmount"))
                    txt_Amount_of_pages.Value = _element.elementProperties["pagesAmount"].ToString();
                if (_element.elementProperties.ContainsKey("Price"))
                    txt_Price.Value = _element.elementProperties["Price"].ToString();
                if (_element.elementProperties.ContainsKey("Language"))
                    txt_Language.Value = _element.elementProperties["Language"].ToString();
                if (_element.elementProperties.ContainsKey("Publisher"))
                    txt_Publisher.Value = _element.elementProperties["Publisher"].ToString();
                if (_element.elementProperties.ContainsKey("Author"))
                    txt_Author.Value = _element.elementProperties["Author"].ToString();
            }
        }
        protected async void CheckOutButtonAsync(object sender, EventArgs e)
        {
            string typeOfAction = "check out";
            await CheckInOrOut(typeOfAction);
        }
        protected async void CheckInButtonAsync(object sender, EventArgs e)
        {
            string typeOfAction = "check in";
            await CheckInOrOut(typeOfAction);
        }
        private async Task CheckInOrOut(string typeOfAction)
        {
            string URLAdress = ConfigurationManager.ConnectionStrings[ACTION_URL].ToString();
            ActionBoundary action = CreateActionBoundary(typeOfAction);
            GeneralStringResponse generalStringResponse = await _proxy.PluginGeneralAction(action, URLAdress);
            Message_From_Server = string.Copy(generalStringResponse.result);
            Message_For_User(Message_From_Server);
            //    Msg_For_User.Text = Message_From_Server;
        }

        protected async void PurchaseButtonAsync(object sender, EventArgs e)
        {
            string typeOfAction = "purchase";
            await CheckInOrOut(typeOfAction);
        }

        protected async void ReadBookSummaryButtonAsync(object sender, EventArgs e)
        {
            string typeOfAction = "read book summary";
            await CheckInOrOut(typeOfAction);
        }
        private ActionBoundary CreateActionBoundary(string typeOfAction)
        {
            ActionBoundary action = new ActionBoundary();
            ElementAndActionKey Elementkey = new ElementAndActionKey();
            Elementkey.smartspace = _user.key.smartspace;
            Elementkey.id = _element.key.id;
            action.element = Elementkey;
            action.player = _user.key;
            action.type = typeOfAction;
            action.properties = new Dictionary<string, object>();
            return action;
        }
        protected void SignUpButtonAsync(object sender, EventArgs e)
        {
            Session["User_Logged"] = _user;
            Response.Redirect("BookStore.aspx",false);

        }

        protected void BookStore_Button_ClickAsync(object sender, EventArgs e)
        {
            Session["User_Logged"] = _user;
            Response.Redirect("BookStore.aspx", false);
        }
        private void Message_For_User(string msg)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            if (msg.Contains("java.lang.RuntimeException"))
            {
                string[] massage = msg.Split(':');
                msg = massage[1];
            }
            lblModalMessage.Text = msg;

        }

        protected async void Echo_Button_ClickAsync(object sender, EventArgs e)
        {
            string typeOfAction = "echo";
            await CheckInOrOut(typeOfAction);
        }
    }
}