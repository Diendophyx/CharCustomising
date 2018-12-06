using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Children : MonoBehaviour
{
    public GameObject children;
    public bool fuck;
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
        children.SetActive(true);
        fuck = true;
    

        DisableOthers();
        //else
        //{
        //    children.SetActive(false);
        //    fuck = false;
        //}
    }

    public void DisableOthers()
    {
        foreach (GameObject thingToHide in GameObject.FindGameObjectsWithTag("CategoryParent"))
        if (thingToHide != this.gameObject)
        {
                thingToHide.GetComponent<Children>().fuck = false;
                thingToHide.transform.Find("OptionContainer").gameObject.SetActive(false);
        }
    }      
}
