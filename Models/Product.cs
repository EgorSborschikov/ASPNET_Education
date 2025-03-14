namespace WebApiTestSolution.Models;

/// <summary>
/// Модель данных. Представляет собой таблицу базы данных, где атрибуты указаны в виде свойств
/// </summary>
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}