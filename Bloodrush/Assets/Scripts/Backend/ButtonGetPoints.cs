using UnityEngine;
using System.Collections;

public class ButtonGetPoints : IButtonFunction
{
    private ButtonBehavior bp;

    public ButtonGetPoints(ButtonBehavior bp)
    {
        this.bp = bp;
    }

    public void Enter()
    {
        
    }

    public void Update()
    {
        
    }

    public void Exit()
    {
        
    }
}

/*
public class ButtonGetPoints : Ibutten
{
    private IButten Parent;

    public ButtonGetPoints(IButten Parent)
    {
        this.Parent = Parent;
    }

    void enter()
    {
        //initialisiere die scheisse
    }

    void Update()
    {
        //meine funktion
        //Wenn beding erfüllt ist Exit();
    }

    void Exit()
    {
        parent.currentButtenFunction = // neue funktion;
            Parent.currentButtenFunction.enter();
    }
}

currentButtenFunction.Update();*/