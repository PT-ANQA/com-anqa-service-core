﻿using System;
using Xunit;
using Com.Anqa.Service.Core.Lib;
using Com.Anqa.Service.Core.Lib.Services;
using Models = Com.Anqa.Service.Core.Lib.Models;
using Com.Anqa.Service.Core.Test.Helpers;

namespace Com.Anqa.Service.Core.Test.Service.Budget
{
    [Collection("ServiceProviderFixture Collection")]
    public class BudgetBasicTest : BasicServiceTest<CoreDbContext, BudgetService, Models.Budget>
    {
        private static readonly string[] createAttrAssertions = { "Code", "Name" };
        private static readonly string[] updateAttrAssertions = { "Code", "Name" };
        private static readonly string[] existAttrCriteria = { "Code" };

        public BudgetBasicTest(ServiceProviderFixture fixture) : base(fixture, createAttrAssertions, updateAttrAssertions, existAttrCriteria)
        {
        }

        public override void EmptyCreateModel(Models.Budget model)
        {
            model.Code = string.Empty;
            model.Name = string.Empty;
        }

        public override void EmptyUpdateModel(Models.Budget model)
        {
            model.Code = string.Empty;
            model.Name = string.Empty;
        }

        public override Models.Budget GenerateTestModel()
        {
            string guid = Guid.NewGuid().ToString();

            return new Models.Budget()
            {
                Code = guid,
                Name = "TEST BUDGET",
            };
        }
    }
}