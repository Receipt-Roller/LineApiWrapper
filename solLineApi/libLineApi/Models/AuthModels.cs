using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libLineApi.Models
{
    internal class AuthModels
    {
    }

    public class Oauth2_V21_TokenResponseModel
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public long expires_in { get; set; }
        public string key_id { get; set; }
    }


}
