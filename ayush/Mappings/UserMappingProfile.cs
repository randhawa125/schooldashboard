using AutoMapper;
using ayush.Models;
using ayush.Models.ViewModels;
using ayush.Resource;

namespace ayush.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<EditUserProfile, UserInformation>()
                .ForMember(x => x.DateOfBirth, src => src.MapFrom(a => a.DateOfBirth));
            
            CreateMap<UserInformation, EditUserProfile>();

            CreateMap<StudentModuleOneMarksVM, StudentModuleOneMarks>();
        }
    }
}
