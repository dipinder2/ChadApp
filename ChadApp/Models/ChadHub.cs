using Microsoft.AspNetCore.SignalR;

namespace ChadApp.Models;


public class ChadHub: Hub
{
    private readonly ILogger _logger;

    public ChadHub(ILogger logger)
    {
        _logger = logger;
    }
    public override async Task OnConnectedAsync()
    {
       _logger.LogInformation("Someone Connected");
        await base.OnConnectedAsync();
    }

    public async Task OnMsg1(string user,string msg)
    {
        Console.Write(msg);
        await Clients.All.SendAsync("OnMsgRec",msg);
        
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        Console.Write("User Disconnected");
        await base.OnDisconnectedAsync(exception);
    }

    public async Task onMsg()
    {
        Console.WriteLine(Context.User);
    }
    
    
}