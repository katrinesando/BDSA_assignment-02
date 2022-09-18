namespace Assignment2;

public record ImmutableStudent
{

    public int Id { get; init; }
    public string GivenName { get; init; }

    public string Surname {get; init;}

    public DateTime StartDate {get; init;}

    public DateTime EndDate {get; init;}

    public DateTime GraduationDate {get; init;}
    public Status Status{get {
     // If a student ended their studies before graduation, they must be a dropout
        if (EndDate.CompareTo(GraduationDate) == -1){
            return Status.Dropout;
        }
        // if a students start year is the same a current year, they can only have been studying for a maximum of 6 months, and must therefore be new
        if (StartDate.Year == DateTime.Now.Year){
            return Status.New;
        }
        // If a students GraduationDate is in the past, and they are now a drop out, they must have graduatated
        if (GraduationDate.CompareTo(DateTime.Now) == -1){
            return Status.Graduated;
        }
        return Status.Active;
        }

    }

    public ImmutableStudent(int Id, String GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate){
        this.Id = Id;
        this.GivenName = GivenName;
        this.Surname = Surname;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.GraduationDate = GraduationDate;

    }


}