// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

//reserve keywords
/*string @class = "Zain Sarfraz";
Console.WriteLine(@class);*/

//example
//string name = "Zain";
//int age = 20;
//Console.WriteLine("I am " + name + " and I am " + age);
//string Interpolation
//Console.WriteLine($"Hello! I am {name} and I am {age} year old");
//Calculate BMI(body mass index)
//double weight = 50.2,
//    height = 2.45,
//    bmi;

//bmi = weight / (height * height);
//Console.WriteLine($"bmi : {bmi:0.#} \n");

//datatypes
//Sbyte
//sbyte signedbyte = 126;
//Console.WriteLine(signedbyte);
//Console.WriteLine($"the min value of sbyte is {sbyte.MinValue}");
//Console.WriteLine($"the min value of sbyte is {sbyte.MaxValue} \n");

//Byte
//byte unsignedbyte = 255;
//Console.WriteLine(unsignedbyte);
//Console.WriteLine($"the min value of byte is {byte.MinValue}");
//Console.WriteLine($"the min value of byte is {byte.MaxValue} \n");

//Short
//short shortvalue = 32000;
//Console.WriteLine(shortvalue);
//Console.WriteLine($"the min value of short is {short.MinValue}");
//Console.WriteLine($"the min value of short is {short.MaxValue} \n");

//Ushort
//ushort ushortvalue = 65000;
//Console.WriteLine(ushortvalue);
//Console.WriteLine($"the min value of ushort is {ushort.MinValue}");
//Console.WriteLine($"the min value of ushort is {ushort.MaxValue} \n");

//object
//string uni = "Karachi University";
//Console.WriteLine(uni.IndexOf("r").GetType());
//Console.WriteLine(uni[8]);
//Console.WriteLine(uni.GetType());

//Dynamic Datatype
//dynamic number = "2";
//Console.WriteLine(number);

//Var Datatype
//var num = "Zain";
//Console.WriteLine(num);

//Convert into PKR
//Console.WriteLine($"Enter the number");
//var x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(x * 278.59 + "PKR");

//comparison operator
//int a = 4;
//a += 5; //a= a+5

//var b = 14;
//b -= 14;

//Console.WriteLine(a == b);
//Console.WriteLine(b);

//Logical AND Operator(&)

//if(a == b & b == a)
//{
//    Console.WriteLine("both condition are true");

//}
//else
//{
//    Console.WriteLine("false condition");
//}
//Logical Conditional AND Operator(&&)

//if (a == b && b == a)
//{
//    Console.WriteLine("both condition are true");

//}
//else
//{
//    Console.WriteLine("false condition");
//}

//Logical OR Operator

//if (a == b | b == a)
//{
//    Console.WriteLine("both condition are true");

//}
//else
//{
//    Console.WriteLine("false condition");
//}

//json

//var json = """{"Name" : "Zain" , "Age" : "21"}""";
//Console.WriteLine(json);

//var names = "Zain";
//var jsons = $$"""{"Name" : {{names}} , "Age" : "25"}""";
//Console.WriteLine(jsons);

//Console.WriteLine(int.Parse(null));

//Console.WriteLine("Enter Your Age");
//int age = Convert.ToInt32(Console.ReadLine());

//    if(age >= 18)
//{
//    Console.WriteLine("do you have CNIC");
//    bool CNIC = Convert.ToBoolean(Console.ReadLine());
//    if(CNIC)
//    {
//        Console.WriteLine("Mubarak ho bare hogaye");
//    }
//    else
//    {
//        Console.WriteLine("CNIC ban wao papa ko bol kar");
//    }
//}
//else
//{
//    Console.WriteLine("Chal Bay");
//}

//Console.WriteLine("Select Day");
//var day = Convert.ToString(Console.ReadLine());

//if(day == "monday")
//{
//    Console.WriteLine("Chal Yaar Class hai 9 bje");
//}
//else if (day == "tuesday")
//{
//    Console.WriteLine("sota rahy chutti hai");
//}
//else if (day == "wednesday")
//{
//    Console.WriteLine("Chal Yaar phir sy Class hai 9 bje");
//}
//else if (day == "thursday")
//{
//    Console.WriteLine("chutti hai mar moj");
//}
//else if (day == "friday")
//{
//    Console.WriteLine("Chal Yaar again Class hai 9 bje");
//}
//else if (day == "saturday")
//{
//    Console.WriteLine("Chal enjoy kar ");
//}
//else if (day == "sunday")
//{
//    Console.WriteLine("ready rehna kal jana hai ");
//}
//else
//{
//    Console.WriteLine("bhago");
//}

//switch (day)
//{
//    case "Monday":
//        Console.WriteLine("Agaya monday sir dard");
//        break;
//    case "Tuesday":
//        Console.WriteLine("Agaya monday sir dard");
//        break;
//    case "wednesday":
//        Console.WriteLine("Agaya monday sir dard");
//        break;
//    case "Thurday":
//        Console.WriteLine("Agaya monday sir dard");
//        break;
//    case "friday":
//        Console.WriteLine("Agaya monday sir dard");
//        break;
//    case "Saturday":
//        Console.WriteLine("Agaya monday sir dard");
//        break;
//    case "Sunday":
//        Console.WriteLine("Agaya monday sir dard");
//        break;
//    default:
//        Console.WriteLine("Please Enter Correct Day");
//        break;
//}

//ternary Operater

//int x = 10;
//int y = 20;

//string stat = (y > x) ? "Y is greater than X" : "X is greater than Y";
//Console.WriteLine(stat);

//int & string
//object stats = (y > x) ? "Y is greater than X" : "200";
//Console.WriteLine(stats);

//var Zain = "School" ?? "university";
//Console.WriteLine(Zain);

//var Zains = null "university";
//Console.WriteLine(Zains);

//loop while

//int s  = 0;

//while(s <= 5)
//{
//    Console.WriteLine(s);
//    s++;
//}

//do loop
//do
//{
//    Console.WriteLine(s);
//    s++;
//}
//while (s <= 20);

//for loop

// for(int i = 0; i < 20; i++)
//{
//    Console.WriteLine(i);
//}

//break statement

//for (int i = 0; i < 20; i++)
//{
//    if(i == 10)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}

//continue statment

//int sumofOdds = 0;
//for (int i = 0; i < 23; i++)
//{
//    if (i % 2 == 0)
//    {
//        continue;
//    }
//    sumofOdds += i;
//    Console.WriteLine(i);
//}
//    Console.WriteLine("Sum Of odd Number " + sumofOdds);

//int array

//int[] number = new int[4];
//number[0] = 90;
//number[1] = 90;
//number[2] = 90;
//number[3] = 90;

//for (int i = 0;i < 4; i++)
//{
//    Console.WriteLine($"Index {i}). {number[i]}");
//}

//string array
//string[] Names = new string[] {"Syed" , "Zain" , "Sarfraz"};

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"Index {i}). {Names[i]}");
//}

//string[] Name2 = new string[3] { "Syed", "Zain", "Sarfraz" };

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"Index {i}). {Name2[i]}");
//}

//object array
//object[] Name = new object[] { "Syed", "Zain", "Sarfraz",21,42101,"Sohaib" };

//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine($"\nIndex {i}). {Name[i]}");
//}

//object[] Name1 = { "Syed", "Zain", "Sarfraz", 21, 42101, "Sohaib" };

//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine($"\nIndex {i}). {Name1[i]}");
//}

//arraymethod
//Array.Sort(Name);
//Array.Reverse(Name);
//Name1.Min();
//Name2.Max();
//Name.Contains(89);

// 2 Multidaimensions array
//2d array

//int[,] arr2d = 
//{ 
//    {50,50,60,80},
//    {80,90,10,90},
//    {1,2,3,4},
//};

//int row = arr2d.GetLength(0);
//int col = arr2d.GetLength(1);

//for (int i = 0;i < row; i++)
//{
//    for(int j = 0; j < col ; j++)
//    {
//        Console.WriteLine($"index {j}). {arr2d[i,j]}");
//    }
//    Console.WriteLine();
//}

//3d array

//int[,,] arr3d = new int[3,2,4] 
//{
// {
//        {50,50,60,80},
//        {80,90,10,90}, 
// },
// {
//        {50,50,60,80},
//        {80,90,10,90},
// },
// {
//        {50,50,60,80},
//        {80,90,10,90},
// }
//};

//int row = arr3d.GetLength(0);
//int each_row_in_array = arr3d.GetLength(1);
//int col = arr3d.GetLength(2);

//Method 1 for print 
//for (int i = 0;i < row; i++)
//{
//    for(int j = 0; j < each_row_in_array; j++)
//    {
//        for (int k = 0; k < col; k++)
//        {

//            Console.WriteLine($"index {k}). {arr3d[i, j, k]}");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}

//Method 2 for print
//Console.WriteLine("\nForeach loop");

//foreach (var item in arr3d)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("jugged array");

//int[][] jugged = new int[3][];

//jugged[0] = new int[] { 2, 55, 4 };
//jugged[1] = new int[] { 2, 55, 4, 88 };
//jugged[2] = new int[] { 2, 55, 4, 6, 7 };

//int arr = jugged.Length;

//for (int l = 0; l < arr; l++)
//{
//    for (int i = 0; i < jugged[l].Length; i++)
//    {
//        Console.Write(jugged[l][i] + " ");
//    }
//    Console.WriteLine();
//}


////for each loop

//Console.WriteLine("\nForeach jugged");
//foreach (int[] innerArray in jugged)
//{
//    foreach (int value in innerArray)
//    {
//        Console.Write(value + " ");
//    }
//    Console.WriteLine();