using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Missile : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float steer = 10f;
    Rigidbody2D rb;
    float input;
    public Transform target;

    [SerializeField] TMP_Text X, Y, Z;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        input = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        //rb.velocity = transform.up * Time.fixedDeltaTime * speed * 10f;

        Vector2 direction = (target.position - transform.position).normalized;
        Vector3 cross = Vector3.Cross(transform.up, direction);
        float rotationSteer = cross.z;
        X.text = cross.x.ToString("F1");
        Y.text = cross.y.ToString("F1");
        Z.text = cross.z.ToString("F1");

        //rb.angularVelocity = rotationSteer * steer * 10f;
    }
}
