namespace WebApiTestSolution.Models;
/// <summary>
/// Модель данных пользователей
/// </summary>
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    // Связь один-ко-многим
    public List<Order> Orders { get; set; }
}