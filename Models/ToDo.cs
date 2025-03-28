// Class that represents a ToDo list class
// Changed stuff from Github directly

public enum TaskType {
    Work,
    Home,
    Exercise,
    Shopping,
    Contact
}

public class ToDo {
    public int Id {get; set;}
    public string Description {get; set;} = string.Empty;
    public DateTime? DueDate {get; set;}
    public TaskType Type {get; set;}
    //public string Category {get; set;} = string.Empty;
    public string Status {get; set;} = "open";
}