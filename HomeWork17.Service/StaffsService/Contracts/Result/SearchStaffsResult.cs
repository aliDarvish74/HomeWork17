using HomeWork17.Domain.Staff;
namespace HomeWork17.Service.StaffsService.Contracts.Result;

public class SearchStaffsResult
{
    public int StaffId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int StoreId { get; set; }
    public string StoreName { get; set; }
    public string ManagerFirstName { get; set; }
}

public static class StaffResultMapper
{
    public static SearchStaffsResult MapStaffToStaffResult(this FullGraphStaff staff)
    {
        return new SearchStaffsResult
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
}
