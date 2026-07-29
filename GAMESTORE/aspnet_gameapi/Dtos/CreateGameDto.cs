using System.ComponentModel.DataAnnotations;

namespace aspnet_gameapi.Dtos;

public record CreateGameDto( 
    [Required]string Name, 
    string Genre, 
    decimal Price, 
    DateOnly ReleaseDate);