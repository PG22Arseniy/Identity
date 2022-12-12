using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorSwap : MonoBehaviour
{

    [SerializeField] private Sprite[] _sprites;
    [SerializeField] private float _swapCooldown = 2f;
    [SerializeField] LevelObject.ObjectColor _characterColor = LevelObject.ObjectColor.Black;   
    
    private SpriteRenderer _spriteRenderer;
    private bool _canSwap = true;  


    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>(); 
    }
  
    void SwapColor() 
    {
        // switching color, layer and sprite
        switch (_characterColor)
        {
            case LevelObject.ObjectColor.Black:
                _spriteRenderer.sprite = _sprites[1];
                gameObject.layer = LayerMask.NameToLayer("WhiteCharacter");
                _characterColor = LevelObject.ObjectColor.White;
                break;
            case LevelObject.ObjectColor.White:
                _spriteRenderer.sprite = _sprites[0];
                gameObject.layer = LayerMask.NameToLayer("BlackCharacter"); 
                _characterColor = LevelObject.ObjectColor.Black; 
                break;
            case LevelObject.ObjectColor.Neutral:
              //  _spriteRenderer.sprite = null; 
                gameObject.layer = LayerMask.NameToLayer("Neutral"); 
                break;
            default:
                break;
        }
    }

    void OnSwapColor()  
    {
        if ( _canSwap)
        { 
           Invoke("SwapColor", _swapCooldown);  
        }
    }

    // can't swap inside platform
    private void OnTriggerStay2D(Collider2D collision)
    {  
        _canSwap = false; 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _canSwap = true; 
    }
}
