using CirclesObj;
bool runProgram = true;
bool computeData = true;
int count = 0;
Console.WriteLine("Welcome to the Circle Tester");


//double input = double.Parse(Console.ReadLine());
while (runProgram)
{
    while (computeData)
    {

        try
        {
            Console.WriteLine("Enter radius:");

            double input = double.Parse(Console.ReadLine());
            if (input <= 0)
            {
                Console.WriteLine("Enter a number greater than 0");
            }

            else
            {
                Circle myCircle = new Circle(input);
                //myCircle.CalculateCircumference();
                //myCircle.CalculateArea();
                Console.WriteLine(myCircle.CalculateFormattedCircumference());
                Console.WriteLine(myCircle.CalculateFormattedArea());
                count++;
                //  private string FormatNumber(double x) am i suppose to put in the varialbe 'input' inside this parameter?? Not sure.
                break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
    }
    while (true)
    {
        Console.WriteLine("Go again? (y/n)");
        string playAgain = Console.ReadLine().ToLower().Trim();
        if (playAgain == "y")
        {
            break;
        }
        else if (playAgain == "n")
        {
            Console.WriteLine($"You calculated {count} circles.");
            Console.WriteLine("Come back again friend!");
            
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Sorry, you entered a bad input.");
            continue;
        }
    }


}


//Define a member called radius. This member should be private. Not sure why I want radius to be private?
//Continue run program later.

//Circle myCircle = new Circle(input);
//myCircle.CalculateCircumference();
//myCircle.CalculateArea();
//Console.WriteLine(myCircle.CalculateFormattedCircumference()); 
//Console.WriteLine(myCircle.CalculateFormattedArea()); 
