using System;

public class StudentAndTeacherTest
{
    public static void Main()
    {
        Person myPerson = new Person();
        myPerson.Greet();

        Student myStudent = new Student();
        myStudent.SetAge(20);
        myStudent.Greet();
        myStudent.ShowAge();
        myStudent.Study();

        Teacher myTeacher = new Teacher();
        myTeacher.SetAge(35);
        myTeacher.Greet();
        myTeacher.Explain();
    }
}

public class Person
{
    protected int age;

    public void Greet()
    {
        Console.WriteLine("Hello");
    }

    public void SetAge(int n)
    {
        age = n;
    }
}

public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm stdent and I'm studying");
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is {0} years old", age);
    }
}

public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("Teacher");
        Console.WriteLine("I'm explaining");
    }
}