using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

public class AuctionDto
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public int ReservePrice { get; set; }
    [Required]
    public string Seller { get; set; }
    [Required]
    public string Winner { get; set; }
    [Required]
    public int SoldAmount { get; set; }
    [Required]
    public int CurrentHighBid { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime UpdatedAt { get; set; }
    [Required]
    public DateTime AuctionEnd { get; set; }
    [Required]
    public string Status { get; set; }
    [Required]
    public string Make { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public string Color { get; set; }
    [Required]
    public int Mileage { get; set; }
    [Required]
    public string ImageUrl { get; set; }
}
