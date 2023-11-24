using LeaveManagement.web.Data;

namespace LeaveManagement.web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> HasLeaveAllocation(string employeeId, int leaveTypeId);
    }
}
