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
    public class GarmentCategoryDataUtil : BasicDataUtil<CoreDbContext, GarmentCategoryService, GarmentCategory>, IEmptyData<GarmentCategoryViewModel>
    {

        public GarmentCategoryDataUtil(CoreDbContext dbContext, GarmentCategoryService service) : base(dbContext, service)
        {
        }

        public GarmentCategoryViewModel GetEmptyData()
        {
            GarmentCategoryViewModel Data = new GarmentCategoryViewModel();

            Data.name = "";
            Data.codeRequirement = "";
            Data.code = "";
            Data.uom = null;
            return Data;
        }

        public override GarmentCategory GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            GarmentCategory TestData = new GarmentCategory
            {
                Name = "TEST",
                CodeRequirement = "TEST",
                UomId=1,
                UomUnit = "TEST",
                Code = guid
            };

            return TestData;
        }

        public override async Task<GarmentCategory> GetTestDataAsync()
        {
            GarmentCategory Data = GetNewData();
            await this.Service.CreateModel(Data);
            return Data;
        }
    }
}