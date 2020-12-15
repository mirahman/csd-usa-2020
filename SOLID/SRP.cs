class Service {
    public void insertStudent(Student student){}
    public void updateStudent(Student student){}
    public void deleteStudent(Student student){}

    public void insertCourse(Course course){}
    public void updateCourse(Course course){}
    public void deleteCourse(Course course){}

    public void EmailNotify(){}
    public void SMSNotification(){}
}

// move to SRP 

class StudentService {
    public void insert(Student student){}
    public void update(Student student){}
    public void delete(Student student){}

    //public void registerForSemester(Student student, Semester semester){}
}

class CourseService {
    public void insert(Course course){}
    public void update(Course course){}
    public void delete(Course course){}
}

class NotificationService {
    public void EmailNotification(){}
    public void SMSNotification(){}
}