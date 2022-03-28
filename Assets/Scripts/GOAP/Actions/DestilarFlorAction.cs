using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestilarFlorAction : GOAPAction
{
   public DestilarFlorAction() : base()
    {
        Preconditions.Add(new GOAPState("has_flor", true));
        Effects.Add(new GOAPState("has_flor", false));
        Effects.Add(new GOAPState("has_corazon", true));
    }
}
