using System.Runtime.CompilerServices;
using System.Transactions;

namespace FUNCTION
{
    internal class Program
    {
        //// void method
        //void msg()
        //{
        //    Console.WriteLine("\nSimple msg in void method");
        //}

        ////static method
        //public static void msg2()
        //{
        //    Console.WriteLine("\nStatic method");
        //}

        ////parameterized method
        //public static string fullname(string name1, string name2)
        //{
        //    return $"\nYour fullname is {name1}{name2}";
        //}

        //public static string personaldetails(string FirstName, string LastName, int age)
        //{
        //    return $"\nYour fullname is {FirstName}{LastName} and your age {age}";
        //}

        //class person
        //{
        //    public int Id;
        //    public string FirstName;
        //    public string LastName;
        //    public string @class;
        //    public int age;

        //    public void Detail(int id, string Fname, string lname, string classs, int Age)
        //    {
        //        this.Id = id;
        //        this.FirstName = Fname;
        //        this.LastName = lname;
        //        this.@class = classs;
        //        this.age = Age;

        //        Console.WriteLine($"Student Detail = \n\n id = {id} \n \n Firstname = {Fname} \n \n LastName = {lname} \n \n class = {classs} \n \n age = {Age} \n");
        //    }
        //}

        static void Main(string[] args)
        {
            //    person std = new person();
            //    std.Detail(1, "Zain", "Sarfraz", "CSharp", 22);
            //    Console.WriteLine(std);

            //    Console.WriteLine("Hello, World!");
            //    Program obj1 = new Program();
            //    obj1.msg();
            //    Program.msg2();
            //    //Program.msg2();
            //    //Program.msg2();
            //    //FUNCTION print method 1
            //    Console.WriteLine(Program.fullname("Syed Muhammad Zain", " Sarfraz"));
            //    //FUNCTION print method 2
            //    var result = Program.personaldetails("Syed Muhammad Zain", " Sarfraz", 22);
            //    Console.WriteLine(result);


            //Class1 cl = new Class1();
            //Class1 cl1 = new Class1("Syed Muhammad Zain","Sarfraz");
            //Class1 cl2 = new Class1("Syed Muhammad Zain", "Sarfraz", "22");
            //cl2.FirstName = "Syed Muhammad Zain";
            //cl2.LastName = "Sarfraz";
            //cl2.Age = "22";
            //cl.msg3();
            //cl.num1 = 50;
            //cl.num2 = 40;
            //cl.add();

            manager m = new manager("Zain ", "Sarfraz ", 21, " Manager");
            worker w = new("Zain ", "Sarfraz ", 21);
            overloading ad = new overloading();
            ad.add();
            ad.add(4, 9);
            ad.add(4.7f, 9);
            ad.add(5.5f, 3, 2);

            child2 poly = new child2();
            poly.parent();

        //inheritance
        //Person p = new Person();
        //Emp1 p1 = new Emp1();
        //Emp2 p2 = new Emp2();


        //p1.person_info(22, "Ali", "Male");
        //p1.emp1_info(23, "Akram", "Male");
        //p2.emp2_info(20, "Agha", "Male");

        //p.id = 19;
        //p.name = "Ali";
        //p.gender = "Male";
        //p.person_info();
        //p.id = 20;
        //p.name = "Aliya";
        //p.gender = "Female";
        //p.emp_info();

    }
}
}