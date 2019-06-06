using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Common.Models;
using Newtonsoft.Json.Linq;
using Torrent_Server_Side.Commom.Models;

namespace ProxyManager
{
    public class Proxy
    {
        public UserBoundary UserBoundary { get; set; }

        public Proxy()
        {

        }

        public async Task<UserBoundary> Login(string UserEmail, string SmartSpace, string IPAdress)
        {
            UserBoundary user = await Login_Async(UserEmail, SmartSpace, IPAdress);
            return user;
        }

        public async Task<UserBoundary> Login_Async(string UserEmail, string SmartSpace, string URLAdress)
        {
            using (var client = new HttpClient())
            {
                string login_connection_string =
                    URLAdress + "/" + SmartSpace + "/" + UserEmail;
                HttpResponseMessage response = await client.GetAsync(login_connection_string);
                string responseBody = await response.Content.ReadAsStringAsync();
                UserBoundary user = null;
                try
                {
                    user = //new UserBoundary(responseBody);
                        new JavaScriptSerializer().Deserialize<UserBoundary>(responseBody);
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

                return user;
            }
        }

        public async Task<UserBoundary> SignUp_Async(UserForm user, string URLAdress)
        {
            using (var client = new HttpClient())
            {
                UserBoundary userBoundary = null;
                var response = await client.PostAsync(URLAdress,
                    new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(user), Encoding.UTF8,
                        "application/json"));
                string responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                    userBoundary = new JavaScriptSerializer().Deserialize<UserBoundary>(responseBody);
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

                return userBoundary;
            }
        }

        public async Task<List<ElementBoundary>> GetListOfBooks(string UserEmail, string SmartSpace,string valueForSearch,string requestURI)
        {
            using (var client = new HttpClient())
            {
                string login_connection_string =
                    requestURI + "/" + SmartSpace + "/" + UserEmail;
                if (!string.IsNullOrEmpty(valueForSearch))
                    login_connection_string += "?search=name&value=" + valueForSearch;
                var response = await client.GetAsync(login_connection_string);
                string responseBody = await response.Content.ReadAsStringAsync();
                List<ElementBoundary> users = null;
                try
                {
                    users = new JavaScriptSerializer().Deserialize<List<ElementBoundary>>(responseBody);
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                return users;
            }

        }

        public async Task<GeneralStringResponse> PluginGeneralAction(ActionBoundary actionBoundary, string requestURI)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(requestURI,
                    new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(actionBoundary), Encoding.UTF8,
                        "application/json"));
                

                string responseBody = await response.Content.ReadAsStringAsync();
                GeneralStringResponse generalStringResponse = null;
                try
                {
                    generalStringResponse = new JavaScriptSerializer().Deserialize<GeneralStringResponse>(responseBody);
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                if (!response.IsSuccessStatusCode)
                {
                    JObject jObject = JObject.Parse(responseBody);
                    generalStringResponse.result = (string) jObject["message"];
                }
                return generalStringResponse;
            }

        }


    }
}
