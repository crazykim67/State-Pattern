using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private State state;

    public Enemy(State _state) // 상태 초기 설정
    {
        this.state = _state;
    }

    public void SetState(State _state) // 상태를 설정
    {
        this.state = _state;
    }

    public void Act() // 상태에 대한 행동 실행
    {
        state.Action();
    }
}
