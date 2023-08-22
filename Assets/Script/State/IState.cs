using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void Feed();
    void Walk();
    void Pet();
    void PlayBall();
    
} 
