using UnityEngine;

public class ThrowGrenade : MonoBehaviour
{
    [SerializeField] float throwStrength = 10;
    [SerializeField] float torqueStrength = 5;
    [SerializeField] GameObject grenadePrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject grenade = Instantiate(grenadePrefab, transform.position, Quaternion.identity);

            grenade.transform.rotation = Random.rotationUniform;

            var rb = grenade.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * throwStrength, ForceMode.Impulse);

            rb.AddTorque(Random.onUnitSphere * torqueStrength);
        }
    }
}
