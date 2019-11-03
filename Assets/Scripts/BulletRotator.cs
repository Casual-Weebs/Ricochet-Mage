using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRotator : MonoBehaviour
{
    public float angularSpeed;
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, angularSpeed) * Time.deltaTime);
    }
}
