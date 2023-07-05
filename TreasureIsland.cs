using System;
class TreasureIsland
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Choose : Left or Right ?"); 
		string direction = Console.ReadLine();
		if(direction.Equals("Left",StringComparison.CurrentCultureIgnoreCase))
		{
			Console.WriteLine("Swim Or Wait ?");
			string SwimWait = Console.ReadLine();
			if(SwimWait.Equals("Wait",StringComparison.CurrentCultureIgnoreCase))
			{
				Console.WriteLine("Choose Door : Red , Yellow OR Blue");
				string door = Console.ReadLine();
				if(door.Equals("Red",StringComparison.CurrentCultureIgnoreCase))
				{
					Console.WriteLine("Game Over : Burned by Fire");
				}
				else if(door.Equals("Yellow",StringComparison.CurrentCultureIgnoreCase))
				{
					Console.WriteLine("Win !");
				}
				else if(door.Equals("Blue",StringComparison.CurrentCultureIgnoreCase))
				{
					Console.WriteLine("Game Over : Eaten by Beasts");
				}
				else
				{
					Console.WriteLine("Game Over");
				}
			}
			else if(SwimWait.Equals("Swim",StringComparison.CurrentCultureIgnoreCase))
			{
				Console.WriteLine("Game Over : Attacked by Trout");
			}
			else
			{
				Console.WriteLine("Invalid Input");
			}
			
		}
		else if(direction.Equals("Right",StringComparison.CurrentCultureIgnoreCase))
		{
			Console.WriteLine("Game Over : Fallen into a Hole");
		}
		else
		{
			Console.WriteLine("Invalid Input");
		}
		
	}
}