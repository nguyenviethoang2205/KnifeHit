using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers instance = new Managers();
    private Managers() { }

    public static Managers Instance { get; private set; }

    private void Awake() {
        Instance = this;
    }


}
