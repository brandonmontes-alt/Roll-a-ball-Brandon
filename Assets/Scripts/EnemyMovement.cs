using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update(){
        if (player !=null)
    {
        navMeshAgent.SetDestination(player.position);
    }
    }

void OnTriggerEnter(Collider other)
    {
        // Collect pickups
        if (other.gameObject.CompareTag("EnemyPickup"))
        {
            other.gameObject.SetActive(false);
            transform.position = new Vector3(0, 0.5f, 0);
        }
    }
    
}
