using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    //Need to add shop system

    public Material playerMaterial;
    public GameObject customizeMenu;

    int colorIndex = 0;
    
    void Update()
    {
        switch (colorIndex)
        {
            case 1 : playerMaterial.color = Color.cyan; break;
            case 2 : playerMaterial.color = Color.green; break;
            case 3 : playerMaterial.color = Color.red; break;
            case 4 : playerMaterial.color = Color.yellow; break;
            case 5 : playerMaterial.color = Color.magenta; break;
            case 6 : playerMaterial.color = Color.blue; break;
        }
    }

    public void OpenCustomizeMenu()
    {
        customizeMenu.SetActive(true);
    }

    public void CloseButton()
    {
        customizeMenu.SetActive(false);
    }

    public void ChangeSkin1()
    {
        colorIndex = 1;
    }

    public void ChangeSkin2()
    {
        colorIndex = 2;
    }

    public void ChangeSkin3()
    {
        colorIndex = 3;
    }

    public void ChangeSkin4()
    {
        colorIndex = 4;
    }

    public void ChangeSkin5()
    {
        colorIndex = 5;
    }

    public void ChangeSkin6()
    {
        colorIndex = 6;
    }

}
