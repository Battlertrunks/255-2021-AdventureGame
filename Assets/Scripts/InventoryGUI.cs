using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGUI : MonoBehaviour
{
    // Getting the inventory panel UI
    public GameObject inventoryScreen;

    // List of gameobjects for item's info to look at on the inventory menu and being able to equip certain items/gameobjects
    public List<GameObject> infoBoxs;
    public List<GameObject> equipableItems;

    // Getting information UI gameobject
    public GameObject infoPanel;

    // List of items currently the player has
    public List<Transform> itemsInHand;

    // a switch to turn on certain information panels that the player chooses
    bool infoBoxSwitch = true;

    // bool to turn on and off inventory menu
    bool screenOnOff = false;

    // bools the let the player use the bush trimmer when they have it equiped
    public bool trimmerUsingOrNot = false;
    public bool attempts = true;

    void Update()
    {
        // Pressing q bring up the inventory menu and pressed q again closes it.
        if (Input.GetButtonDown("Fire3"))
        {
            if (!screenOnOff)
            {
                inventoryOpen();
                screenOnOff = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 0;
            }

            else
            {
                inventoryClose();
                screenOnOff = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
            }
        }

        for (int i = 0; i < 8; i++)
            itemsInHand[i].gameObject.SetActive(InventorySystem.mainInventory.items[i]);

       
        if (Input.GetButtonDown("Fire1"))
        {
            attempts = false;
            print(trimmerUsingOrNot);
            equipableItems[0].SetActive(false);
        }


       

    }

    // activates the inventory menu
    void inventoryOpen()
    {
        inventoryScreen.SetActive(true);
    }

    // closes the inventory menu
    void inventoryClose()
    {
        inventoryScreen.SetActive(false);
    }

    // Equiping the bush trimmer
    public void EquipTrimmer()
    {
        equipableItems[0].SetActive(true);

        if (attempts)
        {
            trimmerUsingOrNot = true;
        }

        if (!attempts)
            trimmerUsingOrNot = false;

    }

    // Player clicks on item 1 button for its information through the inventory menu
    public void BttnInfo1()
    {
        // switches it on when the player clicks on the button
        if (infoBoxSwitch)
        {
            infoBoxs[0].SetActive(true);
            infoPanel.SetActive(true);
            infoBoxSwitch = false;
        }

        // switches it off when the player clicks on the button
        else
        {
            infoBoxs[0].SetActive(false);
            infoPanel.SetActive(false);
            infoBoxSwitch = true;
        }
    }

    // Player clicks on item 2 button for its information through the inventory menu
    public void BttnInfo2()
    {
        if (infoBoxSwitch)
        {
            infoBoxs[1].SetActive(true);
            infoPanel.SetActive(true);
            infoBoxSwitch = false;
        }

        else
        {
            infoBoxs[1].SetActive(false);
            infoPanel.SetActive(false);
            infoBoxSwitch = true;
        }
    }

    // Player clicks on item 3 button for its information through the inventory menu
    public void BttnInfo3()
    {
        if (infoBoxSwitch)
        {
            infoBoxs[2].SetActive(true);
            infoPanel.SetActive(true);
            infoBoxSwitch = false;
        }

        else
        {
            infoBoxs[2].SetActive(false);
            infoPanel.SetActive(false);
            infoBoxSwitch = true;
        }
    }

    // Player clicks on item 4 button for its information through the inventory menu
    public void BttnInfo4()
    {
        if (infoBoxSwitch)
        {
            infoBoxs[3].SetActive(true);
            infoPanel.SetActive(true);
            infoBoxSwitch = false;
        }

        else
        {
            infoBoxs[3].SetActive(false);
            infoPanel.SetActive(false);
            infoBoxSwitch = true;
        }
    }

    // Player clicks on item 5 button for its information through the inventory menu
    public void BttnInfo5()
    {
        if (infoBoxSwitch)
        {
            infoBoxs[4].SetActive(true);
            infoPanel.SetActive(true);
            infoBoxSwitch = false;
        }

        else
        {
            infoBoxs[4].SetActive(false);
            infoPanel.SetActive(false);
            infoBoxSwitch = true;
        }
    }

    // Player clicks on item 6 button for its information through the inventory menu
    public void BttnInfo6()
    {
        if (infoBoxSwitch)
        {
            infoBoxs[5].SetActive(true);
            infoPanel.SetActive(true);
            infoBoxSwitch = false;
        }

        else
        {
            infoBoxs[5].SetActive(false);
            infoPanel.SetActive(false);
            infoBoxSwitch = true;
        }
    }

    // Player clicks on item 7 button for its information through the inventory menu
    public void BttnInfo7()
    {
        if (infoBoxSwitch)
        {
            infoBoxs[6].SetActive(true);
            infoPanel.SetActive(true);
            infoBoxSwitch = false;
        }

        else
        {
            infoBoxs[6].SetActive(false);
            infoPanel.SetActive(false);
            infoBoxSwitch = true;
        }
    }

    // Player clicks on item 8 button for its information through the inventory menu
    public void BttnInfo8()
    {
        if (infoBoxSwitch)
        {
            infoBoxs[7].SetActive(true);
            infoPanel.SetActive(true);
            infoBoxSwitch = false;
        }

        else
        {
            infoBoxs[7].SetActive(false);
            infoPanel.SetActive(false);
            infoBoxSwitch = true;
        }
    }
}
