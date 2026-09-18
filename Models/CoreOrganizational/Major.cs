using University.Web.Application.Academic;
using University.Web.Models.Academic;
using University.Web.Models.Financial;
using University.Web.Models.Personnel;

namespace University.Web.Models.Core_Organizational;

public partial class Major
{
    public int ID { get; set; }

    public required string MajorName { get; set; }

    public required string MajorCode { get; set; } 

    public required string DegreeLevel { get; set; }

    public required int DurationYears { get; set; }

    public required int CreditsRequired { get; set; }

    public required bool IsActive { get; set; }

    public required DateTime EstablishedDate{ get; set; }

    public required string Description { get; set; }

    public required int DepartmentID { get; set; }

    public required int FacultyID { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Faculty Faculty { get; set; } = null!;

    public virtual ICollection<ServiceFee> ServiceFees { get; set; } = new HashSet<ServiceFee>();

    public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

    public virtual ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();

    public virtual ICollection<TuitionFeePrice> TuitionFeesPrices { get; set; } = new HashSet<TuitionFeePrice>();
}
