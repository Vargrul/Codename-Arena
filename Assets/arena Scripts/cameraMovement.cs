using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

	public float scrollSpeed = 5;
	public float scrollMargin = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mX = Input.mousePosition.x;
		float mY = Input.mousePosition.y;

		//check for streight movement
		if(mX < scrollMargin) Camera.main.transform.Translate( Vector3.left * Time.deltaTime * scrollSpeed , Space.World);
		if(mX > Screen.width-2*scrollMargin) Camera.main.transform.Translate( Vector3.right * Time.deltaTime * scrollSpeed , Space.World);
		if(mY < scrollMargin) Camera.main.transform.Translate( Vector3.back * Time.deltaTime * scrollSpeed , Space.World);
		if(mY > Screen.height-2*scrollMargin) Camera.main.transform.Translate( Vector3.forward * Time.deltaTime * scrollSpeed , Space.World);

		if(Input.GetKey("left")) Camera.main.transform.Translate( Vector3.left * Time.deltaTime * scrollSpeed , Space.World);
		if(Input.GetKey ("right")) Camera.main.transform.Translate( Vector3.right * Time.deltaTime * scrollSpeed , Space.World);
		if(Input.GetKey("down")) Camera.main.transform.Translate( Vector3.back * Time.deltaTime * scrollSpeed , Space.World);
		if(Input.GetKey("up")) Camera.main.transform.Translate( Vector3.forward * Time.deltaTime * scrollSpeed , Space.World);
	}
}
