using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;
    private Camera _main;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _main = Camera.main;
    }

    private void Update()
    {
        // Перемещаем персонажа в направлении _destination.
        _navMeshAgent.SetDestination(_destination);
        var ray = _main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                _destination = hitInfo.point;
            }
        }
        
    }
}