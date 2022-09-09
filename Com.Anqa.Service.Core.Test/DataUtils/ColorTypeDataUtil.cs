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
    public class ColorTypeDataUtil : BasicDataUtil<CoreDbContext, ColorTypeService, ColorTypes>, IEmptyData<ColorTypeViewModel>
    {
        public ColorTypeDataUtil(CoreDbContext dbContext, ColorTypeService service) : base(dbContext, service)
        {
        }

        public ColorTypeViewModel GetEmptyData()
        {
            ColorTypeViewModel colorTypeViewModel = new ColorTypeViewModel();
            return colorTypeViewModel;
        }

        public override ColorTypes GetNewData()
        {
            ColorTypes colorTypes = new ColorTypes()
            {
                Name = "ColorTypesName",
                Code = "ColorTypesCode",
                Remark = "ColorTypesRemark",
            };
            return colorTypes;
        }

        public override async Task<ColorTypes> GetTestDataAsync()
        {
            ColorTypes colorTypes = GetNewData();
            await Service.CreateModel(colorTypes);
            return colorTypes;
        }
    }
}
