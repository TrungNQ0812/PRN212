using System;
using System.Collections.Generic;

namespace PetShopLibrary.Models;

public partial class Pet
{
    public int PetId { get; set; }

    public string PetType { get; set; } = null!;

    public string PetBreeds { get; set; } = null!;
}
