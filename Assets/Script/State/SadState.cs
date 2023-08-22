using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadState : IState
{
    MyPet mypet;
    string speak;

    public SadState(MyPet mypet)
    {
        this.mypet = mypet;
    }

    public void Feed()
    {
        mypet.SetState(mypet.angryState);
        speak = "안먹어!!";
        mypet.SetText(speak);
    }

    public void Walk()
    {
        mypet.SetState(mypet.grinningState);
        speak = "...좋아";
        mypet.SetText(speak);
    }

    public void Pet()
    {
        speak = "...";
        mypet.SetText(speak);
    }

    public void PlayBall()
    {
        speak = "안놀아..";
        mypet.SetText(speak);
    }
}
