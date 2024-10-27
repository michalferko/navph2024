using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class PressurePlate : MonoBehaviour
{
    [SerializeField] Material enterMaterial;
    [SerializeField] Material exitMaterial;

    MeshRenderer meshRenderer;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag("Player"))
            return;

        meshRenderer.material = enterMaterial;
    }

    void OnTriggerExit(Collider collider)
    {
        if (!collider.CompareTag("Player"))
            return;

        meshRenderer.material = exitMaterial;
    }
}
