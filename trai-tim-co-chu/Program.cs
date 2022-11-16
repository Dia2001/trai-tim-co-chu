// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int count = 0;
for (float y = 3f; y > -2f; y -= 0.1f)
{
    for (float x = -2.5f; x < 2.5f; x += 0.04f)
    {
        float a = x * x + y * y - 4f;
        if ((a * a * a - x * x * y * y * y) < -0.0f)
        {
            String str = " ANH YÊU EM NHIỀU ";
            int num = count % str.Length;
            Console.Write(str[num]);
            count++;
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
    Thread.Sleep(100);
}
Console.WriteLine("Dìa văn IT , đại học Quy Nhơn ");
Console.ReadLine();