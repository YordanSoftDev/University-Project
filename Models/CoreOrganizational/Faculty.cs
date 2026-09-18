using University.Web.Models.CoreOrganizational.FacultyEnumerations;
using University.Web.Models.Personnel;

namespace University.Web.Models.Core_Organizational;

public partial class Faculty
{
    public int ID { get; set; }

    public required string FacultyName { get; set; } 

    public required string FacultyCode { get; set; } 

    public required decimal Budget { get; set; }

    public required string OfficeLocation { get; set; } 

    public required string Email { get; set; } 

    public required string PhoneNumber { get; set; } 

    public required WebsiteStatus WebsiteStatus { get; set; }

    public required string Website { get; set; }

    public required int EstablishedYear { get; set; }

    public required bool IsActive { get; set; }

    public required  string Description { get; set; } 

    public required AccreditationStatus AccreditationStatus { get; set; }

    public required DateTime RecordCreatedTimestamp { get; set; }

    public required DateTime LastModifiedTimestamp { get; set; }

    public int? DeanID { get; set; }

    public virtual Staff? Dean { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();

    public virtual ICollection<Major> Majors { get; set; } = new HashSet<Major>();

    public virtual ICollection<Staff> StaffMembers { get; set; } = new HashSet<Staff>();
}
