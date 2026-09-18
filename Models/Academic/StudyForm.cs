using University.Web.Models.Financial;

namespace University.Web.Models.Academic;

public partial class StudyForm
{
    public int ID { get; set; }

    public required string FormName { get; set; } 

    public required string Description { get; set; } 

    public virtual ICollection<TuitionFeePrice> TuitionFeesPrices { get; set; } = new HashSet<TuitionFeePrice>();
}
