// See https://aka.ms/new-console-template for more information
using BMS_BL;
using System;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hello, World!");
//var got= Movie.Get();
//for i in got{
//    Console.WriteLine(i);
//}

//Movie.Add( { "SSE", "02/11/2023", "kannada"});
//
//Employee.Add("Sricharan", true);

//Employee.Update("Sricharan", "Poovi");
//Employee.Delete("Poovi");
//Movie.Get().ForEach((p) =>
//{
//    Console.WriteLine($"{p.MovieId},{p.MovieName}");
//});

//Console.WriteLine( User.Search("SSE").MovieLang);
Movie.Add(new BMS_EF.Movie { MovieName = "SSE", MovieLang = "kan", ReleaseDate = new DateTime(2010,7,16) });