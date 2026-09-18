using System.ComponentModel.DataAnnotations;

namespace University.Web.Models.Academic.AgendaEnumerations
{
    public enum Status
    {
        Pending =0,
        [Display(Name = "In Progress")]
        InProgress = 1,
        Discussed = 2,
        Postponed = 3,
    }
}
