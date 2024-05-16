start();
var correctNr = 0;
void start()
{
    Console.WriteLine("Number is chosen");
    correctNr = getRndNumber();
    Console.WriteLine("Guess the number between 1-100:");
    main();
}


void main()
{

var guess = Convert.ToInt32(Console.ReadLine());
if (guess > correctNr)
{
    Console.WriteLine("Too high. Try again:");
    main();
}else if (guess < correctNr)
{
    Console.WriteLine("Too low. Try again:");
    main();
}
else if(guess == correctNr)
{
    Console.WriteLine("You got it!:)");
    Console.WriteLine("Play again? y=yes/n=no");
    var response = Console.ReadLine();
    if (response == "y")
    {
            start();
    }else if (response == "n")
    {
        Environment.Exit(0);
    }
}
}



int getRndNumber()
{
var rnd = new Random();
return rnd.Next(1,101);
}