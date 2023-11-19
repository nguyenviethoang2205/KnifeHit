using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Knife : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    [SerializeField] private GameObject manager;
    public Spawn spawn;
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        manager = GameObject.FindGameObjectWithTag("Manager");
        Debug.Log(rigidbody2D.isKinematic);
    }

    private void Update()
    {
        spawn = manager.GetComponent<Spawn>();
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        Debug.Log("hit");
        if (hit.gameObject.tag == "Circle")
        {
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
            spawn.tempKnife = null;
        }
        else if (hit.gameObject.tag == "Knife")
        {
            Destroy(gameObject);
        }
    }

}
