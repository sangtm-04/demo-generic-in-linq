using System.Collections.Generic;
using System.Linq;

public class Student
{
	public string Name { get; set; }
	public int Age { get; set; }
}

public class Program
{
	public static void Main()
	{
		var studentList = new List<Student>();

		var students = studentList.Where(stu => stu.Age > 20);
		//							    \-Lambda Expression--/
		//                          \----------LINQ----------/

		var student = studentList.Where(delegate (Student stu) { return stu.Age > 20; });
		//								\-------------Anonymous function----------------/
		//                         \------------------------LINQ------------------------/
	}
}