using TestConsole.day4;
using System;
using System.Linq;
using TestConsole.day5;
using TestConsole.day7.My;

List<Page> pages = new()
{
    new Page(1, "String1"),
    new Page(2, "String2"),
    new Page(3, "String3"),
    new Page(4, "String4")
};

HistoryBook h1 = new(1, "Thai", pages, 2023);
h1.ReadBook();
h1.Teaching();

h1.Pages.Add(new Page(5, "String5"));
h1.CountPages();