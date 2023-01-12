

using ReflectionTask.Models.Implementations;
using ReflectionTask.Models.Instruments;
using ReflectionTask.Service;
MenuService service = new();
repeat:
Console.WriteLine("1.Add instrument");
Console.WriteLine("2.Get all instrument you added");
Console.WriteLine("3.Exit");
Console.Write("Order---");
int.TryParse(Console.ReadLine(), out int order);

switch (order)
{
	case 1:
		Console.Clear();
		service.AddMenu();
		Console.WriteLine("You added new instrument.");
		goto repeat;
		
	case 2:
		Console.Clear();
		Service.GetAllIntruments();
		Console.WriteLine("Here are your instruments.");
		goto repeat;
	case 3:
		return;
	case 0:
		Console.Clear();
		Console.WriteLine("Wrong order try again.");
		goto repeat;
	default:
        Console.Clear();
        Console.WriteLine("Wrong order try again.");
		goto repeat;
}



