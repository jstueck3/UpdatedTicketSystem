// See https://aka.ms/new-console-template for more information

namespace TicketingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "TicketingSystem.txt";
            string status;
            string TicketID;
            string priority;
            string submitter;
            string assigned;
            string watching;

        
    
            {
                // ask user a question
                Console.WriteLine("1) Read Name from file.");
                Console.WriteLine("2) Create TicketID from data.");
                Console.WriteLine("3) Read status from file.");
                Console.WriteLine("4) Create Ticket from data.");
                Console.WriteLine("Enter any other key to exit.");
                Console.WriteLine("Enter any other key to exit.");
                // input response
                
                name = Console.ReadLine();
                status = Console.ReadLine();
                TicketID = Console.ReadLine();

                if (TicketID == "1")
                {
                    // read data from file
                    if (File.Exists(name))
                    {
                        // accumulators needed for TicketID
                        int TicketNumber = 0;
                        int count = 0;
                        // read data from file
                        StreamReader sr = new StreamReader(name);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split('|');
                            // display array data
                            Console.WriteLine("TicketID: {0}, Status: {1}", arr[0], arr[1]);
                            // add to accumulators
                            TicketNumber += arr[1] == "FirstName" ? 4 : arr[1] == "LastName" ? 3 : arr[1] == "Assigned" ? 2 : arr[1] == "Watching" ? 1 : 0;
                            count += 1;
                        }
                        // calculate
                        double GPA = (double)TicketNumber / count;
                        Console.WriteLine("TicketID: {0:N2}", TicketNumber);
                    }
                    else
                    {
                        Console.WriteLine("This is a Bug Ticket!!");
                    }
                }


                else if (TicketID == "2")
                {
                    // create file from data
                    StreamWriter sw = new StreamWriter(name);
                    for (int i = 0; i < 7; i++)
                    {
                        // ask a question
                        Console.WriteLine("Enter a Name? (Y/N)?");
                        // input the response
                        string resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }
                        // prompt for TicketHolders name
                        Console.WriteLine("Enter the TicketStatus.");
                        // save the Person's name
                        string response = Console.ReadLine();
                        // prompt for the TicketName 
                        Console.WriteLine("Enter the TicketName.");
                        // save the TicketNumber
                        string grade = Console.ReadLine().ToUpper();
                        sw.WriteLine("{0}|{1}", name, grade);
                    }
                    sw.Close();
                }
            } while (status == "1" || status == "2");
        }
    }

    Console.WriteLine(Ticket.Display());

    string choice = "";
do
{
  // display choices to user
  Console.WriteLine("1) Add Ticket");
  Console.WriteLine("2) Display All TicketHolders");
  Console.WriteLine("Enter to quit");
  // input selection
  choice = Console.ReadLine();
  logger.Info("User choice: {Choice}", choice);
} while (choice == "1" || choice == "2");


}
   