using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class colour_change : MonoBehaviour {
	public Update_plats Update_plats;
	public Update_intrs Update_intrs;
	public Light lite;
	public Transform Platforms;
	public Transform Interacts;

	public bool enabled;
	public bool r_enabled;
	public bool b_enabled;
	public bool g_enabled;
	public bool rclick_enabled;

	//	public Text col_text;
	// Use this for initialization
	void Start () {
		lite.color = Color.white;
		update_objects();
		//	col_text.text = "Current Lens: White";
	}

	void change()
	{

		if (lite.color == Color.white) {
			lite.color = Color.red;
			//			col_text.text = "Current Lens: Red";
		} else if (lite.color == Color.red) {
			lite.color = Color.green;
			//			col_text.text = "Current Lens: Green";
		} else if (lite.color == Color.green) {
			lite.color = Color.blue;
			//			col_text.text = "Current Lens: Blue";
		} else if (lite.color == Color.blue) {
			lite.color = Color.white;
			//			col_text.text = "Current Lens: White";
		}
	}

	void update_objects() 
	{
		foreach (Transform rend in Platforms) {
			string cooler = rend.tag;
			if (cooler == "white") {
				rend.GetComponent<Renderer> ().material.color = lite.color;
				rend.GetComponent<Renderer> ().material.SetColor("_EmissionColor", lite.color);
			}
			if (cooler == "red")
				update_r (rend);
			if (cooler == "blue")
				update_b (rend);
			if (cooler == "green")
				update_g (rend);
			if (cooler == "yellow")
				update_y (rend);
			if (cooler == "magenta")
				update_m (rend);
			if (cooler == "cyan")
				update_c (rend);
			if (cooler == "black")
				update_black (rend);
			Update_plats.on_change (rend);
		}
		foreach (Transform rend in Interacts) {
			string cooler = rend.tag;
			if (cooler == "white") {
				rend.GetComponent<Renderer> ().material.color = lite.color;
				rend.GetComponent<Renderer> ().material.SetColor("_EmissionColor", lite.color);
			}
			if (cooler == "red")
				update_r (rend);
			if (cooler == "blue")
				update_b (rend);
			if (cooler == "green")
				update_g (rend);
			if (cooler == "yellow")
				update_y (rend);
			if (cooler == "magenta")
				update_m (rend);
			if (cooler == "cyan")
				update_c (rend);
			if (cooler == "black")
				update_black (rend);
			Update_intrs.on_change (rend);
		}
	}

	void restore_color(Transform rend)
	{
		if (rend.tag == "white") {
			rend.GetComponent<Renderer> ().material.color = Color.white; 
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.white);
		}
		if (rend.tag == "red") {
			rend.GetComponent<Renderer> ().material.color = Color.red; 
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.red);
		}
		if (rend.tag == "green") {
			rend.GetComponent<Renderer> ().material.color = Color.green; 
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.green);
		}
		if (rend.tag == "blue"){
			rend.GetComponent<Renderer> ().material.color = Color.blue; 
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.blue);
		}
		if (rend.tag == "yellow") {
			rend.GetComponent<Renderer> ().material.color = Color.yellow; 
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.yellow);
		}
		if (rend.tag == "magenta"){
			rend.GetComponent<Renderer> ().material.color = Color.magenta; 
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.magenta);
		}
		if (rend.tag == "cyan"){
			rend.GetComponent<Renderer> ().material.color = Color.cyan; 
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.cyan);
		}
		if (rend.tag == "black") {
			rend.GetComponent<Renderer> ().material.color = Color.black; 
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.black);
		}
	}
	void update_r(Transform rend)
	{
		if (lite.color == Color.white)
			restore_color (rend);
		if (lite.color == Color.red) {
			rend.GetComponent<Renderer> ().material.color = Color.white;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.white);
		}
		if (lite.color == Color.green) {
			rend.GetComponent<Renderer> ().material.color = Color.yellow;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.yellow);
		}
		if (lite.color == Color.blue) {
			rend.GetComponent<Renderer> ().material.color = Color.magenta;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.magenta);
		}
	}

	void update_b(Transform rend)
	{
		if (lite.color == Color.white){
			restore_color (rend);
		}
		if (lite.color == Color.red) {
			rend.GetComponent<Renderer> ().material.color = Color.magenta;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.magenta);
		}
		if (lite.color == Color.green) {
			rend.GetComponent<Renderer> ().material.color = Color.cyan;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.green);
		}
		if (lite.color == Color.blue) {
			rend.GetComponent<Renderer> ().material.color = Color.white;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.white);
		}

	}

	void update_g(Transform rend)
	{
		if (lite.color == Color.white)
			restore_color (rend);
		if (lite.color == Color.red) {
			rend.GetComponent<Renderer> ().material.color = Color.yellow;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.yellow);
		}
		if (lite.color == Color.green) {
			rend.GetComponent<Renderer> ().material.color = Color.white;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.white);
		}
		if (lite.color == Color.blue) {
			rend.GetComponent<Renderer> ().material.color = Color.cyan;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.cyan);
		}
	}

	void update_y(Transform rend)
	{
		if (lite.color == Color.white)
			restore_color (rend);
		if (lite.color == Color.red) {
			rend.GetComponent<Renderer> ().material.color = Color.green;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.green);
		}
		if (lite.color == Color.green) {
			rend.GetComponent<Renderer> ().material.color = Color.red;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.red);
		}
		if (lite.color == Color.blue) {
			rend.GetComponent<Renderer> ().material.color = Color.black;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.black);
		}
	}
	void update_c(Transform rend)
	{
		if (lite.color == Color.white)
			restore_color (rend);
		if (lite.color == Color.red) {
			rend.GetComponent<Renderer> ().material.color = Color.black;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.black);
		}
		if (lite.color == Color.green) {
			rend.GetComponent<Renderer> ().material.color = Color.blue;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.blue);
		}
		if (lite.color == Color.blue) {
			rend.GetComponent<Renderer> ().material.color = Color.green;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.green);
		}
	}
	//magenta
	void update_m(Transform rend)
	{
		if (lite.color == Color.white)
			restore_color (rend);
		if (lite.color == Color.red) {
			rend.GetComponent<Renderer> ().material.color = Color.blue;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.blue);
		}
		if (lite.color == Color.green) {
			rend.GetComponent<Renderer> ().material.color = Color.black;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.black);
		}
		if (lite.color == Color.blue) {
			rend.GetComponent<Renderer> ().material.color = Color.red;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.red);
		}
	}
	void update_black(Transform rend)
	{
		if (lite.color == Color.white)
			restore_color (rend);
		if (lite.color == Color.red) {
			rend.GetComponent<Renderer> ().material.color = Color.cyan;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.cyan);
		}
		if (lite.color == Color.green) {
			rend.GetComponent<Renderer> ().material.color = Color.magenta;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.magenta);
		}
		if (lite.color == Color.blue) {
			rend.GetComponent<Renderer> ().material.color = Color.yellow;
			rend.GetComponent<Renderer> ().material.SetColor ("_EmissionColor", Color.yellow);
		}
	}

	// Update is called once per frame
	void Update () {
		if (enabled) {
			if (Input.GetKeyDown (KeyCode.Mouse1) && rclick_enabled) {
				change ();
				update_objects ();
			} else if (Input.GetKeyDown (KeyCode.C) && r_enabled) {
				lite.color = Color.red;
				update_objects ();
			} else if (Input.GetKeyDown (KeyCode.V) && b_enabled) {
				lite.color = Color.blue;
				update_objects ();
			} else if (Input.GetKeyDown (KeyCode.B) && g_enabled) {
				lite.color = Color.green;
				update_objects ();
			} else if (Input.GetKeyDown (KeyCode.N)) {
				lite.color = Color.white;
				update_objects ();
			}
		}
	}

}