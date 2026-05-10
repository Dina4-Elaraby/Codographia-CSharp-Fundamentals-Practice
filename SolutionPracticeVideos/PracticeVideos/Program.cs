using System.Numerics;
using System.Text;
using System.Threading.Channels;

namespace PracticeVideos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session 04 Bookmarks and Breakpoints
            // can go forward and backward to check Breakpoints from top bar
            //or through view => Bookmarks(ctrl k, ctrl w) to show details  all bookmarks in which file
            //and at which line and can rename Bookmark

            //BreakPoints//
            //can debug line to check any change in code
            #endregion

            #region Session 05 Copy and Paste
            //can show copy history through Edit => show clipboard history(ctrl+shift+v)
            //can get json file and make it class through:Edit=> paste special (paste json as classes)
            //copy formate json then go to file and choose paste json as classes(will make this formate to classes and props)
            #endregion

            #region Session 06 options in visual stadiuo
            //can get visual stadiou installer from vs through => Tools => Get tools => Get Tools and fetures
            // can change items which exist in toolbar through => Tools => customize =>toolbars
            //can show many options which exist in vs through  => Tools => option 

            #endregion

            #region Session 07 Import and Export Settings
            // can make some settings and use it at another device through:Tools=> Import and Export Settings
            //but theme  not include with export setting
            #endregion

            #region Session 09 Integers in C#
            //int num = 4;
            //Console.WriteLine("num is"+num);
            //Console.WriteLine($"num is{num}");
            //num = 8;
            //Console.WriteLine(num);

            #endregion

            #region Session 15 Data types in Depth
            //integer
            /* signed include negative, unsigned postive only(bigger than signed)
             * sbyte range: -128 to 127 ,size: signed   8 bits
             * byte  range:  0   to 255 ,size: unsigned 8 bit why byte is 256 bit as 2(0,1) ^ 8 bit = 256 from 0 to 255
             * int  size: 32 bit range: 2 ^32 = 4 milyar
                   //Floating
             * float range: ....    ,size=4 bytes = 4 * 8 = 65,536 bits, presision: 6 .. 9 dogots after ,
             * 
             */


            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            //Console.WriteLine(byte.MinValue);
            //Console.WriteLine(sbyte.MinValue);

            //byte n = 256; // cannot convert to byte as bigger than size byte
            //int num = 3_000_000_000;// cannot convert long to num
            //uint numm = 3_000_000_000;

            #endregion

            #region Session 16 Value Type VS Reference Type
            /*           
                         //Value Type:
             * it hold value within memory space int n = 6; space in (hard)(memory) save 8 byte for n
             * store value directly in hard
             * int,float,struct,enum
             
           
                         //Reference Type:
             *  store reference(address) of space of value not value
             * class, interface, string
            
             */

            #endregion

            #region Session 17 Var Keyword
            // convert to data type implicit

            //var n = 7; // int
            //var num = 7.0M;//Decimal
            //var numm = 7.0; //double
            //var nummm = 7.0F; //Float
            #endregion

            #region Session 18 String Foramte
            //var mess = string.Format("there are {0} and {1}", "boys", "girls");
            //Console.WriteLine(mess);

            //Console.WriteLine("----------------------------------------------------");
            //var stringBuilderVar = new StringBuilder();
            //stringBuilderVar.AppendFormat("there are {0} and {1}", "boys", "girls");
            //Console.WriteLine(stringBuilderVar);
            //Console.WriteLine(stringBuilderVar.Length);
            //Console.WriteLine(stringBuilderVar.Replace('e','Q'));
            //Console.WriteLine(stringBuilderVar.Insert(5,"tt"));
            //Console.WriteLine("There are {0} and {1}","boys","girls");

            //Console.WriteLine("----------------------------------------------------");
            //var numB = 3;
            //var numG = 6;
            //Console.WriteLine("There are {0} Boys and {1} Girls",numB,numG);

            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Num: {0:N}",90);   //NUM
            //Console.WriteLine("Num: {0:C}",80);   //$
            //Console.WriteLine("Num: {0:P}",0.80); //%
            //Console.WriteLine("Num: {0:D6}",120); // D6 => num contain 6 digits 000120
            //Console.WriteLine("HexaNum: {0:X}",10); // A , 11=>B

            //Console.WriteLine("----------------------------------------------------");
            //var res = 342;
            //Console.WriteLine(res.ToString("D5")); //00342
            //Console.WriteLine(res.ToString("C")); // 342$



            #endregion

            #region Session 19 String InterPolation
            //string b = "boys", g = "girls";
            //Console.WriteLine($"There are {b} and {g}");
            #endregion

            #region Session 20 DateTime
            //Data type from type struct not class
            //DateTime dateTime = new DateTime(2013, 1, 2);
            //Console.WriteLine(dateTime);
            //Console.WriteLine(dateTime.Year);
            //Console.WriteLine(dateTime.Ticks);
            //Console.WriteLine(dateTime.TimeOfDay);
            //Console.WriteLine(dateTime.Kind);
            //Console.WriteLine(dateTime.AddYears(25));

            //DateTime now = DateTime.Now;
            //Console.WriteLine(now);

            //string formateYearTotal = string.Format("Date is {0:yyyy}", dateTime); // 2013
            //string formateYear = string.Format("Date is {0:yy}", dateTime);//13

            //string formateMonthTotal = string.Format("Date is {0:MMMM}", dateTime);//February
            //string formateMonth3 = string.Format("Date is {0:MMM}", dateTime); //Feb
            //string formateMonth = string.Format("Date is {0:MM}", dateTime); //02


            //string formateDayTotal = string.Format("Date is {0:dddd}", dateTime);//Saturday
            //string formateDay = string.Format("Date is {0:dd}", dateTime); //02

            //string formate = string.Format("Date:{0:dd-MM-yyy-dddd HH:mm:ss tt}", now); //23/04/2016 11:01 pm
            //Console.WriteLine(formate);

            #endregion

            #region Session 21 DateOnly and TimeOnly
            //DateOnly
            //DateOnly date = new DateOnly(2002, 02, 22);
            //Console.WriteLine(date);
            //Console.WriteLine(date.ToLongDateString()); // Friday, February 22, 2002
            //Console.WriteLine(date.DayOfYear);
            //Console.WriteLine(date.AddMonths(1).AddYears(2));

            //DateOnly date2 = DateOnly.now; // Not exist
            //var currentdate = DateOnly.FromDateTime(DateTime.Now);
            //Console.WriteLine(currentdate);

            //TimeOnly
            //TimeOnly Get = new TimeOnly(9, 0);
            //TimeOnly Return = new TimeOnly(15, 30);
            //Console.WriteLine(Get);
            //Console.WriteLine(Return);
            //TimeSpan span = Return - Get; // rimespan is struct also
            //Console.WriteLine(span);
            //Console.WriteLine(span.TotalMinutes);

            #endregion

            #region Session 22.Readline - Input From User
            //Console.WriteLine("Enter your name: ");
            //string? name = Console.ReadLine(); // allow null
            //Console.WriteLine("your name is {0}",name);
            //Console.WriteLine($"your name is {name}");
            //Console.WriteLine(string.Format("your name is {0}",name));

            //Console.WriteLine("Enter your current salary and desired Salary");
            //decimal currSalary, DesirSalary;
            //currSalary = decimal.Parse(Console.ReadLine());
            //DesirSalary = decimal.Parse(Console.ReadLine());
            //Console.WriteLine($"Ypur curr salary: {currSalary} and des salary: {DesirSalary}");

            #endregion

            #region Session 23.Date Exercise
            //Take Input from user and get name of your birthday
            //Console.WriteLine("Enter your BirthDate: ");
            //Console.WriteLine("Day");
            //int Day;
            //Day = int.Parse(Console.ReadLine());
            //Console.WriteLine("Month");
            //int month;
            //month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Year");
            //int Year;
            //Year = int.Parse(Console.ReadLine());

            //DateOnly birthdate = new DateOnly(Year, month, Day);
            //Console.WriteLine(birthdate.DayOfWeek); //Tuesday

            //Or

            //Console.WriteLine("Enter your BirthDate: ");
            //DateOnly date2 = DateOnly.Parse(Console.ReadLine());
            //Console.WriteLine(date2);

            //Display birthday in this Formate: Saturday of Month Year 2022
            //Console.WriteLine("birhtdate: {0:dddd-MMMM-yyyy}",birthdate);

            //Console.WriteLine($"Bithdate:{birthdate.DayOfWeek} of Month {birthdate:MMMM} Year {birthdate.Year} ");


            #endregion

            #region Session 24.Rules for Naming Variables
            /*
             * Var must be unique
             * Var contain only letter(a..zA..Z) and digits(0...9) and underscore(_)
             * Var must start with letter or underscore or @, not start with digit
             * var not allowed to named to same name of datatype int int wrong
             * C# is case sensetive Name is not name
             * var not allow to contain WhiteSpace (N ame not allow to name var)
             */
            #endregion

            #region Session 25.Best Practice for Naming a Variables
            /*
             * use UpperCase for Constant  lengthEarth = 115
             * use CamelCase with underscore for private member variables :: _currentSalry
             
                 * Camel Case *
             * Local Variable
             * employeeFirstName
             
                 * Pascale Case *  
             * Namespaces,Classes,Struct,Enum,Function
             * EmployeeFirstName
             
                 * Snake Case *  
             * employee_first_name
              
                 * Kebab Case *  
             * employee-first-name
            
             */

            #endregion

            #region Session 26.Arthmetic Operators
            //int n1 = 9, n2 = 1;
            //Console.WriteLine(n1-n2);
            //Console.WriteLine(n1+n2);
            //Console.WriteLine(n1%n2); // 9 contain 9 ones and reminder 0
            #endregion

            #region Session 27 Precendence of Operators
            //Console.WriteLine(2+2*3); //8
            //Console.WriteLine(2*2+3); //7
            //Console.WriteLine(2*(2+3)); //10



            #endregion

            #region Session 28 Increment and DecremnentOperators
            //Postfix Increment Operator
            //int n = 7;
            //Console.WriteLine(n++); //7
            ////Console.WriteLine(n); // 8 == Console.WriteLine(n++); //8

            ////Prefix Increment Operator
            //int num = 8;
            //Console.WriteLine(++num);//9

            ////Postfix Decrement Operator
            //int n2 = 3;
            //Console.WriteLine(n2--); //3
            //Console.WriteLine(n2);//2

            ////Prefix Decrement Operator
            //int num02 = 5;
            //Console.WriteLine(--num02);//4
            //Console.WriteLine(num02);// 4
            #endregion

            #region Session 29 Operators Precedence Exercise 
            //int n1 = 5, n2 = 6, n3 = 5;
            //Console.WriteLine(4 + ((++n1) * n2) - (++n3) * 2);
            //               (4 + (6 * 6) - 6 * 2) = 4+ 36 -6 * 2 = 4 + 36 - 12 = 28
            #endregion

            #region Session 30.Comparison operators
            //Console.WriteLine(3 == 4);   // no
            //Console.WriteLine(3 > 4);    // no
            //Console.WriteLine(3 < 4);    // true
            //Console.WriteLine(3 >= 4);   // false
            //Console.WriteLine(3 <= 4);   // true
            //Console.WriteLine(3 != 4);   // true
            #endregion

            #region Session 31.Conditional Statements if
            //int n = 7, n2 = 9;
            //if (n < n2)
            //{
            //    Console.WriteLine("n2 > n1");
            //    Console.WriteLine(n);
            //}
            //else if (n > n2)
            //    Console.WriteLine("n1 < n2");
            //else
            //    Console.WriteLine("n1 == n2");

            //Console.WriteLine(n2);
            #endregion

            #region Session 32.Nested if
            //Console.WriteLine("Enter n1: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter n2: ");
            //int n2 = int.Parse(Console.ReadLine());

            //if (n1 == n2) Console.WriteLine("n1 == n2");
            //else
            //{
            //    if(n1 >  n2) Console.WriteLine("n1 > n2");
            //    else Console.WriteLine(" n1 < n2");
            //}
            #endregion

            #region Session 33.Logical Operators
            //Logical AND Operator:
            // n1 t && n1 t == t
            // n1 t && n1 f == f
            // n1 f && n1 t == f
            // n1 f && n1 f == f

            // Logical OR  Operator:
            // n1 t || n1 t == t
            // n1 t || n1 f == t
            // n1 f || n1 t == t
            // n1 f || n1 f == f

            //bool hasLicence = false, knowHow = false;
            //if(hasLicence ==true && knowHow == true)
            //    Console.WriteLine("Good Go");
            //else if(hasLicence == true && knowHow == false)
            //    Console.WriteLine("Wasta");
            //else if(hasLicence == false && knowHow == true)
            //    Console.WriteLine("u need to get licence");
            //else
            //    Console.WriteLine("u must learn then get licence");

            ////OR Operator
            //bool wentForSwim = false, tookShower = false;
            //if(wentForSwim == true || tookShower == true) //==  if(wentForSwim || tookShower )
            //    Console.WriteLine("wet");
            //else
            //    Console.WriteLine("not wet");

            ////Not Operator
            //bool userName = false, email = false, password = false;
            //Console.WriteLine(!email);//true
            //Console.WriteLine(!! email); //false
            //if((userName || email) && password )// && has priority higher than ||
            //    Console.WriteLine("success");
            //else
            //    Console.WriteLine("rejected");
            #endregion

            #region Session 34.Ternary Operator
            // int n1 = 4, n2 = 8;
            // var res = n1 > n2 ? "n1 greater than n2" : "n2 >n1";
            //// var res = n1 > n2 ? n1" : "n2 >n1"; // error
            // Console.WriteLine(res);

            // //////////////////
            // var evenOrOdd = (n1 % 2 == 0) ? "even" : "odd";
            // Console.WriteLine(evenOrOdd);

            // //////////////////
            // Console.WriteLine((n1 %2 == 0)? "even":"odd");

            #endregion

            #region Session 35.Switch Statement
            //var temp = 5D;
            //switch(temp)
            //{
            //    case <= 20:
            //        Console.WriteLine("cold");
            //        break;
            //    case > 30:
            //        Console.WriteLine("hot");
            //        break;
            //    default:
            //        Console.WriteLine("normal");
            //        break;
            //}

            #endregion

            #region Session 36.Switch Statement
            //var degree = 5D;
            //var mess = degree switch
            //{
            //    > 20 => "hot",
            //    < 30 => "cold",
            //    _ => "normal",
            //};
            //Console.WriteLine(mess);
            ////OR
            //Console.WriteLine(degree switch
            //{
            //    > 20 => "hot",
            //    < 30 => "cold",
            //    _ => "normal",
            //});
            #endregion

            #region Session 37.Nullable Types
            //c# 2  assign null to value type
            //c# 8 add null type to reference type

            //int n1 = null; // error not nullable
            //int? n2 = null;  // nullable int
            //Nullable<int> n3 = null; // nullable int
            //var name = ""; // nullable string be default string name

            #endregion

            #region Session 38.Nullable Coalesing Operator
            //double? n1 = null;
            //double total = n1 ?? 0; // assign n1 to total if n1 is null assign 0 else assign n1
            //Console.WriteLine(total);

            //string? mess = null;
            //string res = mess ?? "no mess";
            ////Console.WriteLine(res);
            //Console.WriteLine(mess?? "no mess");// check if mess null print no mess else print value mess
            #endregion

            #region Session 39.TryParse
            //int n = int.Parse(Console.ReadLine());

            //int.TryParse(Console.ReadLine(),out int n);
            //Console.WriteLine((n== 0)? "invalid input":"valid input");
            #endregion

            #region Session 40 Constants
            //const int n = 7;
            //int n = 8; // error 
            #endregion

            #region Session 41.String Manipulation
            //string mess = "  hi, guys, how are you?   ";
            //// ** Trim **
            //Console.WriteLine(mess.Trim());
            //Console.WriteLine(mess.TrimStart());
            //Console.WriteLine(mess.TrimEnd());

            //// ** Indexes **
            //Console.WriteLine(mess[4]);//,

            //// ** UpperCase **
            //Console.WriteLine(mess.ToUpper().Trim());

            //// ** LowerCase **
            //Console.WriteLine(mess.ToLower());

            //// ** Length **
            //Console.WriteLine(mess.Trim().Length);

            //// ** Replace **
            //Console.WriteLine(mess.Replace('a','Q'));

            //// ** Indexof **
            //Console.WriteLine(mess.IndexOf('a')); // if repeat a get first a

            //// ** Last Index of **
            //Console.WriteLine(mess.LastIndexOf('a'));

            //// ** SubString **
            //Console.WriteLine(mess.Substring(4)); // get index that start to make sentence

            //// ** Remove **
            //Console.WriteLine(mess.Remove(8));// return new string start from index 0 to index 8

            //// ** Insert **
            //Console.WriteLine(mess.Trim().Insert(6,"the"));
            //// ** Contains **
            //Console.WriteLine(mess.Contains("the"));
            //Console.WriteLine(mess.Contains('e'));


            #endregion

            #region Session 42. Escape Sequence
            //string name = "dina";
            //Console.WriteLine($"\"{name}\""); // "dina" ,, before each " type \
            //Console.WriteLine($"\"Hi\"{name}\""); // "dina" ,, before each " type \
            //Console.WriteLine("C:\\"); //C:\
            //Console.WriteLine("\a");// special sound
            //Console.WriteLine("Dear manager, \n how r u?"); //Dear manager,
            //                                                //how r u?
            //Console.WriteLine("dina \t develop");
            #endregion

            #region Session 43.Interpolated Verbatim Strings
            //string text = "hi everybody \n what are u doing now?";
            //string verbatimText = @"hi everybody 
            //what are u doing now?";
            //Console.WriteLine(text);
            //Console.WriteLine(verbatimText);
            //Console.WriteLine(@"C:\Users\Downloads\iti");
            //string fileName = "text.txt";
            //Console.WriteLine($@"D:\ITI\MVC\DAY05\{fileName}");
            //Console.WriteLine($@"i send this message to our friends
            //{text}");

            //int num = 4;
            //string concat = "i take " + num + " times this course";
            //string formate = string.Format("i take {0} times this course", num);
            //string interpolate = ($"i take {num} times this course");
            //Console.WriteLine(concat);
            //Console.WriteLine(formate);
            //Console.WriteLine(interpolate);

            #endregion

            #region Session 44.For Loops
            //for(int i =0;i<3;i++)
            //{
            //    Console.WriteLine("\"dina\"");
            //}

            //int num =5, sum = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    sum += i;// == sum = sum+i;
            //}
            //Console.WriteLine(sum);

            //int k = 1;
            //for (; k < 5;)
            //{
            //    Console.WriteLine(k);
            //        k++;
            //}

            //int n = 6;
            //for (;  n> 0; n--)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region Session 45.Infinite ans Multiple Expressions For Loops
            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine(i); //infinite loop, stop even get last num in int
            //}
            //for (byte i = 1; i > 0; i++)
            //{
            //    Console.WriteLine(i); //infinite loop, stop even get last num in byte (255)
            //}
            //for (; ; )
            //{
            //    Console.WriteLine("infinte loop");
            //}
            //for (int i = 0,j=0; i+j < 10; i++,j--)
            //{
            //    Console.WriteLine($"{i}and{j}"); // infinite loop
            //}

            #endregion

            #region Session 46.While and d-while Loops
            // ********************While***********************
            //int i = 1;
            //while(i<10)
            //{
            //    Console.WriteLine(string.Format("hi {0}",i));
            //    i++;
            //}
            ///////////////////////////////////
            //int num = 8;
            //while (num >= 1)
            //{
            //    if (num <= 0)
            //    {
            //        Console.WriteLine("break loop");
            //        break;
            //    }
            //    Console.WriteLine(num);
            //    num--;
            //}

            // ******************** do-While ***********************
            //int i = 0;
            //do
            //{ 
            //    Console.WriteLine(i); // 0 1 2 3 4 5
            //    i++;
            //}
            //while (i < 6);

            #endregion

            #region Session 47.Nested Loops
            //for (int i = 0; i <6; i++)
            //{
            //    Console.WriteLine(i);
            //    for (int j = 1; j < 5; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

            //int u = 0;
            //while(u<2)
            //{
            //    int k = 0;
            //    while(k<3)
            //    {
            //        Console.WriteLine($"u: {u}, k: {k}");
            //        k++;
            //    }
            //    u++;
            //}

            //int i = 1;
            //while(i<10)
            //{

            //    int j = 1;
            //    while(j <10)
            //    {
            //        Console.Write(" *");

            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            #endregion

            #region Session 48.Multiplication Table
            //for(int i =1;i<=12;i++)
            //{
            //    Console.WriteLine("Table "+i);
            //    for(int n = 1;n<=12;n++)
            //    {
            //        Console.WriteLine(i * n);
            //    }
            //}

            //for(int n=1;n<=12;n++)
            //{
            //    Console.WriteLine(string.Format("Table {0}",n));
            //    int i = 1;
            //    while(i<=12)
            //    {
            //        Console.WriteLine(i*n);
            //        i++;
            //    }
            //Console.WriteLine("\n");
            //}

            #endregion

            #region Session 49.Print Triangle Pattern
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine(" ");
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j <i ; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine(" ");
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine(" ");
            //}

            #endregion

            #region Session 50.Exercise Print Shapes
            #region Pyramids of Stars
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j+=2)
            //    {
            //        if(j%2!=0)
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(" ");
            //}

            #endregion

            #region Inverted Pyramid Starts

            #endregion

            #region Hollow Triangle Starts

            #endregion

            #endregion

            #region Session 51.Math Functions
            //double n1 = 3.215;
            //int n2 = 9, n3 = 4;
            //Console.WriteLine("Ceiling "+Math.Ceiling(n1)); // ignore all digits after. and round num => 4 ,,to big number
            //Console.WriteLine($"Ceiling {Math.Ceiling(2.10)}");//3
            //Console.WriteLine($"Ceiling {Math.Ceiling(2.01)}");//3
            //Console.WriteLine($"Ceiling {Math.Ceiling(2.00)}");//2

            //Console.WriteLine("Floor: {0}",Math.Floor(n1));// ignore all digits after. and without round num =>3
            //Console.WriteLine($"Ceiling {Math.Floor(2.10)}");//2
            //Console.WriteLine($"Ceiling {Math.Floor(2.01)}");//2
            //Console.WriteLine($"Ceiling {Math.Floor(2.00)}");//2
            //Console.WriteLine($"Ceiling {Math.Floor(2.99)}");//2

            //Console.WriteLine("Round: {0}",Math.Round(n1)); // ignore all digits after.round num if graeter than or equal 5 => 3
            //Console.WriteLine($"Round two digits: {Math.Round(n1,2)}");// print num with 2 digits
            //Console.WriteLine($"Round : {Math.Round(2.295,2)}");//2.3
            //Console.WriteLine($"Round : {Math.Round(2.268,2)}");//2.27

            //Console.WriteLine($"Trucate: {Math.Truncate(n1)}");//3
            //Console.WriteLine($"Trucate: {Math.Truncate(2.01)}");//2
            //Console.WriteLine($"Trucate: {Math.Truncate(2.01)}");//2
            //Console.WriteLine($"Trucate: {Math.Truncate(2.00)}");//2

            //Console.WriteLine($"abs: {Math.Abs(-2.5)}");
            //Console.WriteLine($"multi: {Math.BigMul(n2,n3)}");
            //Console.WriteLine($"max: {Math.Max(n1,n2)}");
            //Console.WriteLine($"max: {Math.Min(n2,n3)}");

            //Console.WriteLine($"Sqrt: {Math.Sqrt(9)}");
            //Console.WriteLine($"Power: {Math.Pow(2,3)}");
            //Console.WriteLine(Math.PI);
            //Console.WriteLine($"reminder: {Math.DivRem(13,2)}"); // => (6,1)

            #endregion

            #region Session 52.Generating Random Numbers
            //Random rand = new Random();

            //Console.WriteLine(rand.Next(1,13));
            //Console.WriteLine(rand.NextDouble());
            //Console.WriteLine((rand.NextDouble())*10);
            //Console.WriteLine(Math.Round(rand.NextDouble(),2)); //2 digits after ,

            #endregion

            #region Session 53.Array
            // it is structure to represent a fixed length collection of values or objects with same type
            //int[] nums; // declare array 
            //nums = new int[4]; //allocate array in memory
            //nums = new[] { 1, 2, 3 }; // initialize array
            //int[] testArray02 = new int[5]; //allocate array in memory
            //testArray02 = new int[5] { 2,1,3,3,6};//declare, allocate , initialize
            //int[] numbers = { 32, 1, 3, 5, 1 }; //declare and initialize
            //int[] testArray = new[] { 32, 1, 3 }; //declare and initialize

            //var numsArray = new int[7];
            //var colors = new string[] {"red","blue"};

            //int[] numbs = new int[4] { 2, 1, 3 };//error less than size
            //int[] numbs = new int[4] { 2, 1, 3,6,9 };//error exceed size

            //Console.WriteLine(nums[2]);//3
            // Console.WriteLine(nums[7]); // run time error outofrange exceed index size
            //Console.WriteLine(nums);// show namespace that exist array in it
            //colors[1] = "green";//assign value
            //Console.WriteLine(colors[1]);//green
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] weekDays = { "Friday", "saturday", "sunday" };
            //for (int i = 0; i < weekDays.Length; i++)
            //{
            //    Console.WriteLine(weekDays[i]);
            //}

            #endregion

            #region Session 54.Foreach Loops
            //var fruits = new string[] { "mango", "beach", "banana" };
            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            ////problems foreach => cannot follow index of array [i], follow one way ,cannot follow backway
            //foreach (var item in fruits)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Session 55.Traversing 1D Array
            //var genders = new[] { 'f', 'f', 'm', 'm', 'f', 'm', 'm' };
            //int males = 0, females = 0;
            //foreach (var item in genders)
            //{
            //    if (item == 'f') females++;
            //    if (item == 'm') males++;

            //}
            //Console.WriteLine("nums males: "+ males);
            //Console.WriteLine("nums females: "+ females);

            #endregion

            #region Session 56.Find Minimum and maximum element in Array (The Hard Way)
            //int[] nums = { 3, 9, 44,1, 8, 22 };
            //int maxi = nums[0];
            //int mini = nums[0];

            //foreach (var item in nums)
            //{
            //    if (item > maxi)
            //        maxi = item;

            //    if (item < mini)
            //        mini = item;
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > maxi)
            //        maxi = nums[i];
            //    if (nums[i] < mini)
            //        mini = nums[i];

            //}

            //Console.WriteLine(string.Format("maximum num is {0}",maxi));
            //Console.WriteLine(string.Format("minimum num is {0}",mini));

            #endregion

            #region Session 57.Find Minimum and maximum element in Array (The Easy Way)
            //int[] nums = { 3, 9, 44, 1, 8, 22 };
            //Console.WriteLine(nums.Min());
            //Console.WriteLine(nums.Max());

            #endregion

            #region Session 58.Sorting Array using Bubble Sort Algorithm
            //int[] nums = { 3, 1, 2, 7, 22, 91, 32 };
            //int swapTemp;
            //Console.WriteLine("before sor:");
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (i + 1 == nums.Length) break; // Or instead of that make i,j <nums.Length-1
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[i] > nums[i + 1])
            //        {
            //            swapTemp = nums[i + 1]; //swapTemp =1
            //            nums[i + 1] = nums[i]; // 1=3
            //            nums[i] = swapTemp;// 3=1
            //        }
            //    }
            //    Console.WriteLine("process i: "+(i+1));
            //    foreach (var item in nums)
            //    {
            //        Console.Write(item+" ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("after swap: ");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            #endregion

            #region Session 59.Sorting Array (Easy Way)
            //            int[]nums = {3,1,9,4,11,5};
            //            Console.WriteLine("before sort: ");
            //            foreach (var item in nums)
            //            {
            //                Console.Write(item+" ");
            //            }

            //            nums.Sort(); //    ==  Array.Sort(nums);
            //            Console.WriteLine(@" 
            //After sort: ");
            //            foreach (var item in nums)
            //            {
            //                Console.Write(item+" ");
            //            }

            //            Array.Reverse(nums); // == nums.Reverse();
            //            Console.WriteLine($"\nreverse array: ");
            //            foreach (var item in nums)
            //            {
            //                Console.Write(item + " ");
            //            }

            #endregion

            #region Session 60.Multidimensional Array(2D and 3D)
            //1D Array
            //int[]nums = new int[3] { 2,1,7};

            //2D Array 
            //int[,] nums2DArray = new int[2,3] { { 2, 3, 3 }, { 4, 1, 6 }}; // 2 rows, 3 columns
            //int[,] nums2DArrayV2 =  { { 2, 3, 3 }, { 4, 1, 6 },{ 5,9,3} }; // 3 rows, 3 columns

            //Console.WriteLine(nums2DArray[1,2]);//6
            // nums2DArray[0, 2] = 7;
            //Console.WriteLine(nums2DArray[0,2]); //7

            //Console.WriteLine(nums2DArray.Length);
            //Console.WriteLine(nums2DArrayV2.GetLength(0));
            //Console.WriteLine(nums2DArrayV2.GetLength(1));

            //Console.WriteLine("items nums2DArray: ");
            //for (int i = 0; i < nums2DArray.GetLength(0); i++)
            //{
            //    Console.WriteLine("Row:" + (i+1));
            //    for (int j = 0; j < nums2DArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine(nums2DArray[i,j]);
            //    }
            //}

            //Console.WriteLine("items nums2DArrayV2: ");
            //foreach (var item in nums2DArrayV2)
            //{
            //    Console.WriteLine(item);
            //}

            //3D Array

            //int[,,] nums3DArray = new int[2, 2, 3]
            //{
            //    {{ 2,2,2},{ 5,1,8} },//row contain 2 column and each column contain 3 items
            //    {{4,7,6},{1,9,7} }
            //};
            //Console.WriteLine(nums3DArray[0,0,0]);//2
            //Console.WriteLine(nums3DArray[1,0,0]);//4
            //Console.WriteLine(nums3DArray[1,1,2]);//7

            //Console.WriteLine("nums 3D Array with forLoop: ");
            //for (int i = 0; i < nums3DArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < nums3DArray.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < nums3DArray.GetLength(2); k++)
            //        {
            //            Console.WriteLine($"[{i}][{j}][{k}]{nums3DArray[i,j,k]}");
            //        } 
            //    }  
            //}

            //Console.WriteLine("nums 3D Array with foreach:");
            //foreach (var item in nums3DArray)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion

            #region Session 61.Jagged Arrays
            //Jagged Array:

            //int[][] jaggedArray = new int[4][]; // 3 represent numbers of array and always second [] is empty
            //jaggedArray[0] = new int[3] { 4, 1, 3 };
            //jaggedArray[1] = new int[2] { 34, 91};
            //jaggedArray[2] = new int[4] { 9,4, 1, 3 };
            //jaggedArray[3] = new int[1];

            //foreach (var item in jaggedArray[0])
            //{
            //    Console.WriteLine(item);
            //}

            //Array01:

            //jaggedArray[0][0] = 4; //first item in first array in jagged array
            //jaggedArray[0][1] = 14; //second item in first array in jagged array
            //jaggedArray[0][2] = 48; //third item in first array in jagged array

            //foreach (var item in jaggedArray[0])
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(jaggedArray[0]);//namespace of sytem.int32


            //int[][] jaggedArrayV2 =
            //{
            //    new int[2]{4,6},
            //    new int[1]{99},
            //    new int[3]{1,9,3},
            //};
            //Console.WriteLine(jaggedArrayV2[2][1]);//third array second item

            //for (int i = 0; i < jaggedArrayV2.Length; i++)
            //{
            //    Console.WriteLine("array: " + (i+1));
            //    for (int j = 0; j < jaggedArrayV2[i].Length; j++)
            //    {
            //        Console.Write(jaggedArrayV2[i][j]+ " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Session 62.Jagged Multidimensional Array
            //jagged two dim 
            //int[][,] nums = new int[2][,]
            //{
            //    new int[,] {{ 2,3,4 } ,{ 3,7,8} },
            //    new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }
            //};
            //for(int i=0;i<nums.Length;i++) // 2 arrays
            //{
            //    for(int k = 0; k <nums[i].GetLength(0) ;k++) // rows
            //    {
            //        for (int j = 0; j < nums[i].GetLength(1); j++) // colms
            //        {
            //            Console.WriteLine(nums[i][k,j]);

            //        }
            //    }
            //}
            #endregion

            #region Session 63.Ranges And Indices
            //  0-5     1-4     2-3    3-2   4-1   
            //var languages = new string[] { "c#", "java", "ruby", "go", "c++" };
            //var lastLang = languages[languages.Length - 1];//c++
            //or
            //lastLang = languages[^1]; //c++
            //var firstLang = languages[^5];

            //foreach (var item in languages)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("  //////////////////////////////////   ");
            //Copy Array
            //var learedLanges =languages;
            //OR
            //languages.CopyTo(learedLanges); // == learedLanges = languages[^5..^0]; == learedLanges = languages[..];
            //learedLanges = languages[0..3]; // == learedLanges = languages[^5..^2]; => take  items from index 0 to index 2 =>3 items                                                                     
            //learedLanges = languages[^5..^3]; // take items first and second items 
            //foreach (var item in learedLanges)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("  //////////////////////////////////   ");
            //Range is datatype:

            //Range newRange = 0..5;
            //Console.WriteLine(newRange.GetType());
            //Console.WriteLine(newRange.Start);
            //Console.WriteLine(newRange.End);

            //var newLang = languages[newRange];
            //foreach (var item in newLang)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


        }
    }
}
