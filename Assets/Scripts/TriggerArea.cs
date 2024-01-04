using System;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public event Action PlayerEnteredTrigger;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(GlobalConstants.PLAYER_TAG))
        {
            PlayerEnteredTrigger?.Invoke();
        }
    }
}