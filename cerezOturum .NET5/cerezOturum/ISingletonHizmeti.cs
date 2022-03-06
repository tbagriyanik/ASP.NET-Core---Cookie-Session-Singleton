using System;

namespace cerezOturum
{
    public interface ISingletonHizmeti
    {
        Guid GetOperationID();
        int sayacOku();
        void sayfaYenilendi();
    }
}