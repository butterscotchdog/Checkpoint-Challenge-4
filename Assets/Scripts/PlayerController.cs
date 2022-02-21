using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 500;
    void Update()
    {
        float verticalinput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalinput * speed * Time.deltaTime);
    }
}
