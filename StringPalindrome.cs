using System;
class StringPalindrome{
	static void Main (String[] args)
	{  
		Console.WriteLine("Enter a string");  
        string s = Console.ReadLine(); 
	    string rev="";
        for (int i = s.Length-1; i >=0; i--) 
        {  
            rev += s[i].ToString();  
        }  
        if (rev == s)  
        {  
            Console.WriteLine("String is Palindrome  ");  
        }  
        else  
        {  
            Console.WriteLine("String is not Palindrome ");  
        } 
	}
}