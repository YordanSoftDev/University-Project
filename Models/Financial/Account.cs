using University.Web.Models.Personnel;
using University.Web.Models.PersonnelDuties;

namespace University.Web.Models.Financial;      

public partial class Account
{
    public int ID { get; set; }

    public required int AccountHolderID { get; set; }

    public required decimal Balance { get; set; }

    public virtual AccountHolder AccountHolder { get; set; } = null!;

    public virtual ICollection<Log> Logs { get; set; } = new HashSet<Log>();
}
