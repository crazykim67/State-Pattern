using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    None,
    Idle,
    Move,
    Attack,
    Jump,
}

public class StateUse : MonoBehaviour
{
    private StateType type = StateType.None;

    private State state;

    public void SetStateType(StateType _type)
    {
        this.type = _type;

        switch (type)
        {
            case StateType.Idle:
                {
                    state = new Idle();
                    state.Action();
                    break;
                }
            case StateType.Move:
                {
                    state = new Move();
                    state.Action();
                    break;
                }
            case StateType.Attack:
                {
                    state = new Attack();
                    state.Action();
                    break;
                }
            case StateType.Jump:
                {
                    state = new Jump();
                    state.Action();
                    break;
                }
                
        }
    }

    private void Start()
    {
        SetStateType(StateType.Idle);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SetStateType(StateType.Jump);
        else if (Input.GetMouseButtonDown(0))
            SetStateType(StateType.Attack);
        else if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            SetStateType(StateType.Move);
        else if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            SetStateType(StateType.Idle);
    }
}
