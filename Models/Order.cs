namespace WebApiTestSolution.Models;
/// <summary>
/// Модель данных Заказов
/// </summary>
public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    
    // Связь многие ко многим
    public List<Product> Products { get; set; }
    
    // Связь многие-к-одному
    public int UserId { get; set; }
    public User User { get; set; }
}