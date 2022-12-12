using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private bool _sameColorsCollide = true;

    private void Awake()
    {
        switch (_sameColorsCollide) 
        {
            case true:
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("WhiteCharacter"), LayerMask.NameToLayer("BlackObject"), true);
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("WhiteCharacter"), LayerMask.NameToLayer("WhiteObject"), false);
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("BlackCharacter"), LayerMask.NameToLayer("BlackObject"), false);
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("BlackCharacter"), LayerMask.NameToLayer("WhiteObject"), true);
                break;
            case false:
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("WhiteCharacter"), LayerMask.NameToLayer("BlackObject"), false);
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("WhiteCharacter"), LayerMask.NameToLayer("WhiteObject"), true);
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("BlackCharacter"), LayerMask.NameToLayer("BlackObject"), true);
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("BlackCharacter"), LayerMask.NameToLayer("WhiteObject"), false); 
                break;
        }
    }

}
