using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;


public class Move : MonoBehaviour
{
    private NavMeshAgent boy;
    public GameObject[] goPts;
    public int curr;

    private void Start()
    {
        boy = GetComponent<NavMeshAgent>();

    }
    private void Update()
    {
        if(boy.remainingDistance > 0.1f)
        {
            return;
        }
        else
        {
            UpdatePt();
        }
    }
    public void UpdatePt()
    {
        if (curr < goPts.Length)
        {
            boy.destination = goPts[curr].transform.position;
            curr++;
        }
        else
        {
            curr = 0;
        }
    }
}
