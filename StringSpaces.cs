using System;
class StringSpaces{
	static void Main (String[] args)
	{  
		Console.WriteLine("Enter a string"); 
        string str = Console.ReadLine(); 
		string substr;
		int count =0;
		for(int i =0;i<str.Length;i++)
		{
			substr=str.Substring(i,1);
			if(substr.Equals(" "))
			{
				count+=1;
			}
			
		}
		Console.WriteLine(count);
	}
}