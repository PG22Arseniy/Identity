using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObject : MonoBehaviour
{

    public enum ObjectColor { White, Black, Neutral };
    [SerializeField] private ObjectColor m_objectState = ObjectColor.White;
    
    // changing color for color swaping platforms
    public void setPlatformColor (ObjectColor objectColor)
    {
        m_objectState = objectColor; 
    }
    // Update is called once per frame 
    void Update() 
    {
        // changing material color and layer based on state 
        switch (m_objectState)
        {
            case ObjectColor.White:
                gameObject.layer = LayerMask.NameToLayer("WhiteObject");
                break;
            case ObjectColor.Black:
                gameObject.layer = LayerMask.NameToLayer("BlackObject"); 
                break;
            case ObjectColor.Neutral:
                gameObject.layer = LayerMask.NameToLayer("Neutral"); 
                break;
            default:
                break;      
        }
       

    }

}
