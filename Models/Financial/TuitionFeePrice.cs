using University.Web.Models.Academic;
using University.Web.Models.Core_Organizational;
using University.Web.Models.Personnel;

namespace University.Web.Models.Financial;

public partial class TuitionFeePrice
{
    public int ID { get; set; }

    public required int MajorID { get; set; }

    public required int StudyFormID { get; set; }

    public required decimal FallSemesterPrice { get; set; }

    public required decimal SpringSemesterPrice { get; set; }

    public required int requiredFeeID { get; set; }

    public required int ServiceFeeID { get; set; }

    public virtual Major Major { get; set; } = null!;

    public virtual requiredFee requiredFee { get; set; } = null!;

    public virtual ServiceFee ServiceFee { get; set; } = null!;

    public virtual StudyForm StudyForm { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
}
