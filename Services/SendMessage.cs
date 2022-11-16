
using BackGroundServiceMessage.Data;
using BackGroundServiceMessage.Models;


namespace BackGroundServiceMessage.Services
{
    public class SendMessage : BackgroundService
    {

        ILogger<SendMessage> _logger;

        public SendMessage(ILogger<SendMessage> logger)
        {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Message newMessage = new Message()
                {
                    Id = Guid.NewGuid(),
                    Name = Guid.NewGuid().ToString()
                        .Replace("-", "")
                        .Substring(0, 5),

                };

                _logger.LogInformation($"Message Id: {newMessage.Id} : {newMessage.Name}  Sent ");
                await Task.Delay(3000, stoppingToken);
            }

        }
    }
}
