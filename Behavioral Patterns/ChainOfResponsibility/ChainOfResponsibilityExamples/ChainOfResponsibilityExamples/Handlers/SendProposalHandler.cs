using ChainOfResponsibilityExamples.LoanProposals;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ChainOfResponsibilityExamples.Handlers
{
    public class SendProposalHandler : LoanProposalHandler
    {
        public override LoanProposal Handle(LoanProposal request)
        {
            Console.WriteLine("\nCreating loan proposal file.");
            var currentDirectiory = Environment.CurrentDirectory;
            var fileDirectory = Path.Combine(currentDirectiory, "Files");
            Directory.CreateDirectory(fileDirectory);

            var today = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
            var fileName = $"{today}Proposal.txt" ;
            var filePath = Path.Combine(fileDirectory, fileName);
            
            using (StreamWriter outputFile = new StreamWriter(filePath, false))
            {
                outputFile.Write(JsonConvert.SerializeObject(request, new StringEnumConverter()));
            }
            return base.Handle(request);
        }
    }
}
