using AutoMapper;
using LeaveManagement.web.Data;
using LeaveManagement.web.Models;

namespace LeaveManagement.web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<CreateLeaveTypeVM, LeaveType>();
            CreateMap<EditLeaveTypeVM, LeaveType>().ReverseMap();
        }
    }
}
