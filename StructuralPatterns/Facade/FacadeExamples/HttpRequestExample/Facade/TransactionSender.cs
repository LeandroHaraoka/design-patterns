using HttpRequestExample.Subsystems;

namespace HttpRequestExample.Facade
{
    public interface ITransactionSender
    {
        TransactionStatus Send(Transaction transaction);
    }

    public class TransactionSender : ITransactionSender
    {
        private readonly HttpRequestMessageBuilder _httpRequestMessageBuilder;
        private readonly TransactionsClient _transactionsClient;
        private readonly HttpResponseMessageReader _httpResponseMessageReader;

        public TransactionSender()
        {
            // In a real world scenario it would be dependency injection.
            _httpRequestMessageBuilder = new HttpRequestMessageBuilder();
            _transactionsClient = new TransactionsClient();
            _httpResponseMessageReader = new HttpResponseMessageReader();
        }

        public TransactionStatus Send(Transaction transaction)
        {
            var requestMessage = _httpRequestMessageBuilder.Build();
            var responseMessage = _transactionsClient.Send(requestMessage);
            var transactionResponse = _httpResponseMessageReader.Read<TransactionStatus>(responseMessage);
            return transactionResponse;
        }
    }
}
