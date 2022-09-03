using libLineApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLineApi.Interfaces
{
    /// <summary>
    /// SHO.S
    /// RECEIPTROLLER, https://receiptroller.com
    /// Auth
    /// https://developers.line.biz/en/reference/messaging-api/#channel-access-token
    /// 2022-07-17
    /// </summary>
    /// 
    public interface IAuth
    {
        /// <summary>
        /// Get channel access token.
        /// </summary>
        /// <see cref="https://developers.line.biz/en/reference/messaging-api/#issue-channel-access-token-v2-1"/>
        /// <param name="clientCredential">Client credential</param>
        /// <param name="jwt">JWT string</param>
        /// <returns>Oauth2_V21_TokenResponseModel</returns>
        Task<Oauth2_V21_TokenResponseModel> GetTokenAsync(string clientCredential, string jwt);
    }
}
