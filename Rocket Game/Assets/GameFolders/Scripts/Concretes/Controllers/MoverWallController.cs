using RocketGame.Abstracts.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverWallController : WallController
{
    [SerializeField] Vector3 _direction;
    [SerializeField] float _factor;
    [SerializeField] float _speed = 1f;

    Vector3 _startPosition;

    private const float Full_Circle = Mathf.PI * 2f;

    private void Awake()
    {
        _startPosition= transform.position;
    }

    private void Update()
    {
        float cycle  = Time.time/_speed;
        float sinWave = Mathf.Sin(cycle * Full_Circle);
        _factor =Mathf.Abs(sinWave) ;



        Vector3 offset = _direction * _factor;
        transform.position = offset + _startPosition;
    }
}

