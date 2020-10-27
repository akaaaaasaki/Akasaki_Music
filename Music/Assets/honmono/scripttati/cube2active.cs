
using UnityEngine;
using System.Collections;

public class cube2active : MonoBehaviour {

	private Animator animator;

	void Start () {
		animator = GetComponent <Animator> ();
	}

	void Update () {

		if(Input.GetKeyDown("space")) {
			animator.SetBool("Open", !animator.GetBool("Open"));
		}
	}
}
