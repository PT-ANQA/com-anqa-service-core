﻿using Com.Anqa.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Anqa.Service.Core.Lib.ViewModels
{
    public class ComodityViewModel : BasicViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
