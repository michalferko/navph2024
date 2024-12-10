using TMPro;
using UnityEngine;

public class TestPlayerHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bombCounter;
    [SerializeField] TestItem bombItem;
    [SerializeField] TestPlayerInventory playerInventory;
    [SerializeField] GameObject uiInventory;

    int oldCount;

    void Update()
    {
        int count = 0;
        foreach (var item in playerInventory.Items)
        {
            if (item == bombItem)
                count++;
        }

        bombCounter.text = count.ToString();

        if (count != oldCount)
        {
            if (bombCounter.TryGetComponent<Animator>(out var animator))
            {
                animator.SetTrigger("Collect");
            }
        }
        oldCount = count;

        if (Input.GetKeyDown(KeyCode.I))
            uiInventory.SetActive(!uiInventory.activeSelf);
    }
}
