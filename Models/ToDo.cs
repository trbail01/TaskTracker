// Class that represents a ToDo list class
// Changed stuff from Github directly
public class ToDo {
    public int Id {get; set;}
    public string Description {get; set;} = string.Empty;
    public DateTime? DueDate {get; set;}
    public string Category {get; set;} = string.Empty;
    public string Status {get; set;} = "open";
}
