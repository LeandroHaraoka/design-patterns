using LoanProposalExample.LoanProposals;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace LoanProposalExample.Handlers
{
    public class SendProposalHandler : LoanProposalHandler
    {
        public override LoanProposal Handle(LoanProposal request)
        {
            Console.WriteLine("\nCreating loan proposal file.\n");

            var filePath = CreatesFilePath();

            using (StreamWriter outputFile = new StreamWriter(filePath, false))
            {
                var serializedRequest = JsonConvert.SerializeObject(request, new StringEnumConverter());
                outputFile.Write(serializedRequest);
            }
            
            return base.Handle(request);
        }

        private string CreatesFilePath()
        {
            var currentDirectiory = Environment.CurrentDirectory;
            var fileDirectory = Path.Combine(currentDirectiory, "Files");
            Directory.CreateDirectory(fileDirectory);

            var today = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
            var fileName = $"{today}Proposal.txt";
            return Path.Combine(fileDirectory, fileName);

        }
    }
}    
