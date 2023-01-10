// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using Gradebook;

var book = new Book("Lee's Grade Book");
book.AddGrade(12.7);
book.AddGrade(10.3);
book.AddGrade(6.11);
book.AddGrade(4.1);
book.AddGrade(56.1);
book.getStats();
