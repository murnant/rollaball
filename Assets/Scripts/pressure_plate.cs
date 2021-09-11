using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressure_plate : MonoBehaviour
{
    public bool triggered;
    private Rigidbody rigidbody;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.2)
        {
            rigidbody.AddForce(Vector3.up * 1);
        }
        else
        {
            if (rigidbody.velocity.y <0)
            {
                rigidbody.velocity = Vector3.zero;
            }
        }
        if (transform.position.y < 0.1)
        {
            triggered = true;
        }
        else
        {
            triggered = false;
        }

        target.SetActive(triggered);

    }
}
