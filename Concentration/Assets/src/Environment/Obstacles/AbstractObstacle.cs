using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractObstacle : MonoBehaviour
{
    [SerializeField]
    protected bool Dangerous { get; set; }
    [SerializeField]
    protected GameObject Prefab { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
