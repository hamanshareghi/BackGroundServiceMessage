using BackGroundServiceMessage.Data;
using BackGroundServiceMessage.Models;

namespace BackGroundServiceMessage.Services
{
    public class DataService : IDataService
    {
        private Context _context;

        public DataService(Context context)
        {
            _context = context;
        }

        public IEnumerable<Message> GetAll()
        {
            var data = _context.Messages.ToList();
            return data;
        }

        public void Add(Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChangesAsync();
        }
    }
}
