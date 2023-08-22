using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryState : IState
{
    MyPet mypet;
    string speak;

    public AngryState(MyPet mypet)
    {
        this.mypet = mypet;
    }

    public void Feed()
    {
        mypet.SetState(mypet.grinningState);
        speak = "...흥";
        mypet.SetText(speak);
    }

    public void Walk()
    {
        speak = "안 가!!!";
        mypet.SetText(speak);
    }

    public void Pet()
    {
        speak = "으르렁!!!!";
        mypet.SetText(speak);
        
    }

    public void PlayBall()
    {
        speak = "안 놀아!!!!";
        mypet.SetText(speak);
    }
}
