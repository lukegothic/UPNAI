using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise
{
    public Vector3 sourcePosition;
    public float intensity;
    public string noiseType;

    public Noise(Vector3 sourcePosition, float intensity, string noiseType) {
        this.sourcePosition = sourcePosition;
        this.intensity = intensity;
        this.noiseType = noiseType;
    }
}
