using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] private GameObject circle;
    [SerializeField] private float rotationSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        circle.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }   
    private void OnCollisionEnter2D(Collision2D other) {
        var xyz = other.gameObject.transform;
        xyz.parent = transform;
    }
}
