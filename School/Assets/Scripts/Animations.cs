using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWS;

public class Animations : MonoBehaviour {

    public Animator EveAnim;
    //public splineMove SM;

	// Use this for initialization
	void Start ()
    {
        EveAnim = GetComponent<Animator>();
        //SM = GameObject.FindObjectOfType<splineMove>();

    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "JumpCol")
        {
            //EveAnim.SetBool("Jump", true);
            //StartCoroutine("JumpFalse");
            EveAnim.StopPlayback();
            EveAnim.Play("Jumping");
            //GetComponent<CharacterController>().enabled = false;

        }

        if (other.name == "RollCol")
        {
            EveAnim.StopPlayback();
            EveAnim.Play("Stand To Roll");
        }

        if (other.name == "JumpOverCol")
        {
            EveAnim.StopPlayback();
            EveAnim.Play("Jump Over");
        }

        if (other.name == "DropCol")
        {
            //EveAnim.SetBool("Drop", true);
            EveAnim.StopPlayback();
            EveAnim.Play("Standing To Crouched");
            //GetComponent<CharacterController>().enabled = false;

        }
    }

    IEnumerator JumpFalse()
    {
        yield return new WaitForSeconds(1);
        EveAnim.SetBool("Jump", false);
    }
}
