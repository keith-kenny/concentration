using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField]
    private MoveQueue _moveQueue;
    // Start is called before the first frame update
    void Start()
    {
        _moveQueue = new MoveQueue();
    }

    // Update is called once per frame
    void Update()
    {
        //Done before any processing
        _moveQueue.Enqueue(GetNextMove());

        //Next Move
        var currentMove = _moveQueue.Dequeue();
        ApplyMove(currentMove);


    }

    private Directions GetNextMove()
    {
        var rightKeyPressed = PlayerConfig.GetRightKeyPressed();
        var leftKeyPressed = PlayerConfig.GetLeftKeyPressed();

        if(rightKeyPressed)
        {
            return Directions.Right;
        }

        if(leftKeyPressed)
        {
            return Directions.Left;
        }

        return Directions.NonePressed;
    }

    private void ApplyMove(Directions move)
    {
        Debug.Log($"Applied move: {move}");
    }

}
