using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Knife : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    [SerializeField] private GameObject manager;
    [SerializeField] private AudioClip knifeHitSound;
    public Spawn spawn;
    public MenuManager menuManager;
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        manager = GameObject.FindGameObjectWithTag("Manager");
    }

    private void Update()
    {
        menuManager = manager.GetComponent<MenuManager>();
        spawn = manager.GetComponent<Spawn>();
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Knife")
        {
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
            menuManager.GameOver();

        }
        else if (hit.gameObject.tag == "Circle")
        {
            AudioSource.PlayClipAtPoint(knifeHitSound, transform.position, 1f);
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
            spawn.tempKnife = null;
        }

    }

}
