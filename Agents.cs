using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agents : MonoBehaviour
{
    NavMeshAgent agent_Manager;

    public GameObject Target; 
    public GameControl gameControl;

    public string AgentType;
    private float impactForce;
    private int bumpsNumber;

    private void Start()
    {
        agent_Manager = GetComponent<NavMeshAgent>();
        agent_Manager.SetDestination(Target.transform.position);


        switch (AgentType)
        {
            case "mavi":
                impactForce = 5f;
                bumpsNumber = 2;
                break;


            case "sari":
                impactForce = 10f;
                bumpsNumber = 3;
                break;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstacle"))
        {
            if (bumpsNumber != 0)
            {
                bumpsNumber--;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        if (other.gameObject.CompareTag("MainTarget"))
        {
            gameControl.GetComponent<GameControl>();
        }

    }
}
