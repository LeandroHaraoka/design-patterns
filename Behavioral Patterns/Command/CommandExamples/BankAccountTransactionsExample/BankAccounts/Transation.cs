using System;

namespace BankAccountTransactionsExample.BankAccounts
{
    public abstract class Transaction
    {
        public readonly BankAccount _bankAccount;
        public readonly char _direction;
        public readonly double _volume;
        public readonly Guid _identifier;

        public Transaction(BankAccount bankAccount, char direction, double volume, Guid identifier)
        {
            _bankAccount = bankAccount;
            _direction = direction;
            _volume = volume;
            _identifier = identifier;
        }

        public void Execute() 
        {
            _bankAccount.ProcessTransation(_direction, _volume);
            Console.WriteLine($"Processing Transaction: {_direction} $ {_volume} ({_identifier})");
        }

        public void Cancel()
        {
            _bankAccount.ProcessTransation(RevertOperand(_direction), _volume);
            Console.WriteLine($"Cancelling Transaction: {_direction} $ {_volume} ({_identifier})");
        }

        private char RevertOperand(char operand)
        {
            if (operand != '+' && operand != '-')
                throw new Exception("Provided invalid operand.");

            return operand == '+' ? '-' : '+';
        }
    }
}
