using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxCollected : MonoBehaviour
{
    public static BoxCollected instance;
    public int boxCollected;

    public GameObject Door;
    public TMP_Text UI;


    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
    }

    public void AddBox(int value)
    {
        boxCollected += value;
        UI.text = "Box Collected = " + boxCollected.ToString();
    }

    public void OpenDoor()
    {
        if (boxCollected == 2)
        {
            Door.SetActive(false);
        }
    }
}
