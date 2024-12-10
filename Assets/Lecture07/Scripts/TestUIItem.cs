using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestUIItem : MonoBehaviour
{
    [SerializeField] Image icon;
    [SerializeField] TextMeshProUGUI nameText;

    public TestItem Item { get; private set; }

    public void SetItem(TestItem newItem)
    {
        Item = newItem;
        icon.sprite = Item.icon;
        nameText.text = Item.itemName;
    }
}
