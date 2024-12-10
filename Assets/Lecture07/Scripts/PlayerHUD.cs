using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] PlayerInventory playerInventory;

    [SerializeField] Item bombItem;

    [SerializeField] Animator bombIcon;
    [SerializeField] TextMeshProUGUI countText;

    int oldCount = 0;

    void Update()
    {
        int count = 0;
        foreach (var item in playerInventory.items)
        {
            if (item == bombItem)
                count++;
        }

        if (count != oldCount)
        {
            bombIcon.SetTrigger("Collect");
            countText.text = count.ToString();
        }

        oldCount = count;
    }
}
