// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Security;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using RonAndKan;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(String[] args)
        {
            QuoteGenorator.KanyeQuote();

            QuoteGenorator.RonQuote();
        }
    }

}
