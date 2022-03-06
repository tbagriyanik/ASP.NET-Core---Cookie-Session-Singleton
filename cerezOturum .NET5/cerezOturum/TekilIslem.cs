using System;
using System.Threading.Tasks;

namespace cerezOturum
{
    public class TekilIslem : ISingletonHizmeti
    {
        Guid id;
        int sayac = 0;

        public TekilIslem()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
        public void sayfaYenilendi()
        {
            sayac++;
        }
        public int sayacOku()
        {
            return sayac;
        }
    }
}
