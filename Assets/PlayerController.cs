using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public float moveableRange1 = 10f;
    public float moveableRange2 = 5f;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = dir * speed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -moveableRange1, moveableRange1), Mathf.Clamp(transform.position.y, -moveableRange2, moveableRange2));

    }
}
