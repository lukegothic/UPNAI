using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public abstract class GOAPAction : MonoBehaviour
{
    // Component fields
    public string actionName;
    public List<GOAPState> Preconditions;
    public List<GOAPState> Effects;
    // Action fields
    public GameObject executionPlace = null;
    public float executionCost = 1f;
    public float executionTime = 1f;
    
    public GOAPAction() {
        Preconditions = new List<GOAPState>();
        Effects = new List<GOAPState>();
    }
}