using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitchingPlatform : MonoBehaviour
{ 
    [SerializeField] private float _switchRate = 2.0f;
    [SerializeField] private LevelObject _platform; 


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchingCoroutine()); 
    }

  IEnumerator SwitchingCoroutine()
    {
        yield return new WaitForSeconds(_switchRate);
        _platform.setPlatformColor(LevelObject.ObjectColor.Black);
        yield return new WaitForSeconds(_switchRate);
        _platform.setPlatformColor(LevelObject.ObjectColor.White);
        StartCoroutine(SwitchingCoroutine());  
    }
}
