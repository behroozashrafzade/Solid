namespace Solid._5.Completing_the_Interface_Separation_Principle__ISP_;

public class Notification
{
    private readonly IMessageService _messageService;

    public Notification(IMessageService messageService)

    {
        _messageService = messageService;   
    }


    public void Notify(string message)
    {
        _messageService.SendMessage(message);
    }
}