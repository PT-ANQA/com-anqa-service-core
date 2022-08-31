using Com.Anqa.Service.Core.Lib;
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
    public class LampStandardDataUtil : BasicDataUtil<CoreDbContext, LampStandardService, LampStandard>, IEmptyData<LampStandardViewModel>
    {
        public LampStandardDataUtil(CoreDbContext dbContext, LampStandardService service) : base(dbContext, service)
        {
        }
        public LampStandardViewModel GetEmptyData()
        {
            LampStandardViewModel Data = new LampStandardViewModel();

            Data.Name = "";
            Data.Code = "";
            Data.Remark = "";
            return Data;
        }

        public override LampStandard GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            LampStandard TestData = new LampStandard
            {
                Name = "TEST",
                Remark = "test",
            };

            return TestData;
        }

        public override async Task<LampStandard> GetTestDataAsync()
        {
            LampStandard Data = GetNewData();
            await this.Service.CreateModel(Data);
            return Data;
        }
    }
}
