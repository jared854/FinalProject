using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotePanel : MonoBehaviour {

	public GameObject Panel1;
	public GameObject Panel2;

	void Start ()
	{
		Panel1.gameObject.SetActive (true);
		Panel2.gameObject.SetActive (false);
	}

	public void hidePanel1()
	{
		Panel1.gameObject.SetActive (false);
		Panel2.gameObject.SetActive (true);
	}

	public void hidePanel2()
	{
		Panel2.gameObject.SetActive (false);
		Panel1.gameObject.SetActive (true);
	}
}
