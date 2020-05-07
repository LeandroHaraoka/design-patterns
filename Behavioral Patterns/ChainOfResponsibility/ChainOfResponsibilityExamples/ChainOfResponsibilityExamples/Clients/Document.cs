using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityExamples.Clients
{
    public class Document
    {
        public DocumentType Type { get; set; }
        public string Value { get; set; }

        public Document(DocumentType type, string value)
        {
            Type = type;
            Value = value;
        }
    }

    public enum DocumentType
    {
        CPF = 1,
        CNPJ = 2
    }
}
