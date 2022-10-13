//Console.Write("Input SpeedFirstFriend");
int SpeedFirstFriend = 15;//Console.ReadLine();

//Console.Write("Input SpeedSecondFriend");
int SpeedSecondFriend = 10;//Console.ReadLine();

//Console.Write("Input SpeedDog");
int SpeedDog = 20;//Console.ReadLine();

//Console.Write("Input Distance ");
int Distance  = 100000;//Console.ReadLine();

//Console.Write("Input LimitDistance");
int LimitDistance= 100;//Console.ReadLine();

int DogCount = 0;
int Dog_Friend = 2;
int Speed = 0;
int  TimeToMeet = 0;

while (Distance  >  LimitDistance)
{
if (Dog_Friend == 1)

    {
      Speed = SpeedSecondFriend + SpeedDog;
      Dog_Friend = 2;
        
    }
    else
    {
       Speed = 	SpeedFirstFriend + SpeedDog;
    Dog_Friend = 1;
    }
    
    TimeToMeet = Distance/Speed;  
    Distance = Distance - TimeToMeet*(SpeedFirstFriend + SpeedSecondFriend);
    DogCount = DogCount + 1;
    

}

Console.WriteLine("Dog run:");
    Console.WriteLine(DogCount );