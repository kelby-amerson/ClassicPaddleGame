using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public GameObject other;
    public Rigidbody rigidbody;
    public AudioClip impact;
    AudioSource audioSource;

    // Use this for initialization
    public IEnumerator Start () {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        rigidbody.freezeRotation = true;
        yield return new WaitForSeconds(5);
        rigidbody.AddForce(Random.Range(6, 8), Random.Range(-4, -3), 0);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 p = transform.position;
        p.z = 0;
	}

    private void OnCollisionEnter(Collision collision)
    {
        //audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(impact);
    }
}
