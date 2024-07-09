using System;
using System.Collections.Generic;

namespace PetShopLibrary.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public int Quantity { get; set; }
}
