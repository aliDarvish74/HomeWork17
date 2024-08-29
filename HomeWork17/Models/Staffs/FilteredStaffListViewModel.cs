using HomeWork17.Domain.Staff;
using HomeWork17.Service.StaffsService.Contracts.Requests;
using HomeWork17.Service.StaffsService.Contracts.Result;

namespace HomeWork17.Models.Staffs;

public class FilteredStaffListViewModel
{
    public FilteredStaffListViewModel(List<StaffViewModel> staffs, StaffListFilter? filter)
    {
        Staffs = staffs;
        Filter = filter ?? new StaffListFilter();
    }
    public List<StaffViewModel> Staffs { get; set; }
    public StaffListFilter Filter { get; set; }
}

public static class StaffsMapper
{
    public static StaffViewModel MapStaffToStaffViewModel(this SearchStaffsResult staff)
    {
        return new StaffViewModel
        {
            StaffId = staff.StaffId,
            FirstName = staff.FirstName,
            LastName = staff.LastName,
            Email = staff.Email,
            Phone = staff.Phone,
            StoreId = staff.StoreId,
            StoreName = staff.StoreName,
            ManagerFirstName = staff.ManagerFirstName
        };
    }

    public static StaffFilter? MapStaffListFiltertoStaffFilter(this StaffListFilter filter)
    {
        return new StaffFilter
        {
            StaffId = filter.StaffId,
            StaffStore = filter.StoreName
        };
    }
}