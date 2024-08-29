using Dapper;
using HomeWork17.Domain.Staff;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HomeWork17.DataAccess.StaffsDataAccess;

public class StaffDataAccess : IStaffDataAccess
{
    private readonly IDbConnection _connection;
    public StaffDataAccess(IConfiguration configuration)
    {
        //_connection = new SqlConnection(configuration.GetSection("ConnectionStrings")["Default"]);
        _connection = new SqlConnection(configuration.GetConnectionString("Default"));
    }
    public List<FullGraphStaff> SearchStaffs(int? staffId = null, string? storeName = null)
    {
        using var con = _connection;
        con.Open();
        var query = @"Select 
                     s.staff_id as StaffId,
                     s.first_name As FirstName,
                     s.last_name As LastName,
                     s.email as Email,
                     s.phone as Phone,
                     s.store_id as StoreId,
                     m.first_name as ManagerFirstName,
                     st.store_name as StoreName
                     from sales.staffs s
                     Left join sales.staffs m
                     on s.manager_id = m.staff_id
                     left join sales.stores st
                     on st.store_id = s.store_id where 1=1";

        query += staffId.GetValueOrDefault(0) > 0 ? $" and s.staff_id = {staffId}" : string.Empty;
        query += !string.IsNullOrWhiteSpace(storeName) ? $" and st.store_name like '%{storeName}%'" : string.Empty;

        var staffs = con.Query<FullGraphStaff>(query);
        con.Close();
        return staffs.ToList();
    }
}
