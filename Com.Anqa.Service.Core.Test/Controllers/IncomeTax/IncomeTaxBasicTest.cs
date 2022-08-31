using Com.Anqa.Service.Core.Lib;
using Com.Anqa.Service.Core.Lib.Services;
using Com.Anqa.Service.Core.Lib.ViewModels;
using Com.Anqa.Service.Core.Test.Helpers;
using System.Collections.Generic;
using Models = Com.Anqa.Service.Core.Lib.Models;
using Xunit;
using Com.Anqa.Service.Core.Test.DataUtils;

namespace Com.Anqa.Service.Core.Test.Controllers.IncomeTax
{
    [Collection("TestFixture Collection")]
    public class IncomeTaxBasicTest : BasicControllerTest<CoreDbContext, IncomeTaxService, Models.IncomeTax, IncomeTaxViewModel, IncomeTaxDataUtil>
    {
        private const string URI = "v1/master/income-taxes";

        private static List<string> CreateValidationAttributes = new List<string> { };
        private static List<string> UpdateValidationAttributes = new List<string> { };

        public IncomeTaxBasicTest(TestServerFixture fixture) : base(fixture, URI, CreateValidationAttributes, UpdateValidationAttributes)
        {
        }
    }
}
