

Random random = new Random();
bool playagain = true;
int min = 1; // min siffra som man kan gissa
int max = 100; // max siffra som man kan gissa 
int guess; // variabeln lagrar gissningen från användaren
int number; // variabeln håller i numret som användaren måste gissa
int guesses; // variablen håller räkning på antal gissningar
string respons; // variabeln lagrar användarens svar



while (playagain)
{
    guess = 0; //Min gissning börjar med ingen siffra
    guesses = 0; // Spelet börjar med 0 gissningar
    number = random.Next(min, max + 1); // generera en random siffra mellan 1-100 (+1 inkluderar högsta talet i talföljden)
    respons = "";

    while (guess != number) // Min gissning ska aldrig vara samma random nummer som generaras
    {
        Console.WriteLine("Gissa ett nummer mellan " + min + " och " + max + " : ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("gissning: " + guess);

        if (guess > number)
        {
            Console.WriteLine("Gissa lägre!");
        }
        else if (guess < number)
        {
            Console.WriteLine("Gissa högre!");
        }
        else
        {
            Console.WriteLine("Bra gissat!");
        }
        if (guess == number)
        {
            Console.WriteLine("Vill du spela igen? Y/N");
            respons = Console.ReadLine();
        }
        if (respons == "Y")
        {
            playagain = true;
        }
        else
        {
            playagain = false;

        }

    }

}

Console.WriteLine("Hejdå!");

