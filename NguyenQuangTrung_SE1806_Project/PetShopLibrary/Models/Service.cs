using System;
using System.Collections.Generic;

namespace PetShopLibrary.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public double ServiceCharge { get; set; }
}
