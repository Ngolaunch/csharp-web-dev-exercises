//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

Console.WriteLine("Hello, Strings!");

string greenEggs = "I would not. I would not, could not with a fox.\r\nI will not eat them in a house..";

string[] andHams = greenEggs.Split(" ");

Console.WriteLine(string.Join(",", andHams));

string[] sentEggs = greenEggs.Split(".");

Console.WriteLine(string.Join(".", sentEggs));
