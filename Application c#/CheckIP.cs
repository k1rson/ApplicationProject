using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ApplicationProject
{
    public class CheckIP
    {
        public async static void GetMyIP_2ip()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://2ip.ru");

            requestMessage.Headers.Add("User-Agent", "User-Agent-Here");
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);


            Match _match = Regex.Match(response.ToString(), "=([0-9]+.*?);");
            OtherFunction.IP = _match.Groups[1].Value;
        }
    }
}
