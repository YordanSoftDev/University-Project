using University.Web.Models.Core_Organizational;
using University.Web.Models.Junctions;

namespace University.Web.Models.Academic;

public partial class Subject
{
    public int ID { get; set; }

    public required string SubjectName { get; set; }

    public required int MajorID { get; set; }

    public required int Year { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new HashSet<Grade>();

    public virtual Major Major { get; set; } = null!;

    public virtual ICollection<LecturerSubject> LecturerSubjects { get; set; } = new HashSet<LecturerSubject>();
}
