// 24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
System.Console.Write("Введите X: ");
int x = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введите Y: ");
int y = Int32.Parse(System.Console.ReadLine());
if (x > 0 && y > 0) System.Console.WriteLine("Первая четверть");
if (x < 0 && y > 0) System.Console.WriteLine("Вторая четверть");
if (x < 0 && y < 0) System.Console.WriteLine("Третья четверть");
if (x > 0 && y < 0) System.Console.WriteLine("Четвертая четверть");