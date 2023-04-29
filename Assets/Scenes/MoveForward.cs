using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 1f; // скорость движени€

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime; // прибавл€ем значение к позиции объекта в направлении его передней стороны
    }
}