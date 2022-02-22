using Ludiq;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

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
    /*
    [CustomPropertyDrawer(typeof(Noise))]
    public class NoiseDrawerUIE : PropertyDrawer {
        public override VisualElement CreatePropertyGUI(SerializedProperty property) {
            // Create property container element.
            var container = new VisualElement();

            // Create property fields.
            var position = new PropertyField(property.FindPropertyRelative("position"));
            var intensity = new PropertyField(property.FindPropertyRelative("intensity"));
            var type = new PropertyField(property.FindPropertyRelative("type"), "Fancy Name");
            var lifetime = new PropertyField(property.FindPropertyRelative("lifetime"), "Fancy Name 2");

            // Add fields to the container.
            container.Add(position);
            container.Add(intensity);
            container.Add(type);
            container.Add(lifetime);

            return container;
        }
    }
    */
}
