using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform target;
    [SerializeField] Camera camera;
    [SerializeField] Transform[] waypoints;
    [SerializeField] float arrivalDistance;
    int currentIndex;

    //lograr que el agente recorra una serie de objetivos almacenados
    //en un array (array de transforms, usar remainingDistance)

    private void Start()
    {
        currentIndex = 0;
        agent.destination = waypoints[currentIndex].position;
    }

    void Update()
    {

        if (agent.remainingDistance <= arrivalDistance)
        {
            if (currentIndex < waypoints.Length - 1)
            {
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
            }

            agent.destination = waypoints[currentIndex].position;
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                agent.destination = hit.point;
            }
        }
    }
}
