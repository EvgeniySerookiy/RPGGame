using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    // HasPotion (private set) - чтобы никто снаружи не смог поменять
    public bool HasPotion { get; private set; }
    [SerializeField] private Outline _outline;
    [SerializeField] private GameObject _posion;
    private float _highlightOutlineWidth;

    private void Awake()
    {
        _highlightOutlineWidth = _posion.GetComponent<Outline>().OutlineWidth;
    }

    
    public void PickupPosion(Potion potion)
    {
        HasPotion = true;
        _outline.OutlineWidth = _highlightOutlineWidth;
        
        Destroy(potion.gameObject);
    }
}