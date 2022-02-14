namespace MSE.Pagamentos.MedisPag
{
    public enum TransactionStatus
    {
        Authorized = 1,
        Paid,
        Refused,
        Chargedback,
        Cancelled
    }
}