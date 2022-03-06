namespace uygulamamiz
{
    public interface ISingletonHizmeti
    {
        Guid GetOperationID();
        int sayacOku();
        void sayfaYenilendi();
    }
}