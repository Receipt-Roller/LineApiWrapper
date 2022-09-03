using libLineApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace libLineApi.Services
{
    /// <summary>
    /// SHO.S
    /// RECEIPTROLLER, https://receiptroller.com
    /// Auth
    /// https://developers.line.biz/en/reference/messaging-api/#channel-access-token
    /// 2022-07-17
    /// </summary>
    /// 
    public class Auth
    {

        HttpClient _httpClient;
        LineApiClientModel _lineApiClient;

        public Auth()
        {
            _httpClient = new HttpClient();
            _lineApiClient = new LineApiClient().GetLineApiClient();
        }

        /// <summary>
        /// Get channel access token.
        /// </summary>
        /// <see cref="https://developers.line.biz/en/reference/messaging-api/#issue-channel-access-token-v2-1"/>
        /// <param name="clientCredential">Client credential</param>
        /// <param name="jwt">JWT string</param>
        /// <returns>Oauth2_V21_TokenResponseModel</returns>
        public async Task<Oauth2_V21_TokenResponseModel> GetTokenAsync(string clientCredential, string jwt)
        {
            using (var request = new HttpRequestMessage(new HttpMethod("POST"), _lineApiClient.ApiEndPointUrl + "/oauth2/v2.1/token"))
            {
                var contentList = new List<string>();
                contentList.Add($"grant_type={Uri.EscapeDataString(clientCredential)}");
                contentList.Add($"client_assertion_type={Uri.EscapeDataString("urn:ietf:params:oauth:client-assertion-type:jwt-bearer")}");
                contentList.Add($"client_assertion={Uri.EscapeDataString(jwt)}");
                request.Content = new StringContent(string.Join("&", contentList));
                request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

                var response = await _httpClient.SendAsync(request);

                var result = JsonSerializer.Deserialize<Oauth2_V21_TokenResponseModel>(await response.Content.ReadAsStringAsync());

                return result;
            }
        }
    }
}
