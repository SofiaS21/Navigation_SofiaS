using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehavior : MonoBehaviour
{
    //punto donde va el agente
    public NavMeshAgent agent;
    public Transform target;
    public Transform target2;
    public Transform targetAux; //auxiliar


    // Start is called before the first frame update
    void Start()
    {
        targetAux = target;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = targetAux.position;
        if(agent.hasPath && agent.remainingDistance < 1) //necesita tener el path marcado (hasPath) para que el script pueda calcular la distancia
        {
            if(targetAux = target)
            {
                targetAux = target2;
            }
            else
            {
                targetAux = target;
            }
        }
    }

}
