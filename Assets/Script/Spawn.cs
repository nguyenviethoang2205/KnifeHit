using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] public GameObject tempKnife;

    // 
    private void Update()
    {
        if (tempKnife == null)
        {
            tempKnife = Instantiate(Resources.Load("Prefabs/Knife")) as GameObject;
        }

        if (Input.GetMouseButtonDown(0))
        {    
            tempKnife.GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
        }
    }
}
