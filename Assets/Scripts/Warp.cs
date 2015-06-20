using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

    public Transform WarpTarget;

    IEnumerator OnTriggerEnter2D(Collider2D coll) {

        if (coll.tag == "Player")
        {


            ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();

            yield return StartCoroutine(sf.FadeToBlack());

            coll.gameObject.transform.position = WarpTarget.position;

            yield return StartCoroutine(sf.FadeToClear());


        }
    }
	
}
