using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrays
{
class ArraySample4
{
static void Main(string[] args)
{
    string[] dizi_ = new string[5];
    string str_;

    int index = 0;

    dizi_.SetValue("kamil", 0);
    dizi_.SetValue("Sinan",1);
    dizi_.SetValue("zülfü",2);
    dizi_.SetValue("Cengiz",3);
    dizi_.SetValue("ali",4);

    Console.WriteLine("Aranacak yazı : ");
    str_ = Console.ReadLine();

    Array.Sort(dizi_);


index = Array.BinarySearch(dizi_, str_);
if (index <= -1)
Console.WriteLine("Yazılı Bulunamadı…");
else
Console.WriteLine("{0}. indekste bulundu",index);
Console.ReadLine();
}
}
}

