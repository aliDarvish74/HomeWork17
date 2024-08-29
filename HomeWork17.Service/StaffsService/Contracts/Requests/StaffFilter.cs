using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17.Service.StaffsService.Contracts.Requests;

public class StaffFilter
{
    public int? StaffId { get; set; }
    public string? StaffStore { get; set; }
}
