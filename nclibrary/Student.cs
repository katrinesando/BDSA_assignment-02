namespace nclibrary;

public class Student {
    public int id { get; init; }
    public string GivenName { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public DateTime StartDate {get; set;}
    public DateTime EndDate {get; set;}
    public DateTime GraduationDate {get; set;}

    public Status status {get{
        
        var now = DateTime.Now;
        if(now <= StartDate){
            return Status.New;
        } else if (now > StartDate && now <=GraduationDate && now<=EndDate){
            return Status.Active;
        } else if (now >= GraduationDate){
            return Status.Graduated;
        } else {
            return Status.Dropout;
        }
    }}
    
    public override string ToString() => $"ID: {id}, Name: {GivenName} {Surname}, {status}";
    // public override string ToString() => $"{id}, {GivenName}{Surname}, {status}, {StartDate}, {EndDate}, {GraduationDate}";

}