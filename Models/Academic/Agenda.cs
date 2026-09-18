using University.Web.Models.Academic.AgendaEnumerations;
using University.Web.Models.PersonnelDuties;

namespace University.Web.Models.Academic;

public partial class Agenda
{
    public int ID { get; set; }

    public required  int TopicID { get; set; }

    public required int MeetingID { get; set; }

    public required int DurationMinutes { get; set; }

    public required Status Status { get; set; }

    public virtual Meeting Meeting { get; set; } = null!;

    public virtual Topic Topic { get; set; } = null!;
}
