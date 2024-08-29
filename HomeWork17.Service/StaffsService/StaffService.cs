using HomeWork17.DataAccess.StaffsDataAccess;
using HomeWork17.Service.StaffsService.Contracts.Requests;
using HomeWork17.Service.StaffsService.Contracts.Result;

namespace HomeWork17.Service.StaffsService;

public class StaffService : IStaffService
{
    private readonly IStaffDataAccess _staffDataAccess;

    public StaffService(IStaffDataAccess staffDataAccess)
    {
        _staffDataAccess = staffDataAccess;
    }
    public List<SearchStaffsResult> SearchStaffs(StaffFilter? filter)
    {
        return _staffDataAccess
            .SearchStaffs(filter?.StaffId, filter?.StaffStore)
            .Select(s => s.MapStaffToStaffResult())
            .ToList();
    }
}
