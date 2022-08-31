using Com.Anqa.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Core.Lib.ViewModels
{
    public class ArticleMaterialViewModel : BasicViewModelOld
    {
        public string code { get; set; }

        public string name { get; set; }

        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
