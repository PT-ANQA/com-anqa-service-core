using Com.Anqa.Service.Core.Lib;
using Com.Anqa.Service.Core.Lib.Models;
using Com.Anqa.Service.Core.Lib.Services;
using Com.Anqa.Service.Core.Lib.ViewModels;
using Com.Anqa.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Com.Anqa.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/garment-sections")]
    public class GarmentSectionController : BasicController<GarmentSectionService, GarmentSection, GarmentSectionViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        public GarmentSectionController(GarmentSectionService Service) : base(Service, ApiVersion)
        {
        }
    }
}
