using BackGroundServiceMessage.Models;

namespace BackGroundServiceMessage.Services
{
    public interface IDataService
    {
        IEnumerable<Message> GetAll();
        void Add(Message message);
    }
}
