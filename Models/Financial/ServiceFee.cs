using University.Web.Models.Core_Organizational;

namespace University.Web.Models.Financial;

public partial class ServiceFee
{
    public int ID { get; set; }

    public required string AcademicYear { get; set; } 

    public required int MajorID { get; set; }

    public required decimal LaboratoryMaterialsFee { get; set; }

    public required decimal ApplicationFee { get; set; }

    public required decimal GraduationFee { get; set; }

    public required decimal LatePaymentFee { get; set; }

    public required decimal AccommodationDormitoryFee { get; set; }

    public virtual Major Major { get; set; } = null!;

    public virtual ICollection<TuitionFeePrice> TuitionFeePrices { get; set; } = new HashSet<TuitionFeePrice>();
}
