using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]
public class Shape01 : MonoBehaviour {

	[SerializeField]
	private Transform WinZoneShape; //The 'win zone' shape which is the same one that the 'drag zone' shape will be placed on.
	private Vector2 intialPosition; //Int position of the shape.
	private Vector2 mousePosition; //Int mouse position.
	public static bool locked; //Lock the shape so it won't move?
	public AudioClip SuccessSound; //The sound that plays when you place the correct shape.
	public AudioClip FailSound; //The sound that plays when you DON'T place the correct shape in the win zone.
	private float deltaX, deltaY; 
	AudioSource audioSource;

	public void OnAwake () {
		GameManager.numberofshapes++; //Each shape on the scene, add it to the GameManager script.
	}

	void Start () {
		GameManager.numberofshapes++; //Each shape on the scene, add it to the GameManager script.
		audioSource = GetComponent<AudioSource>(); //Get audio at start.
		intialPosition = transform.position;
		locked = true; 
	}

	private void OnMouseDown () { //When mouse is pressed/clicked.
		if (!locked) {
			deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
			deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
		}
	}

	private void OnMouseDrag() { //When you are dragging mouse.
		if (locked) {
			mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
		}
	}
		
	void ShapeInWinZone() { //When the shape is in the win zone shape.
			transform.position = new Vector2 (WinZoneShape.position.x, WinZoneShape.position.y);
			GetComponent<AudioSource>().PlayOneShot(SuccessSound, 2.7F);
			GameManager.numberofshapes--;
			this.gameObject.GetComponentInChildren<Renderer> ().enabled = false;
			this.gameObject.GetComponentInChildren<Collider2D> ().enabled = false;
			foreach (Renderer r in GetComponentsInChildren<Renderer>())
			r.enabled = false;
			WinZoneShape.GetComponent<SpriteRenderer>().color = new Color( 100, 100, 100, 1 );
	}



	private void OnMouseUp() { //When the mouse click is released.

		if (Mathf.Abs(transform.position.x - WinZoneShape.position.x) <= 0.5f &&
			Mathf.Abs(transform.position.y - WinZoneShape.position.y) <= 0.5f)
		{
			ShapeInWinZone();
		}
		else
		{
			audioSource.PlayOneShot(FailSound, 0.7F);
			transform.position = new Vector2 (intialPosition.x, intialPosition.y);
		}
	}
		

	//private void Update() {
	//	if (Input.touchCount > 0 && !locked)
	//	{
	//		Touch touch = Input.GetTouch (0);
	//		Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
	//
	//		switch (touch.phase) 
	//		{
	//		case TouchPhase.Began:
	//			if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
	//			{
	//				deltaX = touchPos.x - transform.position.x;
	//				deltaY = touchPos.y - transform.position.y;
	//			}
	//			break;
	//
	//		case TouchPhase.Moved:
	//			if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
	//			transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
	//		break;
	//
	// 		case TouchPhase.Ended:
	//			if (Mathf.Abs(transform.position.x - Shape1Place.position.x) <= 0.5f &&
	//				Mathf.Abs(transform.position.y - Shape1Place.position.y) <= 0.5f)
	//			{
	//				transform.position = new Vector2 (Shape1Place.position.x, Shape1Place.position.y);
	//				locked = true;
	//			}
	//			else
	//			{
	//				transform.position = new Vector2 (intialPosition.x, intialPosition.y);
	//			}
	//			break;
	//			}
	//		}
	//	}



}