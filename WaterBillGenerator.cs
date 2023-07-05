using System;
class WaterBillGenerator
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter Number of Units Consumed"); 
        int units = Console.Read(); 
		int meter_charge=75;
		int charge=0;
		if(units<0)
		{
			Console.WriteLine("Invalid Output");
		}
		else
		{
			if(units <= 100)
			{
				charge=units*5;
			}
			else
			{
				if(units <= 250)
				{
					charge=units*10;
				}
				else
				{
					charge=units*20;
				}
			}
		}
		int Total_water_bill=charge+meter_charge;
		Console.WriteLine("Total Water Bill is : Rs. "+Total_water_bill);
	}
}