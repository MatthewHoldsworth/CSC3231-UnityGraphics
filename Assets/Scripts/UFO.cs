using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    //timer till next move
    [SerializeField]
    float timer;

    float counter;

    //has a navmesh to determine movement
    UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        //gets its navmesh
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //enmuerate counter
        counter += Time.deltaTime;
        if (counter > timer)
        {
            //gets new destinaation for the ufo to travel to
            agent.destination = new Vector3(Random.Range(-50f,50f),70f, Random.Range(-50f, 50f));
            //reset counter
            counter = 0f;
        }
    }
}
