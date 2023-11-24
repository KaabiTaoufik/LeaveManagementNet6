using LeaveManagement.web.Constants;
using LeaveManagement.web.Contracts;
using LeaveManagement.web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager
            ,ILeaveTypeRepository leaveTypeRepository) : base(context)
        {
            this._context = context;
            this._userManager = userManager;
            this._leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<bool> HasLeaveAllocation(string employeeId, int leaveTypeId)
        {
            return await _context.LeaveAllocations.AnyAsync(leave => leave.LeaveTypeId == leaveTypeId
                                                                    && leave.EmployeeId == employeeId);
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await _userManager.GetUsersInRoleAsync(UserRole.User);
            var period = DateTime.Now.Year;
            var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);

            foreach (var employee in employees)
            {
                if(await HasLeaveAllocation(employee.Id, leaveTypeId)) continue;

                var allocation = new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                };
                await CreateAsync(allocation);
            }
        }
    }
}
