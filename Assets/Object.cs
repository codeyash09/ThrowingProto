using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public float weight;
    public float speed;
    public float drag;

    private void Update()
    {
        GetComponent<Rigidbody2D>().mass = weight;
        GetComponent<Rigidbody2D>().drag = drag;

    }

}
