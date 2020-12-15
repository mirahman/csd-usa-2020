using System;

class Student {

    private string _type;

    public void Introduce() {
        if(_type.equals("highschool")) {
            Console.WriteLine("i am a high school student");
        } else if(_type.equals("middleschool")) {
            Console.WriteLine("i am a middle school student");
        } else if(_type.equals("college")) {
            Console.WriteLine("i am a college student");
        } else {
            Console.WriteLine("i am a student");
        }
    }
}

// OCP 

class Student {
    public void Introduce() {
        Console.WriteLine("i am a student");
    }
}

class HighSchoolStudent : Student {
    public override void Introduce() {
        Console.WriteLine("i am a high school student");
    }
}

class CollegeStudent : Student {
    public override void NewIntroduction() {
        Console.WriteLine("i am a college student");
    }
}