using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyTexture : MonoBehaviour
{

    public CustomisationSet setCust;
    public int index;
    public Type type;
    public enum Type
    {
        Hair, Skin, Mouth, Eyes, Armour, Clothes
    }
 
    public void Set()
    {
        switch(type)
        {
            case Type.Hair:
                setCust.SetTexture("Hair", index);
                break;
            case Type.Skin:
                setCust.SetTexture("Skin", index);
                break;
            case Type.Mouth:
                setCust.SetTexture("Mouth", index);
                break;
            case Type.Eyes:
                setCust.SetTexture("Eyes", index);
                break;
            case Type.Armour:
                setCust.SetTexture("Armour", index);
                break;
            case Type.Clothes:
                setCust.SetTexture("Clothes", index);
                break;           
        }
    }

}
