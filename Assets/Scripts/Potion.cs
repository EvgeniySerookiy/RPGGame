using System;
using UnityEngine;

public class Potion : MonoBehaviour
{
    public event Action<Potion> PlayerEnteredPickupArea;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(GlobalConstants.PLAYER_TAG))
        {
            PlayerEnteredPickupArea?.Invoke(this);
        }
    }
}