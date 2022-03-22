using System.ComponentModel.DataAnnotations;

namespace BiblioApp.Data.Entities;

public class Book
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string ShortDescription { get; set; }
    public bool IsHardCover { get; set; }

    // FK

    public string CountryCode { get; set; }
    public Country Country { get; set; }
}

public class Country
{
    [Key]
    public string Code { get; set; }

    public string Name { get; set; }
}