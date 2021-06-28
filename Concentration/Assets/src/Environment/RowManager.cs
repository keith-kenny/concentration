using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowManager : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private List<Row> rows;
    [SerializeField]
    private object locker;
    // Start is called before the first frame update
    void Start()
    {
        rows = new List<Row>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void GenerateRow()
    {
        lock(locker)
        {
            
        }
    }

    private void AdvanceSpeed()
    {
    }

    private void ManageSingleRow(Row row)
    {

    }

    private void ManageRows()
    {
        lock (locker)
        {
            foreach (var row in rows)
            {
                ManageSingleRow(row);
            }
        }
    }

}
