using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 상태 추상 클래스
public abstract class State : MonoBehaviour
{
    public abstract void Action();
}
