using AutoMapper;
using Com.Anqa.Service.Core.Lib.Models;
using Com.Anqa.Service.Core.Lib.ViewModels;

namespace Com.Anqa.Service.Core.Lib.AutoMapperProfiles
{
    public class MachineSpinningProfile : Profile
    {
        public MachineSpinningProfile()
        {
            CreateMap<MachineSpinningModel, MachineSpinningViewModel>()
                .ReverseMap();
            CreateMap<MachineSpinningProcessType, MachineSpinningProcessTypeViewModel>()
                .ReverseMap();
        }
    }
}
