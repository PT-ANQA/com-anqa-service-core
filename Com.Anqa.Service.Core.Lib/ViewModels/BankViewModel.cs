using Com.Anqa.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Core.Lib.ViewModels
{
    public class BankViewModel : BasicViewModelOld
    {
        public string code { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }
}
