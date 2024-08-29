using HomeWork17.Service.StaffsService.Contracts.Requests;
using HomeWork17.Service.StaffsService.Contracts.Result;

namespace HomeWork17.Service.StaffsService;

public interface IStaffService
{
    List<SearchStaffsResult> SearchStaffs(StaffFilter? filter);
}
