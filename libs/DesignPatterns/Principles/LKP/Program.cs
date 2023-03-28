/// <summary>
/// 迪米特法则
/// </summary>
using LKP;

List<Student> students = new List<Student>() { new Student("小明"), new Student("小红") };
List<Class> classes = new List<Class>() { new Class("一班", students), new Class("二班", students) };
School school = new School("杭一中", classes);
school.Introduce();