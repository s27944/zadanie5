namespace zad5.DTOs;

﻿using System.ComponentModel.DataAnnotations;


public record ReplaceAnimalRequest(
    [Required] [MaxLength(200)] string Name,
    [MaxLength(50)] string Description, 
    [Required][MaxLength(200)] string Category, 
    [Required][MaxLength(200)] string Area
);