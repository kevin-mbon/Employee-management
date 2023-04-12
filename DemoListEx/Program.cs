using ClsEmployDll;
namespace DemoListEx
{
    class Program
    {
        static List<Employ> employList;
        public static void ShowEmployMain()
        {
            EmployCrud employCrud = new EmployCrud();
            employList =  employCrud.Show();
            Console.WriteLine("lIST OF EMPLOY");
            
            foreach (Employ e in employList)
            {
                
                Console.WriteLine(e);
               
            }
          
        }
        public static void SearchEmployMain()
        {
            int employno;
            Console.WriteLine("entre employ number");
            employno = Convert.ToInt32(Console.ReadLine());
            EmployCrud employCrud = new EmployCrud();
            Employ result = EmployCrud.SearchEmploy(employno);
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("***NOT FOUND****");
            }
        }
        public static void UpdateEmployMain()
        {
            Employ employ = new Employ();
            Console.WriteLine("Enter employ NO ");
            employ.Employno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employ name ");
            employ.Name = Console.ReadLine();
            Console.WriteLine("Enter employ salary ");
            employ.Salary = Convert.ToDouble(Console.ReadLine());

            EmployCrud employCrud = new EmployCrud();
            Console.WriteLine(employCrud.UpdateEmploy(employ));
        }
        public static void DeleteEmployMain()
        {
            int employno;
            Console.WriteLine("Enter employ number");
            employno = Convert.ToInt32(Console.ReadLine());
            EmployCrud employCrud = new EmployCrud();
            Console.WriteLine(employCrud.DeleteEmploy(employno));
        }
        public static void AddEmployInput()
        {
            Employ employ = new Employ();
            Console.WriteLine("Enter employ NO ");
            employ.Employno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employ name ");
            employ.Name = Console.ReadLine();
            Console.WriteLine("Enter employ salary ");
            employ.Salary = Convert.ToDouble(Console.ReadLine());

            EmployCrud employCrud = new EmployCrud();
            Console.WriteLine(employCrud.AddEmploy(employ)) ;
        }
        static void Main(string[] args)
        {
            int printer;
            do
            {
                Console.WriteLine("OPTION");
                Console.WriteLine("-------------------");
                Console.WriteLine("1.ADD EMPLOY");
                Console.WriteLine("2.TO SHOW EMPLOY LIST");
               
                Console.WriteLine("3.TO SEARCH EMPLOY");
                Console.WriteLine("4.TO DELETE EMPLOY");
                Console.WriteLine("5.TO UPDATE EMPLOY");
                Console.WriteLine("6.EXIT");
                Console.WriteLine("ENTER NUMBER OF YOUR CHOICE!");
                printer = Convert.ToInt32(Console.ReadLine());
                switch (printer)
                {
                    case 1:
                        AddEmployInput();
                        break;
                    case 2:
                        ShowEmployMain();
                        break;
                    case 3:
                        SearchEmployMain();
                        break;
                    case 4:
                        DeleteEmployMain();
                        break;
                    case 5:
                        UpdateEmployMain();
                        break;
                    case 6:
                        break;

                    default:
                        Console.WriteLine("invalid selection");
                        break;


                }

            } while (printer != 6);

        }
    }
}   