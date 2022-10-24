// Ayala Angelica
 // Date Revised: 10/24/22
 // Mini Challenge #8: Guess It

 // --------Description---------
//Declared a data types and variables that will be used
//Asked the user to select a level
//Created an IF statement based on level chosen
///In the IF statement, I created a while loop that will allow the user to input a number until it is correct
//The amount of guesses will also be counted for each level
//When the number is guessed correct, the game will end.


//Peer Reviewed by:
//Date:
//Review:


int guessNumb;
string leVel;
bool isCorrect = false;
int guessCount = 0;


Console.WriteLine("Enter a level (Easy,Medium,Hard).");
leVel = Console.ReadLine().ToUpper();


if(leVel == "EASY")
{
    easyGame();

}

void easyGame()
{
    Random numGen = new Random();
    int number = numGen.Next(1,11);
    
    while(isCorrect == false)
    {
        Console.WriteLine("Guess a number between 1 and 10.");
    guessNumb = Convert.ToInt32(Console.ReadLine());
    guessCount++;

    if(number < guessNumb)
    {
        Console.WriteLine("Your number is too high, guess again.");
    
    }
    else if (number > guessNumb)
    {
        Console.WriteLine("Your number is too low, guess again.");

    }
    else 
    {
        Console.WriteLine("That's right, you win."); 
        isCorrect = true;

        Console.WriteLine("This is the amount of guesses for this game. " + guessCount);
        

    }
    }
    
}


if(leVel == "MEDIUM")
{
    mediumGame();

}

void mediumGame()
{
    Random numGen = new Random();
    int number = numGen.Next(1,52);
    
while(isCorrect == false)
{

    Console.WriteLine("Guess a number between 1 and 51.");
    guessNumb = Convert.ToInt32(Console.ReadLine());
    guessCount++;
    if(number < guessNumb)
    {
        Console.WriteLine("Your number is too high, guess again.");
    
    }
    else if (number > guessNumb)
    {
        Console.WriteLine("Your number is too low, guess again.");

    }
    else 
    {
        Console.WriteLine("That's right, you win.");
        isCorrect = true;
    }
    Console.WriteLine("This is the amount of guesses for this game. " + guessCount);
    }
    
}

if(leVel == "HARD")
{
    hardGame();

}

void hardGame()
{
    Random numGen = new Random();
    int number = numGen.Next(1,101);

    while(isCorrect == false)
    { 
        Console.WriteLine("Guess a number between 1 and 100.");
        guessNumb = Convert.ToInt32(Console.ReadLine());
        guessCount++;
        if(number < guessNumb)
        {
        Console.WriteLine("Your number is too high, guess again.");
        }
        else if (number > guessNumb)
        {
        Console.WriteLine("Your number is too low, guess again.");
         }
         else 
         {
        Console.WriteLine("That's right, you win.");
        isCorrect = true;
         }
         Console.WriteLine("This is the amount of guesses for this game. " + guessCount);
    }
   
    
}





