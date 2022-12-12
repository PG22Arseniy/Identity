using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_Pendulum2 : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _leftAngle;
    [SerializeField] private float _rightAngle;

    bool _movingClockwise;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _movingClockwise = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void ChangeMoveDir()
    {
        if (transform.rotation.z > _rightAngle)
        {
            _movingClockwise = false;
        }
        if (transform.rotation.z < _leftAngle)
        {
            _movingClockwise = true;
        }
    }

    public void Move()
    {
        ChangeMoveDir();

        if (_movingClockwise)
        {
            rb.angularVelocity = _moveSpeed;
        }
        if (!_movingClockwise)
        {
            rb.angularVelocity = -1 * _moveSpeed;
        }
    }
}
