using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSelection : MonoBehaviour
{
    [SerializeField] private GameObject _potion;
    private Outline _outline;
    private Collider _collider;

    private void Awake()
    {
        _collider = _potion.GetComponent<Collider>();
        _outline = GetComponent<Outline>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider == _collider)
        {
            _outline.OutlineWidth = _collider.GetComponent<Outline>().OutlineWidth;
            Destroy(_collider.gameObject);
        }
    }
}
