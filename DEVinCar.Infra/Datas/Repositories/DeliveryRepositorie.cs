using DEVinCar.Domain.Models;
using DEVinCar.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Datas.Repositories
{
    public class DeliveryRepositorie : IDeliveryRepositorie
    {
        private readonly DevInCarDbContext _context;
        public DeliveryRepositorie(DevInCarDbContext context)
        {
            _context = context;
        }
        /*public Address ObterPorId(int id)
        {
            return _context.Deliveries.Find(id);
        }*/

      
    }
}

