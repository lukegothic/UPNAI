using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprarFlorAction : GOAPAction
{
   public ComprarFlorAction() : base()
    {
        actionName = "ComprarFlor";
        Preconditions.Add(new GOAPState("has_flor", false));
        Preconditions.Add(new GOAPState("has_dinero", true));
        Effects.Add(new GOAPState("has_flor", true));
        //Effects.Add(new GOAPState("has_dinero", false));
    }
}
