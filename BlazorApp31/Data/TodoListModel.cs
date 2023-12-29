using System.ComponentModel.DataAnnotations;

namespace BlazorApp31.Data
{
    public class TodoListModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
