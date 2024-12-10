using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] Item item;

    void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag("Player"))
            return;


        if (!collider.TryGetComponent<PlayerInventory>(out var inventory))
            return;

        Destroy(gameObject);

        inventory.items.Add(item);
    }
}
