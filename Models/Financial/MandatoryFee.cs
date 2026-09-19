namespace University.Web.Models.Financial;

public partial class requiredFee
{
    public int ID { get; set; }

    public required string AcademicYear { get; set; }

    public required decimal AdministrativeFee { get; set; }

    public required decimal TehnologyFee { get; set; }

    public required decimal HealthAndWellnesFee { get; set; }

    public required decimal LibraryFee { get; set; }

    public virtual ICollection<TuitionFeePrice> TuitionFeesPrices { get; set; } = new HashSet<TuitionFeePrice>();
}
