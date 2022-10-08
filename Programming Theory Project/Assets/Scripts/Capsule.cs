using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHEIRTANCE
public class Capsule : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        ShapeColor = Color.green;
        ShapeName = "Capsule";
        SetColor();
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        textField.text = "This is a " + ColorString + " " + ShapeName + ".";
    }
}
