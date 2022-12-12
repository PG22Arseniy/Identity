using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Harmful")
        {
            Reload(); 
        }
    }
    private void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (FellDown())
        {
            Reload(); 
        }
       
    }
    private bool FellDown() 
    {
        if (transform.position.y < -15) 
        {
            return true;
        }
        return false; 
    }
}
