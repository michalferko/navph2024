using UnityEngine;

public class TestItemDrop : MonoBehaviour
{
    [SerializeField] TestItem item;

    void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag("Player"))
            return;

        if (!collider.TryGetComponent<TestPlayerInventory>(out var inventory))
        {
            Debug.LogError("Player does not have inventory!");
            return;
        }

        inventory.Items.Add(item);
        Destroy(gameObject);
    }
}
