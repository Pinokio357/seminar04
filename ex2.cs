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
int number = GetNumber("enter number");
int sum = 0;
int a =0;
while(number > 0)
	a = number % 10;
	number = number / 10;
	sum = sum + a;
	



Console.WriteLine(sum);