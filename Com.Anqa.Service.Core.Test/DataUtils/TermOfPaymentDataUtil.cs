﻿using Com.Anqa.Service.Core.Lib;
using Com.Anqa.Service.Core.Lib.Models;
using Com.Anqa.Service.Core.Lib.Services;
using Com.Anqa.Service.Core.Lib.ViewModels;
using Com.Anqa.Service.Core.Test.Helpers;
using Com.Anqa.Service.Core.Test.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Anqa.Service.Core.Test.DataUtils
{
    public class TermOfPaymentDataUtil : BasicDataUtil<CoreDbContext, TermOfPaymentService, TermOfPayment>, IEmptyData<TermOfPaymentViewModel>
    {
        public TermOfPaymentDataUtil(CoreDbContext dbContext, TermOfPaymentService service) : base(dbContext, service)
        {
        }

        public TermOfPaymentViewModel GetEmptyData()
        {
            return new TermOfPaymentViewModel();
        }

        public override TermOfPayment GetNewData()
        {
            string guid = Guid.NewGuid().ToString();

            return new TermOfPayment()
            {
                Code = string.Format("TEST {0}", guid),
                Name = string.Format("TEST {0}", guid),
                IsExport = false,
            };
        }

        public override async Task<TermOfPayment> GetTestDataAsync()
        {
            var data = GetNewData();
            await this.Service.CreateModel(data);
            return data;
        }
    }
}
