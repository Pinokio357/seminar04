int GetNumber(string message)
{
	int result = 0;	
	bool correct = false;
	while(!correct)
		Console.WriteLine(message);
		if(int.TryParse(Console.ReadLine(), out result))
			correct = true;
		else
		   Console.WriteLine("enter correct number");
			
	return (result);
}
int[] array = new int[8];
int i =0;	
for(i=0;i < array.Length; i++)
	{
	array[i] = GetNumber("enter number");
	}
Console.Write($"massiv = ");
for(i=0;i < array.Length; i++)
	{
	Console.Write($"{array[i]},");
	}