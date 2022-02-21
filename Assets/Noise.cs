using Ludiq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise
{
    public Vector3 position;
    public float intensity;
    public string type;
    public float lifetime;

    public Noise(Vector3 position, float intensity, string type, float lifetime) {
        this.position = position;
        this.intensity = intensity;
        this.type = type;
        this.lifetime = lifetime;
    }
}
