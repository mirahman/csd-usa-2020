public interface IWorker {
    string ID {get; set;}
    string Name {get; set;}
    string Email {get; set;}
    float MonthlySalary{get; set;}
    float Benefits {get; set;}
    float HourlyRate {get; set;}
    float MonthlyHours {get; set;}
    float CalculateMonthlySalary();
    float CalculateHourlySalary();
}

public class FulltimeWorker : IWorker {
    public string ID {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    public float MonthlySalary{get; set;}
    public float Benefits {get; set;}
    public float HourlyRate {get; set;} // not needed
    public float MonthlyHours {get; set;} // not needed
    public float CalculateMonthlySalary() { return MonthlySalary + Benefits };
    public float CalculateHourlySalary(){throw new NotImplentedException()} // not needed
}

public class ContractWorker : IWorker {
    public string ID {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    public float MonthlySalary{get; set;}
    public float Benefits {get; set;}
    public float HourlyRate {get; set;}
    public float MonthlyHours {get; set;}
    public float CalculateMonthlySalary() {throw new NotImplentedException()};
    public float CalculateHourlySalary(){ return HourlyRate * MonthlyHours}
}

// ISP applied 

public interface IBaseWorker {
    string ID {get; set;}
    string Name {get; set;}
    string Email {get; set;}
}

public interface IFulltimeWorker : IBaseWorker {
    float MonthlySalary{get; set;}
    float Benefits {get; set;}

    float CalculateMonthlySalary();
}

public interface IParttimeWorker : IBaseWorker {
    float MonthlySalary{get; set;}

    float CalculateMonthlySalary();
}

public interface IContractWorker : IBaseWorker {
    float HourlyRate {get; set;}
    float MonthlyHours {get; set;}
    float CalculateHourlySalary();
}

public class FulltimeWorker : IFulltimeWorker {
    public string ID {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    public float MonthlySalary{get; set;}
    public float Benefits {get; set;}

    public float CalculateMonthlySalary() { return MonthlySalary + Benefits };
}

public class ParttimeWorker : IParttimeWorker {
    public string ID {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    public float MonthlySalary{get; set;}

    public float CalculateMonthlySalary() { return MonthlySalary };
}

public class ContractWorker : IContractWorker {
    public string ID {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    
    public float HourlyRate {get; set;}
    public float MonthlyHours {get; set;}

    public float CalculateHourlySalary(){ return HourlyRate * MonthlyHours}
}