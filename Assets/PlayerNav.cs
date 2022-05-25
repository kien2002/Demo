using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerNav : MonoBehaviour
{
    [SerializeField] private Transform movePosition;
    private NavMeshAgent meshAgent;
    private void Awake()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshAgent.destination = movePosition.position;
    }
}
