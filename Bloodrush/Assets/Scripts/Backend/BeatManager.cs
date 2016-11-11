using UnityEngine;
using System.Collections;

public class BeatManager : MonoBehaviour {

    public float beatDelay = 1;
	ParticleSystem bc;
	ParticleSystem o2;

    [HideInInspector]
    public int Beat = 0;

    //implement animator

	void Start()
	{
		bc = GameObject.Find ("Blutkörperstrom").GetComponent<ParticleSystem>();
		o2 = GameObject.Find ("O2Strom").GetComponent<ParticleSystem>();
	}

    //Function for InvokeRepeating
    public void Incr()
    {
        ScoreManager.IncreaseOxygen();
        ScoreManager.IncreaseCalories();
        Beat++;
		var em = bc.emission;
		em.rate = Beat/10;
		o2.Emit (20);
    }

    //Decreases the time between beats by a specified amount
    public void TimeBetweenBeats(float value)
    {
        if(IsInvoking("Incr"))
            CancelInvoke("Incr");

        beatDelay -= value;
        beatDelay = Mathf.Clamp(beatDelay, 0.0001f, 10000);

        InvokeRepeating("Incr", 0, beatDelay);
    }

}
