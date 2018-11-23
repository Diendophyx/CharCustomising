using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Children : MonoBehaviour
{
    public GameObject children;
    bool fuck;
    // Use this for initialization
    void Start()
    {
        fuck = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnabeKids()
    {
        if (fuck)
        {
            children.SetActive(true);
            fuck = false;
        }
        else
        {
            children.SetActive(false);
            fuck = true;
        }
    }

    public void disableothers()
    {

    }
}
