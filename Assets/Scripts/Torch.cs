using UnityEngine;

public class Torch : MonoBehaviour
{
    [SerializeField] private GameObject _flame;
    public void LightUp()
    {
        _flame.SetActive(true);
    }
}