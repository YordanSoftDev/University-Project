using System.Text.Json.Serialization;
using University.Web.Models.Personnel;

namespace University.Web.Models.Core_Organizational;

public partial class Department
{
    public int ID { get; set; }

    public required string DepartmentName { get; set; }

    public required string DepartmentCode { get; set; }

    public int? HeadOfDepartmentID { get; set; }

    public int? FacultyID { get; set; }

    public required string Email { get; set; } 

    public required string PhoneNumber { get; set; } 

    public required string OfficeLocation { get; set; } 

    public required DateTime EstablishedDate { get; set; }

    public required  bool IsActive { get; set; }

    public required string Description { get; set; }

    public virtual Faculty? Faculty { get; set; }

    public virtual Staff? StaffMemberHeadOfDepartment { get; set; }

    public virtual ICollection<Major> Majors { get; set; } = new HashSet<Major>();
}
