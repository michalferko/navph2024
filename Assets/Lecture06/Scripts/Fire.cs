using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] float shotStrength = 20;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo))
            {
                var rigidbody = hitInfo.rigidbody;
                if (rigidbody != null)
                {
                    rigidbody.AddForceAtPosition(transform.forward * shotStrength, hitInfo.point, ForceMode.Impulse);
                }
            }
        }
    }
}
