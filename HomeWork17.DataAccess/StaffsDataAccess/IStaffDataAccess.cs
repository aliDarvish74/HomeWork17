using HomeWork17.Domain.Staff;

namespace HomeWork17.DataAccess.StaffsDataAccess
{
    public interface IStaffDataAccess
    {
        List<FullGraphStaff> SearchStaffs(int? staffId = null, string? storeName = null);
    }
}
