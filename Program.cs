double b, h, area;
Console.Write("Enter base: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter height: ");
h = Convert.ToDouble(Console.ReadLine());
area = (b * h) / 2;
Console.WriteLine($"\nÁrea....: {area:N3}");
