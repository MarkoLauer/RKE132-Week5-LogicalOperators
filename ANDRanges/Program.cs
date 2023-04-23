//temp <=0 - Freezing cold
//temp >0 And temp <10 - cold
//temp >=10 And temp <15 - chilly
//temp >=15 And temp <20 - warm
//temp >=20 AND temp <30 - hot
//temp >=30 - Boiling hot



//Console.WriteLine("Enter the temperature:");
//int temp = Int32.Parse(Console.ReadLine());

//if(temp >=30)
//{
//    Console.WriteLine("Boling hot.");
//} 
//else if(temp <30 && temp >=20)
//{
//    Console.WriteLine("Hot.");
//}
//else if (temp < 20 && temp >= 15)
//{
//    Console.WriteLine("Warm.");
//}
//else if (temp < 15 && temp >= 10)
//{
//    Console.WriteLine("Chlly.");
//}
//else if (temp < 10 && temp >= 0)
//{
//    Console.WriteLine("Cold.");
//}
//else 
//{
//    Console.WriteLine("Freezing cold.");
//}

using System.ComponentModel.Design;

string userPIN, userName, password;
Console.WriteLine("Enter PIN:");
userPIN = Console.ReadLine();

if (userPIN == "1234")
{
    Console.WriteLine("Enter username:");
    userName = Console.ReadLine();
    Console.WriteLine("Enter password:");
    password = Console.ReadLine();
    if (userName == "admin" && password == "1234")
    {
        Console.Write("Welcom");
    }
    else
    {
        
      Console.WriteLine("invalid credentsials");
        
    }
}

else
{
    Console.WriteLine("invalid pin");
}





