using BankReportsExample.Handlers;
using System;
using System.Text;

namespace BankReportsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Template Method");
            Console.WriteLine("Forex Tradebook Example");
            
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var forwardHandler = new ForwardContractHandler();
            var vanillaOptionHandler = new VanillaOptionHandler();

            forwardHandler.TemplateMethod();
            vanillaOptionHandler.TemplateMethod();
        }
    }
}
