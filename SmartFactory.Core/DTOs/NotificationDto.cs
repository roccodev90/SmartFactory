namespace SmartFactory.Core.DTOs;
public class NotificationDto
{

    public string MachineName {get; set;} = string.Empty;
    public DateTime? Timestamp { get; set; } 

    public string Type { get; set; } = string.Empty; 

    public string Message { get; set; } = string.Empty;

    public bool IsRead { get; set; } = false;

    public MachinePredictionDto? MachinePrediction { get; set; }  
}