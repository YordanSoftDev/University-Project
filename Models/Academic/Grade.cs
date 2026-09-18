using University.Web.Models.Academic.GradeEnumerations;
using University.Web.Models.Personnel;

namespace University.Web.Models.Academic;

public partial class Grade
{
    public int ID { get; set; }

    public required int StudentID { get; set; }

    public required int SubjectID { get; set; }

    public required decimal? GradeValue { get; set; }

    public required DateOnly GradeDate { get; set; }

    public required Semester Semester { get; set; }

    public required string AcademicYear { get; set; } 

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
