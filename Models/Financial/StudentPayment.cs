using University.Web.Models.Academic.GradeEnumerations;
using University.Web.Models.Financial.StudentPaymentEnumerations;
using University.Web.Models.Personnel;

namespace University.Web.Models.Financial;

public partial class StudentPayment
{
    public int ID { get; set; }

    public required string AcademicYear { get; set; } 

    public required Semester Semester { get; set; }

    public required DateTime PaymentDate { get; set; }

    public required PaymentPurpose PaymentPurpose { get; set; } 

    public required PaymentMethod PaymentMethod { get; set; } 

    public required decimal PaidSum { get; set; }

    public required int StudentID { get; set; }

    public virtual Student Student { get; set; } = null!;

    public required int TuitionFeePriceID { get; set; }

    public virtual TuitionFeePrice TuitionFeePrice { get; set;} = null!;
}
