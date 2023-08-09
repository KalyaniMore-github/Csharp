
namespace ConsoleApp10
{
    internal class Student
    {


       
            public string Name { get; set; }
            public List<int> Grades { get; set; }

            public Student(string name)
            {
                Name = name;
                Grades = new List<int>();
            }
        }

        class Program
        {
            static List<Student> students = new List<Student>();

            static void Main()
            {
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("1. Add a student");
                    Console.WriteLine("2. Add a grade");
                    Console.WriteLine("3. View grades");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice:");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddStudent();
                            break;
                        case "2":
                            AddGrade();
                            break;
                        case "3":
                            ViewGrades();
                            break;
                        case "4":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            static void AddStudent()
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();

                students.Add(new Student(name));

                Console.WriteLine("Student added successfully.");
            }

            static void AddGrade()
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();

                Student student = FindStudent(name);

                if (student != null)
                {
                    Console.WriteLine("Enter grade:");
                    int grade;

                    if (int.TryParse(Console.ReadLine(), out grade))
                    {
                        student.Grades.Add(grade);
                        Console.WriteLine("Grade added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid grade. Please enter a numeric value.");
                    }
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }

            static void ViewGrades()
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();

                Student student = FindStudent(name);

                if (student != null)
                {
                    Console.WriteLine("Grades:");

                    foreach (int grade in student.Grades)
                    {
                        Console.WriteLine(grade);
                    }
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }

            static Student FindStudent(string name)
            {
                return students.Find(s => s.Name == name);
            }
        }



    }

