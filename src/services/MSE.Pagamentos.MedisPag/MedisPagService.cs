namespace MSE.Pagamentos.MedisPag
{
    public class MedisPagService
    {
        public readonly string ApiKey;
        public readonly string EncryptionKey;

        public MedisPagService(string apiKey, string encryptionKey)
        {
            ApiKey = apiKey;
            EncryptionKey = encryptionKey;
        }
    }
}