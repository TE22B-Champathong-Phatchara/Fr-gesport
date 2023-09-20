
using System.Runtime.InteropServices.Marshalling;

int num1;
int num2;
int point = 0;
string yn;


Console.WriteLine("This is an experimental.");
Thread.Sleep(3000);
Console.WriteLine(".");
Thread.Sleep(1000);
Console.WriteLine(".");
Thread.Sleep(1000);
Console.WriteLine(".");
Thread.Sleep(1000);
Console.WriteLine("Do you remember about the 'dark forest'? (Yes/No)");
Console.WriteLine("__________________________");
Console.WriteLine("");
yn = Console.ReadLine().ToLower();

if (yn == "yes")
{
    Console.WriteLine("__________________________");
    Console.WriteLine("Oh, glad to meet you again!");
    Thread.Sleep(2000);
    Console.WriteLine("I'll ask you the questions like last time. However...");
    Thread.Sleep(3000);
    Console.WriteLine("This time will be a bit differet.");
    Thread.Sleep(3000);
}
else if (yn == "no")
{
    Console.WriteLine("__________________________");
    Console.WriteLine("Oh, that's okay.");
    Thread.Sleep(2000);
    Console.WriteLine("There is no reason to go back.");
    Thread.Sleep(2000);
    Console.WriteLine("The only thing you need to know is...");
    Thread.Sleep(3000);

}
else
{
    Console.WriteLine("__________________________");
    Console.WriteLine("There is no loop system here. So, if you wrote text expect the answer...You'll need to restart it!");
}

Console.WriteLine("I'm going to ask you quizzes or riddles.");
Thread.Sleep(2000);
Console.WriteLine("There are three alternatives to choose.");
Thread.Sleep(1000);
Console.WriteLine("All you need to do is just press 1, 2 or 3  and Enter to answer");
Thread.Sleep(2000);
Console.WriteLine("If you answer correctly your score will be +1 while if you answer wrong your score will be -1.");
Thread.Sleep(1000);
Console.WriteLine(".");
Thread.Sleep(1000);
Console.WriteLine(".");
Thread.Sleep(1000);
Console.WriteLine(".");
Thread.Sleep(2000);
Console.WriteLine("Oh, don't try search the answer in Google!");
Thread.Sleep(2000);
Console.WriteLine("Let's start!");
Thread.Sleep(2000);
Console.WriteLine("__________________________");
Console.WriteLine("");
Console.WriteLine("What walks on four legs in the morning, two legs in the afternoon, three legs in the evening, and no legs at night?");
Thread.Sleep(1000);
Console.WriteLine("1) A dog.");
Thread.Sleep(1000);
Console.WriteLine("2) A ghost.");
Thread.Sleep(1000);
Console.WriteLine("3) A man.");
Console.WriteLine("__________________________");
Console.WriteLine("");
num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 1)
{
    Console.WriteLine("__________________________");
    Console.WriteLine("No, wrong answer. -1");
    point = -1;
}
else if (num1 == 2)
{
    Console.WriteLine("__________________________");
    Console.WriteLine("Hey, do the ghost even have legs??. -1");
    point = -1;
}
else if (num1 == 3)
{
    Console.WriteLine("__________________________");
    Console.WriteLine("Correct! Did you just search for the answer from Google? Don't worry, I googled the question too. +1");
    point = +1;
}
else
{
    Console.WriteLine("__________________________");
    Console.WriteLine("There is no loop system here. So, if you wrote the number except 1,2 and 3 or a single letter...You'll need to restart it!");
}
Thread.Sleep(2000);
Console.WriteLine("");
Console.WriteLine("Good job! You point is now: " + point + "!");
Thread.Sleep(1000);
Console.WriteLine("Alright, next question!");
Thread.Sleep(2000);
Console.WriteLine("__________________________");
Console.WriteLine("");
Console.WriteLine("Micke was 13 years old in 1980 and 8 years old in 1985. How is it possible?");
Thread.Sleep(1000);
Console.WriteLine("1) He took the APTX 4869 pill.");
Thread.Sleep(1000);
Console.WriteLine("2) The dates are in BC.");
Thread.Sleep(1000);
Console.WriteLine("3) He was reincarnated.");
Console.WriteLine("__________________________");
Console.WriteLine("");
num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == 1)
{
    Console.WriteLine("__________________________");
    Console.WriteLine("I think you watch too much Detective Conan, but it was a good anime though. -1");
    point--;
}
else if (num2 == 2)
{
    Console.WriteLine("__________________________");
    Console.WriteLine("Corecct! This might be the only reasonable answer... +1");
    point++;
}
else if (num2 == 3)
{
    Console.WriteLine("__________________________");
    Console.WriteLine("WOW! I hope this is the answer of the question! -1");
    point--;
}
else
{
    Console.WriteLine("__________________________");
    Console.WriteLine("There is no loop system here. So, if you wrote the number except 1,2 and 3 or a single letter...You'll need to restart it!");
}
Thread.Sleep(2000);
Console.WriteLine("");
Console.WriteLine("Great! You point is now: " + point + "!");
Thread.Sleep(1000);
Console.WriteLine("Let's move on to the last question! It will be a bit long than others");
Thread.Sleep(2000);
Console.WriteLine("__________________________");
Console.WriteLine("");
Console.WriteLine("A man name 'Micke' was found dead with a cassette recorder in one hand and a gun in the other.");
Thread.Sleep(2000);
Console.WriteLine("When the police came in, they immediately pressed the play button on the cassette.");
Thread.Sleep(2000);
Console.WriteLine("He said 'I have nothing else to live for. I can't go on,' then the sound of a gunshot.");
Thread.Sleep(3000);
Console.WriteLine("After listening to the cassette tape, the police knew that it was not a suicide, but a homicide.");
Thread.Sleep(3000);
Console.WriteLine("How did they know?");
Thread.Sleep(3000);
Console.WriteLine("1) If he were to commit suicide, he wouldn't be able to stop the tape by himself.");
Thread.Sleep(1000);
Console.WriteLine("2) The police is really smart!");
Thread.Sleep(1000);
Console.WriteLine("3) The police recognized that's the voice isn't Micke.");
Console.WriteLine("__________________________");
Console.WriteLine("");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num3 == 1)
{
    Console.WriteLine("__________________________");
    Console.WriteLine("Nice! I think you should be a detective! +1");
    point++;
}
else if (num3 == 2)
{
    Console.WriteLine("__________________________");
    Console.WriteLine("Correct! The police was really smart but you're jusat dumb! Woohoo! -1");
    point--;
}
else if (num3 == 3)
{
    Console.WriteLine("__________________________");
    Console.WriteLine("How Micke's voice sounds like then? Hmmm...*thinkin' emoji*");
    point--;
}
else
{
    Console.WriteLine("__________________________");
    Console.WriteLine("There is no loop system here. So, if you wrote the number except 1,2 and 3 or a single letter...You'll need to restart it!");
}
Thread.Sleep(2000);
Console.WriteLine("");
Console.WriteLine("Incredible! Your result point is: " + point + "!");













Console.ReadKey();