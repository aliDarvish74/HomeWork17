using Dapper;
using HomeWork17.Models.Staffs;
using HomeWork17.Service.StaffsService;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace HomeWork17.Controllers;

public class StaffsController : Controller
{
    private readonly IStaffService _staffService;

    public StaffsController(IStaffService staffService)
    {
        _staffService = staffService;
    }
    public IActionResult Index(StaffListFilter? filter = null)
    {
        var result = _staffService.SearchStaffs(filter?.MapStaffListFiltertoStaffFilter());
        var viewStaffs = result.Select(s => s.MapStaffToStaffViewModel()).ToList();
        var model = new FilteredStaffListViewModel(viewStaffs, filter);
        return View(model);
    }
}
