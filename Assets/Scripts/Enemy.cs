using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected virtual void Move(float speed)
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
