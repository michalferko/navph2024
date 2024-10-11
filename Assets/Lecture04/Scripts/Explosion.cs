using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float lifetime = 2;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
