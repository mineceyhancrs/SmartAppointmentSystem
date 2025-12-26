namespace SmartAppointmentSystem.Models;

public class Appointment
{
    public Customer Customer { get; set; }
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
    public bool IsPaid { get; set; }
}
