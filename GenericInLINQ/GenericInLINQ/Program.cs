using System.Collections.Generic;
using System.Linq;

public class Student
{
	public string Name { get; set; }
	public int Age { get; set; }
}

public class Car
{
	public string Name { get; set; }
}

public class Program
{
	public static void Main()
	{
		List<Student> students = new List<Student>();
		//  \-Generic-/				     \-Generic-/
		students.Add(new Student()); // Code đúng
		students.Add(new Car()); // Compile lỗi

		// Lấy học sinh đầu tiên.
		// Compiler tự hiểu kết quả là Student
		Student first = students.First();


		// Thời .NET 1.0, khi generic chưa xuất hiện
		//List students = new List();
		//students.Add(new Student()); // Compile bình thường
		//students.Add(new Car()); // Compile bình thường
		//Student first = (Student)students.First();
		//				  \Ép kiểu/						
	}
}