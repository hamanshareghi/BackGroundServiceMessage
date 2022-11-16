using System.Collections;
using BackGroundServiceMessage.Models;


namespace BackGroundServiceMessage.Services
{
    public class RecivedMessage : BackgroundService
    {
        ILogger<RecivedMessage> _logger;

        public RecivedMessage(ILogger<RecivedMessage> logger)
        {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                
                //foreach (var item in Data.newList)
                //{
                    
                //}
                //_logger.LogInformation($"Message Id: {newMessage.Id} : {newMessage.Name}  Sent With Status {newMessage.Status}");
                await Task.Delay(2000, stoppingToken);
            }
        }
    }
}
