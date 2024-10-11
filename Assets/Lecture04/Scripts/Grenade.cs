using UnityEngine;

public class Grenade : MonoBehaviour
{
    [SerializeField] float lifetime = 2f;
    [SerializeField] GameObject explosionPrefab;

    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (Time.time >= startTime + lifetime)
        {
            Destroy(gameObject);
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }
    }
}
