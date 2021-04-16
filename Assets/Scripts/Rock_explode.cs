using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_explode : MonoBehaviour
{
    public Transform RockPosition;
    public ParticleSystem RockExplodePart;

    public AudioSource RockExplodeSound;

    public float SoundDelay = 0.1f;
    public float RockDestoryTime;

    // Start is called before the first frame update
    void Start()
    {
        RockExplodePart.GetComponent<ParticleSystem>();
        RockExplodePart.Stop();
        RockExplodeSound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlayExplosions ()
	{
        StartCoroutine(rockExplode());
        Debug.Log("Playing the Rock Explode Script");
        RockExplodeSound.PlayDelayed(SoundDelay); //play your sound
    }

    IEnumerator rockExplode()
    {
        yield return new WaitForSeconds(0.1f); //waits Num seconds

        Debug.Log("Start Rock Explode Coroutine");
        RockExplodePart.Play();

        //Destroy(gameObject, RockDestoryTime); //this will work after N seconds.
        //Instantiate(, rockTransformPosition.position, rockTransformPosition.rotation);
    }


}
