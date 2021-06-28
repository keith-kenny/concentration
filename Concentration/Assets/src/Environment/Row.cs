using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    [SerializeField]
    private List<AbstractObstacle> obstacles;

    // Start is called before the first frame update
    void Start()
    {
        obstacles = new List<AbstractObstacle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
