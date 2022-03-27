using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerFlorAction : GOAPAction
{
   public CogerFlorAction() : base()
    {
        Preconditions.Add(new GOAPState("has_flor", false));
        Effects.Add(new GOAPState("has_flor", true));
    }
}
