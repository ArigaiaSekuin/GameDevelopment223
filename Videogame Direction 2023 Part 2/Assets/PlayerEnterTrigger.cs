using UnityEngine;
using UnityEngine.Events;

public class PlayerEnterTrigger : MonoBehaviour
{
    [Tooltip("The Unity Event to be triggered when the player enters the designated area.")]
    public UnityEvent onPlayerEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure the collider has the Player tag.
        {
            onPlayerEnter.Invoke(); // Invoke all functions subscribed to this event.
        }
    }
}
