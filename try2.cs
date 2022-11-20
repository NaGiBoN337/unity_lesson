using UnityEngine;
using UnityEngine.UI;

public class try2 : MonoBehaviour
{
    Vector3 m_NewPosition;

    // Attach these in the Inspector window
    public InputField m_InputFieldX, m_InputFieldY;

    // These are the strings that are returned from the InputFields
    string xString, yString;

    // These are used when converting the strings to floats
    float m_XValue, m_YValue;

    // Use this for initialization
    void Start()
    {
        // Initialise the vector
        m_NewPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        // Store the inputs from the InputFields as strings
        xString = m_InputFieldX.text;
        yString = m_InputFieldY.text;

        // Convert the strings from the InputFields to floats
        ConvertStringsToFloats(xString, yString);

        // Change the NewPosition Vector's x and y components
        m_NewPosition.x = m_XValue;
        m_NewPosition.y = m_YValue;

        // Change the position depending on the vector
        transform.position = m_NewPosition;
    }

    void ConvertStringsToFloats(string XVal, string YVal)
    {
        try
        {
            // Convert the strings to floats
            m_XValue = float.Parse(XVal);
            m_YValue = float.Parse(YVal);
        }
        catch { }
    }
}