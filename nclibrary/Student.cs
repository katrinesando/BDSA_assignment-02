namespace nclibrary;

public class Student {
    public int id { get; init; }
    public string GivenName { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public DateTime StartDate {get; set;}
    public DateTime EndDate {get; set;}
    public DateTime GraduationDate {get; set;}

    // The status is being set by compating the StartDate, EndDate and GraduationDate with the current date
    //found by DateTime.Now
    //By default if no dates given the status is set to 'Graduated'
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