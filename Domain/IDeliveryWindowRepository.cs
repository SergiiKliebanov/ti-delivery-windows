using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDeliveryWindowRepository
    {
        Task<IEnumerable<DeliveryWindow>> Get();
    }
}
