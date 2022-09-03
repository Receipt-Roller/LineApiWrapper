using libLineApi.Interfaces;
using libLineApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace libLineApi.Services
{
    /// <summary>
    /// SHO.S
    /// RECEIPTROLLER, https://receiptroller.com
    /// Client Service.
    /// 2022-07-17
    /// </summary>
    /// 

    public class LineApiClient : ILineApiClient
    {

        public LineApiClientModel _lineApiClient;

        public LineApiClient()
        {
            _lineApiClient = new LineApiClientModel();
            _lineApiClient.ApiEndPointUrl = "https://api.line.me";

        }

        public LineApiClientModel GetLineApiClient()
        {
            return _lineApiClient;
        }


    }
}
