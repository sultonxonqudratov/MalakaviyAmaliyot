
using _4_Topshiriq;

var order = OrderedList<int>.Create();

order.Add(1);
order.Add(2);
order.Add(3);
order.Add(4);

foreach (var item in order)
{
    Console.WriteLine(item);
}
Console.WriteLine("First Value is :" + order.GetAndRemove());


foreach (var item in order)
{
    Console.WriteLine(item);
}

Console.ReadKey();