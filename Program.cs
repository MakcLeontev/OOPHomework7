namespace OOPHomework7
{
    class Program
    {
        public static void Main(string[] args)
        {
            StudentService studentService = new StudentService(
                new List<Student>() {
                    new SmallStudent(),
                    new MiddleStudent(),
                    new HighStudent(),
                    new MiddleStudent()
                }
            );
            studentService.service();
        }
    }
}