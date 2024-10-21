using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models;

public class Blog
{
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Images { get; set; }
}
