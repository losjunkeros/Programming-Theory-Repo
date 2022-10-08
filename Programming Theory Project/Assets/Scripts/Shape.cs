using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// INHEIRTANCE
public class Shape : MonoBehaviour
{
    // ENCAPSULATION
    private string m_shapeName;
    private Color m_color;
    private string m_colorString;

    public Text textField;

    public string ColorString
    {
        get { return m_colorString; }
        private set { m_colorString = value; }
    }

    public string ShapeName 
    {
      get { return m_shapeName; }
      protected set { m_shapeName = value; } 
    }

    // ENCAPSULATION WITH DATA VALIDATION
    public Color ShapeColor
    {
        get { return m_color; }
        set {
            if (value != Color.blue && value != Color.green && value != Color.red)
                Debug.LogError("Wrong color, choose blue, green or red!");
            else
            {
                m_color = value;
                ColorToString();
            }
        }
    }

    // POLYMORPHISM
    public virtual void DisplayText()
    {
        textField.text = "Info about choosen shape";
    }

    // ABSTRACTION
    public void SetColor()
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", m_color);
    }

    private void ColorToString()
    {
        if (m_color == Color.green)
        {
            ColorString = "green";
        }
        if (m_color == Color.red)
        {
            ColorString = "red";
        }
        if (m_color == Color.blue)
        {
            ColorString = "blue";
        }
    }
}
