string userRepeatAnswer;
int selectedNumber;

do
{

    Console.WriteLine("Enter your name below to begin!");
    string userName = Console.ReadLine();
    while (string.IsNullOrEmpty(userName))
    {
        Console.WriteLine("Name cannot be empty. Give it another try.");
        userName = Console.ReadLine();
    }

    Console.WriteLine("Hey " + userName + "! Please enter a number between 1 & 100");
    Console.WriteLine();
    Console.WriteLine();
    string numAsString = Console.ReadLine();

    while (string.IsNullOrEmpty(numAsString))
    {
        Console.WriteLine(userName + "! Please enter a valid input!");
        numAsString = Console.ReadLine();
    }

    while (!int.TryParse(numAsString, out selectedNumber))
    {
        Console.WriteLine("This is not a number " + userName + "! Try again!");
        numAsString = Console.ReadLine();
    }

    while (selectedNumber <= 0 || selectedNumber > 100)
    {
        Console.WriteLine("Please select a valid number between 1 and 100.");
        selectedNumber = int.Parse(Console.ReadLine());
    }

    if (selectedNumber >= 1 && selectedNumber <= 100)
    {
        Console.WriteLine(userName + " selected the number " + selectedNumber);
    }
    if (selectedNumber <= 60 && selectedNumber % 2 != 0 && selectedNumber <= 100)
    {
        Console.WriteLine("Odd and less then 60.");
    }
    if (selectedNumber < 25 && selectedNumber >= 2 && selectedNumber % 2 == 0)
    {
        Console.WriteLine("Even and less than 25.");
    }
    if (selectedNumber <= 60 && selectedNumber >= 26 && selectedNumber % 2 == 0)
    {
        Console.WriteLine("Even and between 26 and 60 inclusive.");
    }
    if (selectedNumber > 60 && selectedNumber % 2 == 0 && selectedNumber <= 100)
    {
        Console.WriteLine("Even and greater then 60.");
    }
    if (selectedNumber > 60 && selectedNumber % 2 != 0)
    {
        Console.WriteLine("Odd and greater then 60.");
    }
    Console.WriteLine("If your would like to continue enter [yes]");
    userRepeatAnswer = Console.ReadLine().ToLower();
    if (userRepeatAnswer == "yes")
    {
        Console.WriteLine("OK. Let's go again!");
    }
    else
    {
        Console.WriteLine("Goodbye.");
        Environment.Exit(0);
    }

} while (userRepeatAnswer == "yes");
