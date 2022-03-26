using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinterGardenMVC.Helpers
{
    [Serializable]
    public class ToastMessage
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public ToastType Type { get; set; }
    }
}