using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemy : Enemy
{
    private GameObject player;
    private void Start()
    {
        player = GameObject.Find("Player");
    }
    protected override void Move(float speed)
    {
        base.Move(speed);
        transform.Translate(Vector3.up * (transform.position.y - player.transform.position.y) * speed * Time.deltaTime);
    }

    private void Update()
    {
        Move(-5);
    }
}
