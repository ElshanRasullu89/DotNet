using HomeWork;
using System.Collections.Specialized;

var canli1 = new Canli();
canli1.Artir = "yumurtlayaraq";
canli1.Deri = "pullu";
canli1.AyagiVar = true;

var canli2 = new Insan()
{
    Artir = "dogaraq",
    Deri = "qismən tüklü",
    AyagiVar = true,
    Name = "MAMED",
    Dil = "Azərbaycan",
    Ixtisas = "IT"
};

Console.WriteLine(canli1.GetDescription());
Console.WriteLine(canli2.GetDescription());
Console.WriteLine(canli2.GetDescription("Dotnet"));