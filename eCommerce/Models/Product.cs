using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models;

/// <summary>
/// An individual product for sale in the game store
/// </summary>
public class Product
{
    /// <summary>
    /// The unique identifier for the product
    /// </summary>
    [Key]
    public int ProductID { get; set; } // Primary Key, identity/auto incrementing

    /// <summary>
    /// The face title of the product (eg. "The Legend of Zelda: Ocarina of Time")
    /// </summary>
    [StringLength(50, ErrorMessage = "Title must be 50 characters or less.")]
    public required string Title { get; set; } // Required, Max of 50 characters

    /// <summary>
    /// The sales price of the product in USD
    /// </summary>
    [Range(0, 10_000, ErrorMessage = "Price must be between $0 and $10,000.")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; } // Required, double, $0 - $10,000
}
