using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") &&  Input.GetKeyDown(KeyCode.F))
        {
            ChoiceDialog door = FindObjectOfType<ChoiceDialog>();
            if (door != null)
            {
                door.PickupKey();
            }
            Destroy(gameObject); 
        }
    }
}
