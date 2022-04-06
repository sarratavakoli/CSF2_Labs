namespace StudentLib
{
    public class Student
    {

        //fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float gpa;

        //properties
        public string FirstName //PascalCase
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public float Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }

        //constructors
        public Student(string firstName, string lastName, string id, float gpa) //CamelCase
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }
        public Student() { }

        //methods
        public override string ToString()
        {
            return string.Format(
                "Student\n" + 
                "Name: {0} {1}\n" +
                "ID: {2}\n" +
                "GPA: {3:n2}",
                FirstName, LastName, Id, Gpa);
        }
    }
}