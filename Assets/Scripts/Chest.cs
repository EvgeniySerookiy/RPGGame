using System;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Open()
    {
        _animator.SetTrigger("open");
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider != null)
        {
            Open();
        }
    }
}