using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenderCorazonAction : GOAPAction
{
   public VenderCorazonAction() : base()
    {
        Preconditions.Add(new GOAPState("has_venta", false));
        Preconditions.Add(new GOAPState("has_corazon", true));
        Effects.Add(new GOAPState("has_venta", true));
        Effects.Add(new GOAPState("has_corazon", false));
    }
}
