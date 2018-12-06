using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomisationSet : MonoBehaviour
{
    #region Variables
    [Header("Texture List")]
    //Texture2D List for skin,hair, mouth, eyes
    public List<Texture2D> skin = new List<Texture2D>();
    public List<Texture2D> hair = new List<Texture2D>();
    public List<Texture2D> mouth = new List<Texture2D>();
    public List<Texture2D> eyes = new List<Texture2D>();
    public List<Texture2D> clothes = new List<Texture2D>();
    public List<Texture2D> armour = new List<Texture2D>();
    [Header("Index")]
    public int skinIndex;
    public int hairIndex, mouthIndex, eyesIndex, clothesIndex, armourIndex;
    //index numbers for our current skin, hair, mouth, eyes textures

    [Header("Renderer")]
    public Renderer character;
    //renderer for our character mesh so we can reference a material list

    [Header("Max Index")]
    public int skinMax;
    public int hairMax, mouthMax, eyesMax, clothesMax, armourMax;

    //max amount of skin, hair, mouth, eyes textures that our lists are filling with

 



    #endregion
    #region Start
    //in start we need to set up the following
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        

        #region for loop to pull textures from file
        //for loop looping from 0 to less than the max amount of skin textures we need
        for (int i = 0; i < skinMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Skin_#
            Texture2D temp = Resources.Load("Character/Skin_" + i) as Texture2D;
            skin.Add(temp);
            //add our temp texture that we just found to the skin List
        }
        //for loop looping from 0 to less than the max amount of hair textures we need
        for (int i = 0; i < hairMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Hair_#
            Texture2D temp = Resources.Load("Character/Hair_" + i) as Texture2D;
            hair.Add(temp);
            //add our temp texture that we just found to the hair List
        }
        //for loop looping from 0 to less than the max amount of mouth textures we need    
        for (int i = 0; i < mouthMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Mouth_#
            Texture2D temp = Resources.Load("Character/Mouth_" + i) as Texture2D;
            mouth.Add(temp);

            //add our temp texture that we just found to the mouth List
        }
        //for loop looping from 0 to less than the max amount of eyes textures we need
        for (int i = 0; i < eyesMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Eyes_#
            Texture2D temp = Resources.Load("Character/Eyes_" + i) as Texture2D;
            eyes.Add(temp);
            //add our temp texture that we just found to the eyes List
        }
        //for loop looping from 0 to less than the max amount of clothes textures we need
        for (int i = 0; i < clothesMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Clothes_#
            Texture2D temp = Resources.Load("Character/Clothes_" + i) as Texture2D;
            clothes.Add(temp);
            //add our temp texture that we just found to the clothes List
        }
        //for loop looping from 0 to less than the max amount of armour textures we need
        for (int i = 0; i < armourMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Armour_#
            Texture2D temp = Resources.Load("Character/Armour_" + i) as Texture2D;
            armour.Add(temp);
            //add our temp texture that we just found to the armour List
        }
        #endregion
        //connect and find the SkinnedMeshRenderer thats in the scene to the variable we made for Renderer
        character = GameObject.Find("Mesh").GetComponent<SkinnedMeshRenderer>();
     
     

    }
    #endregion

    #region SetTexture
    public void SetTexture(string type, int dir)
    {
        //SetTexture skin, hair, mouth, eyes to the first texture 0
        int index = 0, max = 0, matIndex = 0;
        Texture2D[] textures = new Texture2D[0];
        //we need variables that exist only within this function
        //these are ints index numbers, max numbers, material index and Texture2D array of textures
        //inside a switch statement that is swapped by the string name of our material
        #region Switch Material
        switch (type)
        {
            //case skin
            case "Skin":
                index = skinIndex;
                //index is the same as our skin index
                max = skinMax;
                //max is the same as our skin max
                textures = skin.ToArray();
                //textures is our skin list .ToArray()
                matIndex = 1;
                //material index element number is 1
                break;
            //break
            case "Hair":
                index = hairIndex;
                //index is the same as our  index
                max = hairMax;
                //max is the same as our  max
                textures = hair.ToArray();
                //textures is our  list .ToArray()
                matIndex = 2;
                //material index element number is 2
                break;
            //break
            case "Mouth":
                index = mouthIndex;
                //index is the same as our  index
                max = mouthMax;
                //max is the same as our max
                textures = mouth.ToArray();
                //textures is our  list .ToArray()
                matIndex = 3;
                //material index element number is 3
                break;
            //break
            case "Eyes":
                index = eyesIndex;
                //index is the same as our  index
                max = eyesMax;
                //max is the same as our max
                textures = eyes.ToArray();
                //textures is our  list .ToArray()
                matIndex = 4;
                //material index element number is 4
                break;
            //break
            case "Clothes":
                index = clothesIndex;
                //index is the same as our  index
                max = clothesMax;
                //max is the same as our max
                textures = clothes.ToArray();
                //textures is our  list .ToArray()
                matIndex = 5;
                //material index element number is 5
                break;
            //break
            case "Armour":
                index = armourIndex;
                //index is the same as our  index
                max = armourMax;
                //max is the same as our max
                textures = armour.ToArray();
                //textures is our  list .ToArray()
                matIndex = 6;
                //material index element number is 6
                break;
                //break
        }

        #endregion
        #region OutSide Switch
        //outside our switch statement
        //index plus equals our direction
        index = dir;
        //cap our index to loop back around if is is below 0 or above max take one
        //Material array is equal to our characters material list
        Material[] mat = character.materials;

        //our material arrays current material index's main texture is equal to our texture arrays current index
        mat[matIndex].mainTexture = textures[index];

        //our characters materials are equal to the material array
        character.materials = mat;

        //create another switch that is goverened by the same string name of our material
        #endregion
        #region Set Material Switch
        switch (type)
        {
            case "Skin":
                skinIndex = index;
                break;
            case "Hair":
                hairIndex = index;
                break;
            case "Mouth":
                mouthIndex = index;
                break;
            case "Eyes":
                eyesIndex = index;
                break;
            case "Clothes":
                clothesIndex = index;
                break;
            case "Armour":
                armourIndex = index;
                break;
        }
        #endregion
    }
    #endregion
}