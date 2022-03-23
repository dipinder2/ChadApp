using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ChadApp.Models;

public class Message
{
    public int Id { get; set;}
    [Required(ErrorMessage="Message Cannot Be Empty!!!")]
    public string? Body { get; set; }
    public DateTime? PostedTime { get; set; } = DateTime.Now;
}