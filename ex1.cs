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
int a = GetNumber("enter number");
int b = GetNumber("enter degree");


int degree =1;
for(int i = 1; i<= b; i++)
	degree =degree*a;
	
	
	
	
Console.WriteLine(degree);