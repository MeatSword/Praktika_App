using System;
using System.Collections.Generic;

namespace prk_25.Models;

public partial class PersonalUserDatum
{
    public int IdPersonal { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Personal? Personal { get; set; }
}
