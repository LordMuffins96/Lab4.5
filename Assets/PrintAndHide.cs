using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using JetBrains.Annotations;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    [HideInInspector]
    public int i= 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ": " + i);
        i += 1;

        if (i == 100 && tag == "Red")
        {
            gameObject.SetActive(false);
        }
        if (200 > i && i > 250 && tag == "Blue")
        {
            rend.enabled = false;

        }
    }
}
