using BussinessObject.Models;
using DAL;
using TravelDeskNST.BussinessObject.Models;

namespace TravelDeskNST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Program obj = new Program();


           

                Console.WriteLine("Enter your choice");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Add Request");
                ch=int.Parse(Console.ReadLine());   

                switch (ch)
                {
                    case 1:

                        
                        obj.user1();
                        
                        break;
                        case 2:
                    obj.request1();
                        break;
                        default:
                        Console.WriteLine("Wrong Input");
                        break; 

                }

            
            
        }
        public void request1()
        {
            BAL.BAL bal = new BAL.BAL();

            Console.WriteLine("Enter the Current: ");
            string current = Console.ReadLine();
            Console.WriteLine("Enter the Destination:");
            string destination = Console.ReadLine();
            Console.WriteLine("Enter the Travel Date: ");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Enter the Reason: ");
            string reason = Console.ReadLine();
            Console.WriteLine("Enter the No of Persons want to Travel:");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Mode of Travel: ");
            string mode = Console.ReadLine();
            Console.WriteLine("Enter the User Name");
            string username = Console.ReadLine();

            User user = bal.GetUser(username);
            Request request = new Request()
            {
                Starting = current,
                Destination = destination,
                TravelDate = dateTime,
                Reason=reason,
                NoOfPerson=no,
                Mode=mode,
                user=user
            };
            int response = bal.AddRequest(request);
            if(response == 0)
            {
                Console.WriteLine("Record Added");
            }
            else
            {
                Console.WriteLine("Not Added");
            }


        }
        public void user1()
        {

            BAL.BAL DAL = new BAL.BAL();

            Console.WriteLine("Enter Name : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Role");
            string rolename = Console.ReadLine();
            Role role2 = DAL.GetRole(rolename);

            User user = new User()
            {
                FirstName = FirstName,
                LastName = lastName,
                Role = role2

            };
            int response = DAL.AddUser(user);
            if (response == 0)
            {
                Console.WriteLine("User has been Added");
            }
        }

        
    }
}