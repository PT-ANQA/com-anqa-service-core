using Com.Anqa.Service.Core.Lib;
using Com.Anqa.Service.Core.Lib.Models;
using Com.Anqa.Service.Core.Lib.Services;
using Com.Anqa.Service.Core.Lib.ViewModels;
using Com.Anqa.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Anqa.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/card-types")]
    public class CardTypeController : BasicController<CardTypeService, CardType, CardTypeViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";

        public CardTypeController(CardTypeService service) : base(service, ApiVersion)
        {
        }
    }
}