namespace midterms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO HAYAHAY CLUB!");
            Console.WriteLine("");
            Console.WriteLine("press any button to continue");
            Console.ReadKey();
            Console.Clear();

            Login();
        }

        public static readonly string password = "101011";

        static void Login()
        {
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine($"Attempts left [{i}]");
                Console.WriteLine("Enter password: "+ password);
                string input1 = Console.ReadLine().Trim();

                if (input1 == password)
                {
                    Console.WriteLine("password match");
                    Console.WriteLine("");
                    Console.WriteLine("press any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Message();
                    break;
                }
                else if (i == 1 && input1 != password)
                {
                    Console.Clear();
                    Console.WriteLine("too many incorrect attempts, exiting program...");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("incorrect password");
                    Console.WriteLine("");
                }
            }
        }

        static void Message()
        {
            Console.WriteLine("--- MAIN MENU ---");
            Console.WriteLine("");
            Console.WriteLine("R = Reservation");
            Console.WriteLine("");
            Console.WriteLine("C = Check Availability");
            Console.WriteLine("");
            Console.WriteLine("T = Transaction Summary");
            Console.WriteLine("");
            Console.WriteLine("Q = Quit");
            Console.WriteLine("");
            Console.Write("Enter choice: ");

            MessageInput();
        }

        static void MessageInput()
        {
            string input1 = Console.ReadLine().Trim().ToUpper();
            char input2 = input1[0];

            switch(input2)
            {
                case 'R':
                    Console.Clear();
                    Reservation();
                    break;
                case 'C':
                    break;
                case 'T':
                    transaction();
                    break;
                case 'Q':
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("invalid input");
                    Console.WriteLine("");
                    Message();
                    break;
            }
        }
        public static string name;
        public static int month;
        public static int days;
        public static int adults;
        public static int children;
        public static int totalPax;
        public static int destination;
        public static double amenities;
        public static char roomChoice;
        public static double roomPrice;
        public static char amenitiesChoice;
        public static double totalTransaction;
        public static int transAmount;

        static void Reservation()
        {
            Console.Write("Name of Customer: ");
            name = Console.ReadLine().Trim();
            Console.WriteLine("");

            Console.WriteLine($"{"Season",-15}Months");
            Console.WriteLine($"{"Lean",-15}Feb, Jun, Jul");
            Console.WriteLine($"{"High",-15}Aug - Oct");
            Console.WriteLine($"{"Peak",-15}Mar - May");
            Console.WriteLine($"{"Super Peak",-15}Nov - Dec");
            Console.WriteLine("");
            Console.Write("Reservation month (EX. 1 = january, 10 = october): ");
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("invalid input...");
                Console.Write("Reservation month (EX. 1 = january, 10 = october): ");
            }
            Console.WriteLine("");

            Console.Write("Number of days staying: ");
            while (!int.TryParse(Console.ReadLine(), out days) || days < 1)
            {
                Console.WriteLine("invalid input...");
                Console.Write("Number of days staying: ");
            }
            Console.WriteLine("");

            Console.Write("Number of adults: ");
            while (!int.TryParse(Console.ReadLine(), out adults) || adults < 1)
            {
                Console.WriteLine("invalid input...");
                Console.Write("Number of adults: ");
            }
            Console.WriteLine("");

            Console.Write("Number of children: ");
            while (!int.TryParse(Console.ReadLine(), out children) || children < 1)
            {
                Console.WriteLine("invalid input...");
                Console.Write("Number of children: ");
            }
            Console.WriteLine("");

            totalPax = adults + children;
            if (totalPax <= 2)
            {
                Console.WriteLine("We would recommend getting a standard or a suite room type");
            }
            else if (totalPax <= 3)
            {
                Console.WriteLine("We would recommend getting a deluxe or a suite room type");
            }
            else if (totalPax == 4)
            {
                Console.WriteLine("We would recommend getting a quadruple or a suite room type");
            }
            else if (totalPax <= 5)
            {
                Console.WriteLine("We would recommend getting a quadruple room type");
            }
            else if (totalPax <= 7)
            {
                Console.WriteLine("We would recommend getting a family room type");
            }

            Console.WriteLine($"{"Local",-20}|{"International",5}");
            Console.WriteLine($"{"(S) Siargao",-20}|{"(J) Japan",5}");
            Console.WriteLine($"{"(B) Boracay",-20}|{"(U) USA",5}");
            Console.WriteLine($"{"(E) El Nido Palawan",-20}|{"(G) Germany",5}");
            Console.Write("Where do you want to go?: ");

            string input1 = Console.ReadLine().Trim().ToUpper();
            destination = input1[0];
            Console.WriteLine("");

            Console.WriteLine($"{"Amenities",-15}Fees");
            Console.WriteLine($"{"(S) Pool",-15}300.00/per day");
            Console.WriteLine($"{"(G) Gym",-15}500.00/per day");
            Console.WriteLine($"(B) Both");
            Console.WriteLine("");
            Console.Write("Input: ");

            input1 = Console.ReadLine().Trim().ToUpper();
            amenitiesChoice = input1[0];
            Console.WriteLine("");

            switch(amenitiesChoice)
            {
                case 'S':
                    amenities = 300;
                    break;
                case 'G':
                    amenities = 500;
                    break;
                case 'B':
                    amenities = 800;
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }

            //local
            if (destination == 'S' || destination == 'B' || destination == 'E')
            {
                //lean season
                if (month == 2 || month == 6 || month == 7)
                {
                    if (totalPax <= 2)
                    {
                        Console.WriteLine($"{"(S) Standard",-15} {2000:n2}");
                        Console.WriteLine($"{"(D) Deluxe",-15} {3000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {4000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {5000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {6000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch(roomChoice)
                        {
                            case 'S':
                                roomPrice = 2000;
                                break;
                            case 'D':
                                roomPrice = 3000;
                                break;
                            case 'Q':
                                roomPrice = 4000;
                                break;
                            case 'F':
                                roomPrice = 5000;
                                break;
                            case 'T':
                                roomPrice = 6000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 3)
                    {
                        Console.WriteLine($"{"(D) Deluxe",-15} {3000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {4000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {5000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {6000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'D':
                                roomPrice = 3000;
                                break;
                            case 'Q':
                                roomPrice = 4000;
                                break;
                            case 'F':
                                roomPrice = 5000;
                                break;
                            case 'T':
                                roomPrice = 6000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 5)
                    {
                        Console.WriteLine($"{"(Q) Quadruple",-15} {4000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {5000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'Q':
                                roomPrice = 4000;
                                break;
                            case 'F':
                                roomPrice = 5000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 7)
                    {
                        Console.WriteLine($"{"(F) Family",-15} {5000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'F':
                                roomPrice = 5000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                }
                //high season
                else if (month >= 8 || month <= 10)
                {
                    if (totalPax <= 2)
                    {
                        Console.WriteLine($"{"(S) Standard",-15} {4000:n2}");
                        Console.WriteLine($"{"(D) Deluxe",-15} {5000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {7000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {9000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {11000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 3)
                    {
                        Console.WriteLine($"{"(D) Deluxe",-15} {5000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {7000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {9000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {11000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 5)
                    {
                        Console.WriteLine($"{"(Q) Quadruple",-15} {7000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {9000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 7)
                    {
                        Console.WriteLine($"{"(F) Family",-15} {9000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'F':
                                roomPrice = 9000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                }
                //peak season
                else if (month >= 3 || month <= 5)
                {
                    if (totalPax <= 2)
                    {
                        Console.WriteLine($"{"(S) Standard",-15} {6000:n2}");
                        Console.WriteLine($"{"(D) Deluxe",-15} {8000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {10000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {12000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {14000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 3)
                    {
                        Console.WriteLine($"{"(D) Deluxe",-15} {8000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {10000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {12000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {14000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 5)
                    {
                        Console.WriteLine($"{"(Q) Quadruple",-15} {10000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {12000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 7)
                    {
                        Console.WriteLine($"{"(F) Family",-15} {12000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                }
                //super peak season
                else if (month == 11 || month == 12 || month == 1)
                {
                    if (totalPax <= 2)
                    {
                        Console.WriteLine($"{"(S) Standard",-15} {9000:n2}");
                        Console.WriteLine($"{"(D) Deluxe",-15} {12000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {15000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {18000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {21000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 3)
                    {
                        Console.WriteLine($"{"(D) Deluxe",-15} {12000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {15000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {18000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {21000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 5)
                    {
                        Console.WriteLine($"{"(Q) Quadruple",-15} {15000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {18000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 7)
                    {
                        Console.WriteLine($"{"(F) Family",-15} {18000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                }
            }
            //international
            if (destination == 'J' || destination == 'U' || destination == 'G')
            {
                //lean season
                if (month == 2 || month == 6 || month == 7)
                {
                    if (totalPax <= 2)
                    {
                        Console.WriteLine($"{"(S) Standard",-15} {2500:n2}");
                        Console.WriteLine($"{"(D) Deluxe",-15} {5000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {7500:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {10000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {12500:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 3)
                    {
                        Console.WriteLine($"{"(D) Deluxe",-15} {5000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {7500:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {10000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {12500:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 5)
                    {
                        Console.WriteLine($"{"(Q) Quadruple",-15} {7500:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {10000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 7)
                    {
                        Console.WriteLine($"{"(F) Family",-15} {10000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                }
                //high season
                else if (month >= 8 || month <= 10)
                {
                    if (totalPax <= 2)
                    {
                        Console.WriteLine($"{"(S) Standard",-15} {4500:n2}");
                        Console.WriteLine($"{"(D) Deluxe",-15} {7000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {9500:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {12000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {14000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 3)
                    {
                        Console.WriteLine($"{"(D) Deluxe",-15} {7000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {9500:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {12000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {14000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 5)
                    {
                        Console.WriteLine($"{"(Q) Quadruple",-15} {9500:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {12000:n2}");
                        Console.WriteLine("Room type:");
                    }
                    else if (totalPax <= 7)
                    {
                        Console.WriteLine($"{"(F) Family",-15} {12000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                }
                //peak season
                else if (month >= 3 || month <= 5)
                {
                    if (totalPax <= 2)
                    {
                        Console.WriteLine($"{"(S) Standard",-15} {6500:n2}");
                        Console.WriteLine($"{"(D) Deluxe",-15} {9000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {11500:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {14000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {16500:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 3)
                    {
                        Console.WriteLine($"{"(D) Deluxe",-15} {9000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {11500:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {14000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {16500:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 5)
                    {
                        Console.WriteLine($"{"(Q) Quadruple",-15} {11500:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {14000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 7)
                    {
                        Console.WriteLine($"{"(F) Family",-15} {14000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                }
                //super peak season
                else if (month == 11 || month == 12 || month == 1)
                {
                    if (totalPax <= 2)
                    {
                        Console.WriteLine($"{"(S) Standard",-15} {10000:n2}");
                        Console.WriteLine($"{"(D) Deluxe",-15} {13000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {16000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {19000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {22000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 3)
                    {
                        Console.WriteLine($"{"(D) Deluxe",-15} {13000:n2}");
                        Console.WriteLine($"{"(Q) Quadruple",-15} {16000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {19000:n2}");
                        Console.WriteLine($"{"(T) Suite",-15} {22000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 5)
                    {
                        Console.WriteLine($"{"(Q) Quadruple",-15} {16000:n2}");
                        Console.WriteLine($"{"(F) Family",-15} {19000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                    else if (totalPax <= 7)
                    {
                        Console.WriteLine($"{"(F) Family",-15} {19000:n2}");
                        Console.WriteLine("Room type:");
                        string input2 = Console.ReadLine().Trim().ToUpper();
                        roomChoice = input2[0];
                        switch (roomChoice)
                        {
                            case 'S':
                                roomPrice = 4000;
                                break;
                            case 'D':
                                roomPrice = 5000;
                                break;
                            case 'Q':
                                roomPrice = 7000;
                                break;
                            case 'F':
                                roomPrice = 9000;
                                break;
                            case 'T':
                                roomPrice = 11000;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;
                        }
                    }
                }
            }

            billing();
        }

        public static void billing()
        {
            string roomName= "";
            switch (roomChoice)
            {
                case 'S':
                    roomName = "standard";
                    break;
                case 'D':
                    roomName = "deluxe";
                    break;
                case 'Q':
                    roomName = "quadruple";
                    break;
                case 'F':
                    roomName = "family";
                    break;
                case 'T':
                    roomName = "suite";
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            string desName = "";
            switch (destination)
            {
                case 'S':
                    desName = "siargao";
                    break;
                case 'B':
                    desName = "boracay";
                    break;
                case 'E':
                    desName = "el nido palawan";
                    break;
                case 'J':
                    desName = "japan";
                    break;
                case 'U':
                    desName = "USA";
                    break;
                case 'G':
                    desName = "germany";
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            string amenName = "";
            switch (amenitiesChoice)
            {
                case 'S':
                    amenName = "Pool";
                    break;
                case 'G':
                    amenName = "Gym";
                    break;
                case 'B':
                    amenName = "Both";
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"total pax: {totalPax}");
            Console.WriteLine($"accomodation:\n" +
                              $"{desName}\n" +
                              $"{roomName} = {roomPrice:n2}\n" +
                              $"{amenName} = {amenities:n2}");

            double total = (roomPrice * days) + (amenities * days);
            totalTransaction += total;
            transAmount++;
            Console.WriteLine($"Total: {total:n2}");
            Console.WriteLine("");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Message();
        }

        public static void transaction()
        {
            Console.WriteLine($"Total sales: {totalTransaction:n2}");
            Console.WriteLine($"number of sales: {transAmount}");
            Console.WriteLine("");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Message();
        }
    }
}
