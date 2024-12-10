using UnityEngine;

public class TestUIInventory : MonoBehaviour
{
    [SerializeField] TestUIItem uiItemPrefab;
    [SerializeField] TestPlayerInventory playerInventory;

    void OnEnable()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
            Destroy(transform.GetChild(i).gameObject);

        foreach (var item in playerInventory.Items)
        {
            var newUIItem = Instantiate(uiItemPrefab, transform);
            newUIItem.SetItem(item);
        }
    }
}
