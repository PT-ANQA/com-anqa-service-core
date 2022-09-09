using Com.Anqa.Service.Core.Lib;
using Com.Anqa.Service.Core.Lib.Models;
using Com.Anqa.Service.Core.Lib.Services;
using Com.Anqa.Service.Core.Lib.ViewModels;
using Com.Anqa.Service.Core.Test.DataUtils;
using Com.Anqa.Service.Core.Test.Helpers;
using System.Collections.Generic;
using Xunit;

namespace Com.Anqa.Service.Core.Test.Controllers.FinishTypeControllerTests
{
    [Collection("TestFixture Collection")]
    public class FinishTypeBasicTest : BasicControllerTest<CoreDbContext, FinishTypeService, FinishType, FinishTypeViewModel, FinishTypeDataUtil>
    {
        private static string URI = "v1/master/finish-types";
        private static List<string> CreateValidationAttributes = new List<string> { };
        private static List<string> UpdateValidationAttributes = new List<string> { "Name", "Code" };

        public FinishTypeBasicTest(TestServerFixture fixture) : base(fixture, URI, CreateValidationAttributes, UpdateValidationAttributes)
        {
        }
    }
}
