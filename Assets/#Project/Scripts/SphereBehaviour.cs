using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(NavMeshAgent))]
public class SphereBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    private NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(_target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("LoseScreenScene");
    }
}
