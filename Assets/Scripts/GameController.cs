using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Potion _potion;
    [SerializeField] private Player _player;
    [SerializeField] private Bridge _bridge;
    [SerializeField] private Chest _chest;
    [SerializeField] private Torch[] _torches;
    [SerializeField] private TriggerArea _chestArea;
    [SerializeField] private TriggerArea _torchArea;
    

    private void Awake()
    {
        _bridge.PlayerEnteredBridgeArea += OnPlayerEnteredBridgeArea;
        _potion.PlayerEnteredPickupArea += _player.PickupPosion;
        _chestArea.PlayerEnteredTrigger += _chest.Open;
        _torchArea.PlayerEnteredTrigger += LightUpTorch;

    }
    
    private void OnDestroy()
    {
        _bridge.PlayerEnteredBridgeArea -= OnPlayerEnteredBridgeArea;
        _potion.PlayerEnteredPickupArea -= _player.PickupPosion;
        _chestArea.PlayerEnteredTrigger -= _chest.Open;
        _torchArea.PlayerEnteredTrigger -= LightUpTorch;
    }

    private void OnPlayerEnteredBridgeArea()
    {
        if (!_player.HasPotion)
        {
            _bridge.Break();
        }
    }
    
    private void LightUpTorch()
    {
        foreach (var torch in _torches)
        {
            torch.LightUp();
        }
    }
}