using System;
using UnityEngine;
using System.Collections;

public class MoveQueue
{
    private Queue _moveQueue;

    public MoveQueue()
    {
        _moveQueue = new Queue();
    }

    public void Enqueue(Directions nextMove)
    {
        if(nextMove != Directions.NonePressed && nextMove != Directions.Undefined)
        {
            Debug.Log($"Added direction: {nextMove}");
            _moveQueue.Enqueue(nextMove);
        }
    }

    public Directions Dequeue()
    {
        var direction = Directions.NonePressed;
        if(_moveQueue.Count != 0)
        {
            direction = (Directions)_moveQueue.Dequeue();
        }

        return direction;
    }
}
