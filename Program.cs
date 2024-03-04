namespace uc2
{
    internal class Program
    {

        public static void employeeAttendence()
        {
            Random r = new Random();
            int attendence = r.Next(0, 2);
            if (attendence == 0)
            {
                Console.WriteLine("employee is absent");
            }
            else
            {
                Console.WriteLine("employee is present");
            }
        }
        public static void dailyWage()
        {
            Console.WriteLine("choose the employee company here..\n 1.accenture \n 2.lytx \n 3.amazon");
            int choose = Convert.ToInt32(Console.ReadLine());
            Random random;
            int hour;
            int perhour;
            if (choose == 1)
            {
                Console.WriteLine("accenture provide employee wage of Rs.20 per hour");
                random = new Random();
                hour = random.Next(8);
                perhour = 20;
                Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                Console.ReadLine();
            }else if(choose ==2)
            {
                Console.WriteLine("lytx provide employee wage of Rs.50 per hour");
                random = new Random();
                hour = random.Next(8);
                perhour = 50;
                Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("amazon provide employee wage of Rs.64 per hour");
                random = new Random();
                hour = random.Next(8);
                perhour = 65;
                Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                Console.ReadLine();
            }
            
        }
        public static void partTimeempWage()
        {
            Console.WriteLine("choose the employee company here..\n 1.accenture \n 2.lytx \n 3.amazon");
            int choose = Convert.ToInt32(Console.ReadLine());

           if(choose==1)
            {
                Console.WriteLine("accenture provide employee wage of Rs.20 per hour");
                Console.WriteLine("enter employee working time");
                int hour = int.Parse(Console.ReadLine());
                int perhour = 20;
                switch (hour)
                {
                    case 1:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 2:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 3:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 4:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 5:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 6:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 7:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 8:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;

                }
            }else if(choose==2)
            {
                Console.WriteLine("lytx provide employee wage of Rs.50 per hour");
                Console.WriteLine("enter employee working time");
                int hour = int.Parse(Console.ReadLine());
                int perhour = 50;
                switch (hour)
                {
                    case 1:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 2:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 3:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 4:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 5:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 6:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 7:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 8:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;

                }
            }
            else
            {
                Console.WriteLine("amazon provide employee wage of Rs.65 per hour");
                Console.WriteLine("enter employee working time");
                int hour = int.Parse(Console.ReadLine());
                int perhour = 65;
                switch (hour)
                {
                    case 1:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 2:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 3:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 4:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 5:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 6:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 7:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;
                    case 8:
                        Console.WriteLine($"Employee working time is {hour} hour per day, and employee wage is {hour *perhour}");
                        break;

                }
            }
            Console.WriteLine();
        }
        public static void empWageperMonth()
        {
            Console.WriteLine("choose the employee company here..\n 1.accenture \n 2.lytx \n 3.amazon");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("accenture provide employee wage of Rs.20 per hour");
                int maxhour = 100; //100 hrs per month
                int totalworkingHour = 0;
                while (totalworkingHour<=maxhour)
                {

                    Console.WriteLine("enter employee working hour per day");
                    int hour = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("choose the employee company here..\n 1.accenture  \n 2.lytx \n 3.amazon");
                    int wageperhour = 20; //20 rs per hour

                    totalworkingHour += hour;

                    Console.WriteLine($"employee working time {totalworkingHour} hour, employee wage is Rs.{totalworkingHour*wageperhour} ");

                    Console.WriteLine("press enter to continue");
                }
                Console.WriteLine($"congradulations..emplpyees working day reached to one month... \n total wage for month is reached above Rs.2000");
                
            }
            else if (choose == 2)
            {
                Console.WriteLine("lytx provide employee wage of Rs.50 per hour");
                int maxhour = 120; // 120 hrs per month
                int totalworkingHour = 0;
                while (totalworkingHour<=maxhour)
                {

                    Console.WriteLine("enter employee working hour per day");
                    int hour = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("choose the employee company here..\n 1.accenture  \n 2.lytx \n 3.amazon");
                    int wageperhour = 50; //50 rs per hour

                    totalworkingHour += hour;

                    Console.WriteLine($"employee working time {totalworkingHour} hour, employee wage is Rs.{totalworkingHour*wageperhour} ");

                    Console.WriteLine("press enter to continue\n");
                }
                Console.WriteLine($"congradulations..emplpyees working day reached to one month... \n total wage for month is reached above Rs.6000");
            }
            else
            {
                Console.WriteLine("amazon provide employee wage of Rs.50 per hour");
                int maxhour = 120;   // 120 hrs per month
                int totalworkingHour = 0;
                while (totalworkingHour<=maxhour)
                {

                    Console.WriteLine("enter employee working hour per day");
                    int hour = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("choose the employee company here..\n 1.accenture  \n 2.lytx \n 3.amazon");
                    int wageperhour = 65; //65 rs per hour

                    totalworkingHour += hour;

                    Console.WriteLine($"employee working time {totalworkingHour} hour, employee wage is Rs.{totalworkingHour*wageperhour} ");

                    Console.WriteLine("press enter to continue\n");
                }
                Console.WriteLine($"congradulations..emplpyees working day reached to one month... \n total wage for month is reached above Rs.7800");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage computation program");


           while(true)
            {
                Console.WriteLine("\n\n choose the option to know about employee . \n 1.employee attendence \n 2.dailywage of employee \n 3.part time employee wage \n 4.To calculate wage for month.");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Program.employeeAttendence();
                        break;
                    case 2:
                        Program.dailyWage();
                        break;
                    case 3:
                        Program.partTimeempWage();
                        break;
                    case 4:
                        Program.empWageperMonth();
                        break;
                    default:
                        Console.WriteLine("enter valid option number");
                        break;
                }

            }



        }
    }
}
