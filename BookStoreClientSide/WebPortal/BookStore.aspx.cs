using Newtonsoft.Json;
using ProxyManager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Common.Models;
using Torrent_Server_Side.Commom.Models;
using System.Threading;

namespace WebPortal
{
    public partial class AdminPage : System.Web.UI.Page
    {
        public const string ADMIN_FILES_URI = "Admin-Files";
        public const string ELEMENT_URL = "GetListOfBooks-URL";
     
        public const string DELETE_USER_URI = "Delete-UserBoundary";
        private List<ElementBoundary> booksList;
        public const string UPDATE_USER_URI = "Update-UserBoundary";
        private Proxy _proxy;
        private UserBoundary _user;

        

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _user = (UserBoundary)Session["User_Logged"];
                _proxy = new Proxy();
                onloadAsync();
                if (_user.role.Equals("MANAGER"))
                    txt_Options.Visible = false;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }
        void onloadAsync()
        {
            InitialBookTable(null);
        }
       

        private async void InitialBookTable(string valueForSearch)
        {
            string requestURI = ConfigurationManager.ConnectionStrings[ELEMENT_URL].ToString();
            int NumberOfRows = BookTable.Rows.Count;
            for (int i = 0; i < NumberOfRows; i++)
            {
                if (BookTable.Rows.Count > 1)
                    BookTable.Rows.Remove(BookTable.Rows[1]);
            }

            booksList = await _proxy.GetListOfBooks(_user.key.email, _user.key.smartspace, valueForSearch, requestURI);
            List<ElementBoundaryForTable> booksNameForTable = new List<ElementBoundaryForTable>();
            for (int i = 0; i < booksList.Count; i++) { }
            foreach (ElementBoundary elementBoundary in booksList)
            {
                if (elementBoundary.elementType == "book")
                {
                    ElementBoundaryForTable elementBoundaryForTable = new ElementBoundaryForTable();
                    elementBoundaryForTable.id = elementBoundary.key.id;
                    elementBoundaryForTable.name = elementBoundary.name;
                    booksNameForTable.Add(elementBoundaryForTable);
                }

            }
            BuildTable(booksNameForTable, BookTable);
        }

        public void BuildTable<T>(List<T> Data, HtmlTable theTable)
        {
            Data.ForEach(delegate (T obj)
            {
                HtmlTableRow htRow = new HtmlTableRow();
                obj.GetType().GetProperties().ToList().ForEach(delegate (PropertyInfo prop)
                {
                    HtmlTableCell htCell = new HtmlTableCell();
                    htCell.InnerText = prop.GetValue(obj, null).ToString();
                    //   obj.ToString();
                    htRow.Cells.Add(htCell);
                });
                theTable.Rows.Add(htRow);
            });
        }
        
   
        protected void SearchButton_OnClickAsync(object sender, EventArgs e)
        {
            string parameter = txt_Search.Text.ToString();
            InitialBookTable(parameter);
            
        }

        protected void MovePageToBookDetails(object sender, EventArgs e)
        {
            ElementBoundary the_chosen_book = null;
            foreach (ElementBoundary elementBoundary in booksList)
            {
                if (Book_ID.Text == elementBoundary.key.id)
                {
                    the_chosen_book = elementBoundary;
                }
            }

            if (the_chosen_book == null)
            {
                Msg_For_User("Please Choose a book");
                return;
            }
            Session["The_Chosen_Book"] = the_chosen_book;
            Session["User_Logged"] = _user;
            Response.Redirect("BookDetails.aspx", false);
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