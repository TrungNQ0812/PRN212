using System;
using System.Collections.Generic;

namespace PetShopLibrary.Models;

public partial class ServiceUsing
{
    public int AccountId { get; set; }

    public int ServiceId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}
