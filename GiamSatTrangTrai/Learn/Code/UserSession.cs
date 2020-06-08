using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learn.Code
{
    [Serializable]
    public class UserSession
    {
        public string userName { set; get; }
        public string passWord { set; get; }
        public string role { set; get; }
    }
}