//Brandon Langehennig
//Mini Challenge 9
//Peer Reviewer Name: Zackary
//Review: When the game asked me to play again, I typed in yes and I was caught in an infinite loop.









GameMechanics.GameGreeter();


string greetUser = "yes";

string userInput1 = Console.ReadLine();




do
{
    
Console.WriteLine("Great ask me a question!");
    string userInput2 = Console.ReadLine();




 string[] responses = {"Not likely." ,"Ask me later.","Yes." , "definitely.", "Maybe.", "Doubtful.", "Thinking......", "No.", "Depends."};


Random rnd = new Random();

int randomAnswer = rnd.Next(responses.Length);

string rndAnswer = responses[randomAnswer];


Console.WriteLine(rndAnswer);



Console.WriteLine("Would you like to play again?");


userInput1  = Console.ReadLine();













}while(greetUser == userInput1);

if(greetUser != userInput1);
{
    Console.WriteLine("No worries, have a nice day.");
}