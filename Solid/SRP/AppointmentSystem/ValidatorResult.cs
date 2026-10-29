using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsAndSOLIDPrinciples.Solid.SRP.AppointmentSystem;

public class ValidatorResult
{
    public List<string> Errors { get; set; } = new List<string>();
    public bool IsValid => !Errors.Any();
}
