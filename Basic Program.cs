using System;
namespace EnergyInc
{
class Program
{
    static void Main(string[]args)
    {
        //changing appearance
        Console.Title = "Energy Inc";

        //declaring varaibles
        int money = 1000;
        int windmill = 0;
        int aff = 0;
        int buildAff;
        //starting conversation
        Console.WriteLine("Hello!New president!\n Welcome to our Energy Inc.\n Here we build energy producing buildings and sell it for money and use it for building more.\n Lets get this loop going and make some money!\nCurrently we only have 1000 money. To take actions press the number presiding the name of action.\nPlease take action:\n 1.Build\n2.End month to earn money.");
        while(aff != 3)
        {
        aff = Convert.ToInt16(Console.ReadLine());
        if(aff == 1)
        {
          buildAff = Build(money,windmill);
          if(buildAff == 1)
          {
            money = money - 1000;
            windmill++;
          }
          goto CheckPoint;
        }
        money = Sell(money,windmill);
        CheckPoint:
        Console.WriteLine("Please take action:\n1.Build\n2.End month\n3.End game");
        }
        Console.WriteLine("OK!\nYour progress:\nWindmills made :"+windmill+"\nMoney saved: "+money+"\nThanks for playing.Visit again.\nWe will soon add new content but for now: Bye!");

        //wait before closing
        Console.ReadKey();
    }
    //creating methods
static int Build(int money,int windmill)
{
 int aff;
 int result = 0;
 Console.WriteLine("So,you want to build something right? We can build a windmill for 1000 money.Take action:\n 1.Windmill\n 2.Nothing");
 aff = Convert.ToInt16(Console.ReadLine());
 if(aff == 1 && money >= 1000)
 {
    money = money - 1000;
    windmill = windmill +1;
    Console.WriteLine("Done! We have built your windmill!\nNow you have "+ windmill + " windmills.");
    result = 1;
 } 
 else
 {
    Console.WriteLine("Sorry! We can't build due to lack of confirmation or money.");
 }
 return result;
}
static int Sell(int money,int windmill)
{ 
int income;
Console.WriteLine("OK,the month has ended and we are calculating our income.Windmills produce 1 electricity which is sold for 100 money");
int electricity = windmill;
income = electricity * 100;
money = money + income;
Console.WriteLine("Here! You have earned " + income + " money and you have " + money +"money.");
return money;
}
} 
}