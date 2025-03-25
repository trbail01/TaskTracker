// Class that represents a ToDo list class
public class ToDo {
    public int Id {get; set;}
    public string Description {get; set;} = string.Empty;
    public DateTime? DueDate {get; set;}
    public string Category {get; set;} = string.Empty;
    public string Status {get; set;} = "open";
}