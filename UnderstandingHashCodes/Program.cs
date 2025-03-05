namespace UnderstandingHashCodes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Name: ");
            //string NewCandidate = Console.ReadLine();
            //int ID = NewCandidate.Length;

            Student student = new Student(1,"Shefa");
            Student student1 = new Student(2,"Anumita");
            Student student2 = new Student(3, "Aman");
            Student student3 = new Student(3, "Aman");
            
            Console.WriteLine($"Student:{student.ToString()}");
            Console.WriteLine("Student2 and Student 3 are Same?: "+student2.Equals(student3));
            Console.WriteLine($"Student2\'s address: {student2.GetHashCode()} \nStudent 3\'s address:{student3.GetHashCode()}");
      

            Console.WriteLine();

            Console.WriteLine("PRESS ENTER TO TERMINATE");
            Console.ReadKey();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string SName { get; set; }
        public Student(int ID, string Name)
        {
            this.Id = ID;
            this.SName = Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.SName);
        }
        public override bool Equals(object obj)
        {
            if (obj is Student student)
            {
                return this.Id == student.Id && this.SName == student.SName;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Id: {Id} and Name: {SName}";
        }
    }
} 
