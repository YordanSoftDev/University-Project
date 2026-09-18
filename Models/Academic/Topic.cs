namespace University.Web.Models.Academic;

public partial class Topic
{
    public int ID { get; set; }

    public required string TopicName { get; set; } 

    public required string Description { get; set; } 

    public virtual ICollection<Agenda> Agenda { get; set; } = new HashSet<Agenda>();
}
