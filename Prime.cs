using System ;

class Prime 
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter a number :");
		int number = Convert.ToInt32(Console.ReadLine());
		int flag=0;
		for (int i=2;i<=number/2;i++)
		{
			if(number%i==0)
			{
				Console.WriteLine("Not a Prime Number");
				flag=1;
				break;
			}
		
		}
		if(flag==0)
		{
			Console.WriteLine("It is a Prime Number");
		}
	}
}