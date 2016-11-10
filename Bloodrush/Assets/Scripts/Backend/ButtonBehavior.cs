using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    private Button button;
    public IButtonFunction curentFunftion;

    private ButtonGetPoints buttonGetPoints;

	void Start () {
	    //initialisiere was nötig
        buttonGetPoints = new ButtonGetPoints(this);
	}

    void SetButton(Button button)
    {
        this.button = button;
        if (button.tag == "bla")
        {
            curentFunftion = buttonGetPoints;
        }
    }

	void Update ()
    {
	    curentFunftion.Update();
	}
}
