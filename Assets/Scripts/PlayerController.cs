using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5;
    [SerializeField] private GameManager gamemanager;

    void Update()
    {
        float verticalinput = Input.GetAxis("Vertical");

        if (gamemanager.isGameActive)
        {
            transform.Translate(Vector3.up * verticalinput * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        gamemanager.EndGame();
    }
}
