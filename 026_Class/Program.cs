namespace _026_Class
{
    class Student
    {
        private string name;
        private int age;
        private string major;

        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"이름 : {name}, 나이 : {age}, 전공 : {major}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("홍길동", 20, "의티");
            std.DisplayInfo();
        }
    }
}
