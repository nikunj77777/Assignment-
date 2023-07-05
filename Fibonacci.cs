using System;
class Fibonacci{
	static void Main (String[] args)
	{
		
		int a=0,b=1,c=0;
		for(int i=0;i<8;i++)
		{
			Console.Write(a);
			c=a+b;
			a=b;
			b=c;
			
		}
		
	
	}
}