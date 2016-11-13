using System.ComponentModel.DataAnnotations;
 
namespace demowebapi.Models
{
 public class TodoItem
 {
 [Key]
 public int TodoId { get; set; }
 public string Description { get; set; }
 public string DueDate { get; set; }
 public bool isDone { get; set; }
 }
}
