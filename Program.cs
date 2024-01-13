Random random = new Random();
int secretNumber = random.Next(1, 100);
int guessesMade = 0;
int guessesAllowed = 0;
bool isCorrect = false;
string greeting = "Welcome to Guess the Secret Number! \n Please enter a number for difficulty level: \n 1. Easy \n 2. Medium \n 3. Hard \n 4. Cheater";

Console.WriteLine(greeting);

int difficulty = int.Parse(Console.ReadLine().Trim());
if (difficulty == 1)
{
    Easy();
} else if (difficulty == 2)
{
    Medium();
} else if (difficulty == 3)
{
    Hard();
} else if (difficulty == 4)
{
    Cheater();
}
else
{
    Console.WriteLine("Please enter 1, 2, 3, or 4");
}

while (isCorrect == false && guessesMade < guessesAllowed)
{
    Console.WriteLine($"{(guessesMade == 0 ? $"You have {guessesAllowed} guesses" : $"You have {guessesAllowed - guessesMade} {(guessesAllowed == 1 ? "guess" : "guesses")} left" )} ");
    EnterNumber();
}

void Easy()
{
    guessesAllowed = 8;
}

void Medium()
{
    guessesAllowed = 6;
}

void Hard()
{
    guessesAllowed = 4;
}

void Cheater()
{
    while (isCorrect == false)
    {
        EnterNumber();
    }
}

void EnterNumber()
{
    Console.WriteLine("Enter a number between 1 and 100");

    int guess = int.Parse(Console.ReadLine().Trim());
    guessesMade++;

    if (guess == secretNumber)
    {
        isCorrect = true;
        Console.WriteLine("You guessed correctly!");
    }
    else
    {
        if (guess > secretNumber)
        {
            Console.WriteLine("You guess was too high");
        }
        else
        {
            Console.WriteLine("Your guess was too low");
        }
    }
}