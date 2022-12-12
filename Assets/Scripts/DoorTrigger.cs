using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] private int speed;
    [SerializeField] private Transform _doorOpen;
    private Vector2 _doorInitialPosition;
    private bool _onTrigger;

    private void Start()
    {
        _doorInitialPosition = door.transform.position;
    }

    private void Update()
    {
        if (_onTrigger == true)
        {
            door.transform.position = Vector2.MoveTowards(door.transform.position, new Vector2(door.transform.position.x, _doorOpen.position.y), speed * Time.deltaTime);
        }
        else
        {
            door.transform.position = Vector2.MoveTowards(door.transform.position, _doorInitialPosition, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _onTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _onTrigger = false;
    }
}
