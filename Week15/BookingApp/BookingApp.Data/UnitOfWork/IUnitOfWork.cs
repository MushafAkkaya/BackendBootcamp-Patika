using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.UnitOfWork
{
    // IDisposable gerektiğinde GarbageCollectoru da kullanıp ram'i temizlememizi sağlayacak.
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync();
        // Kaç kayda etki ettğini geriye döner, o yüzden int tipinde.

        Task BeginTransaction();
        // Task -> Asenkron metotların void'i gibi düşünülebilir.

        Task CommitTransaction();
        // İşlem tamamlandıysa kaydeder.

        Task RollBackTransaction();
        // İşlem sırasında sıkıntı olursa süreci geriye alır.
    }
}
