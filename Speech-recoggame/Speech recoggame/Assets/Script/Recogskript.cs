using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using UnityEngine.UI;

public class Recogskript : MonoBehaviour {

	public Camera Maincameraengine;
	public Transform Kubesm;
	public Transform Welt;
	public Transform Circle;
	public Transform Monkea; 
	float Tripoloski;
	public Transform Sokerpoles1;
	public Transform Sokerpolesdva;
	public Transform Stik;
	float Russkies;
	public float sensitivities;
	public Transform FPSem;
	public Material Cubesmat;
	public Material Spheremat;
	public Material Grussen;
	public Image Schism;
	public Transform Walls;
	public Image Zrastvuvari; 
	KeywordRecognizer KRA;
	Dictionary<string, System.Action> KW = new Dictionary<string,System.Action>();
	 
	 void Start() 
	{
		KW.Add("Far",()=>{
			Fareast();
		});
		KW.Add("Near", () =>
		 {
			 Weshterwalt();
		 });   
		KW.Add("Spawn a cube", () => 
		 {  
			 Kubes(); 
		 });
		KW.Add("Spawn a square", () =>
		{
			Kubes();
		});
		KW.Add("Spawn a sphere", () =>
		{
			Circae();   
		});  
		KW.Add("Change the color of the circle to blue", () =>
		{
			Spherekolor(); 
		});
		KW.Add("Change the color of the circle to white", () =>
		{
			Spherecolorwhitesm();
		});
		KW.Add("Change the color of the sphere to blue", () =>
		 {
			 Spherekolor();
		 });
		KW.Add("Change the color of the sphere to white", () =>
		{
			Spherecolorwhitesm();
		});
		KW.Add("Spawn a circle", () =>
		{	  
			Circae(); 
		}); 
		KW.Add("Change the color of this cube to blue", () =>
		 { 
			 Cubescolor();  
		 });
		KW.Add("First Person Mode", () =>
		 {
			 FPSmods();
			 Debug.Log("Near there");
		 });
		KW.Add("Exit First Person Mode", () =>
		{ 
			Ended();
			Debug.Log("There we goes");
		});
		KW.Add("End FPS Mode", () =>
		{ 
			Ended(); 
			Debug.Log("There we goes");
		});
		KW.Add("End First Person Mode", () =>
		{
			Ended();
			Debug.Log("There we goes");
		});
		KW.Add("Exit FPS Mode", () =>
		{
			Ended();
			Debug.Log("There we goes");
		}); 
		KW.Add("Expand the world", () =>
		 {
			 Expant();
		 });
		KW.Add("Activate First Person Mode", () =>
		{
			FPSmods(); 
			Debug.Log("Near there");
		});
		KW.Add("Change the color of the cube to blue", () =>
		{ 
			Cubescolor(); 
		});
		KW.Add("Change the color of the cube to yellow", () =>
		{ 
			Zapad(); 
		});
		KW.Add("Soccer mode", () =>
		{
			CCCP();
		});
		KW.Add("football mode", () =>
		{
			CCCP();
		});
		KW.Add("Activate Soccer mode", () =>
		{
			CCCP();
		});
		KW.Add("Activate football mode", () =>
		{
			CCCP();
		});
		KW.Add("Change the color of the ground to white", () =>
		{
			Souiz();
		});
		KW.Add("Change the color of this ground to white", () =>
		{
			Souiz();
		});
		KW.Add("Exit soccer mode", () =>
		{
			Soviets(); 
		});		
		KW.Add("Spawn the monkey head", () =>
		{
			Partisans(); 
			Debug.Log("Yes Commander!");
		});
		KW.Add("Spawn a monkey head", () =>
		{
			Partisans();
			Debug.Log("Yes Commander!");
		});
		KW.Add("Spawn a wall", () =>
		{
			TrumpWalls();
			Debug.Log("Builddah wall");
		});
		KW.Add("Build a wall", () =>
		{
			TrumpWalls();
			Debug.Log("Builddah wall");
		});
		KW.Add("Spawn the monkey", () =>
		{
			Partisans();	
		});
		KW.Add("Spawn a monkey", () =>
		{
			Partisans();
		});
		KW.Add("Change the color of this cube to yellow", () =>
		{
			Zapad();  
		});
		KW.Add("Change the color of this cube to green", () =>
		{
			Shishpenkov();	
		});
		KW.Add("Change the color of the cube to green", () =>
		{
			Shishpenkov();
		});
		KW.Add("Change the color of the cube to red", () =>
		{
			Zhukov();
		});
		KW.Add("Change the color of this cube to red", () =>
		{
			Zhukov();
		});
		KW.Add("Spawn me a whacking stick", () =>
		{
			Backhand(); 
		});
		KW.Add("Help", () =>
		{
			Mayonez();
		}); 
		KW.Add("Change the color of this cube to white", () =>
		{
			Cubescolorweissen();
		});
		KW.Add("Change the color of the cube to white", () =>
		{
			Cubescolorweissen();
		});
		KW.Add("FPS Mode", () =>
		{
			FPSmods();
			Debug.Log("Nearly there"); 
		});
		KRA = new KeywordRecognizer(KW.Keys.ToArray());
		KRA.OnPhraseRecognized += KWA;
		KRA.Start();
	}  
	  
	public void KWA(PhraseRecognizedEventArgs argd)
	{
		System.Action Keywordaktioz;
		if(KW.TryGetValue(argd.text,out Keywordaktioz))
		{
			Keywordaktioz.Invoke();  
		} 
	}  
	
	public void Backhand()
	{
		Stik.gameObject.SetActive(true); 
	}

	public void CCCP()
	{
		Sokerpoles1.gameObject.SetActive(true);
		Sokerpolesdva.gameObject.SetActive(true);
		Zrastvuvari.gameObject.SetActive(true);
		Debug.Log("Here is the goals");
	}
	
	public void Mayonez()
	{
		Schism.gameObject.SetActive(true);
	}
	 
	public void TrumpWalls()
	{
		Walls.gameObject.SetActive(true);
		Instantiate(Walls);
	}

	public void Ended()
	{
		Maincameraengine.enabled = true;
		FPSem.gameObject.SetActive(false);
	}

	public void FPSmods()
	{
		FPSem.gameObject.SetActive(true);
		Maincameraengine.enabled = false;
	}

	public void Souiz()
	{
		Grussen.color = Color.white;
	}

	public void Fareast() 
	{
		Maincameraengine.transform.Translate(3, -3, -3 * Time.deltaTime);
	}  

	public void Shishpenkov()
	{
		Cubesmat.color = Color.green;
	}

	public void Zhukov() 
	{
		Cubesmat.color = Color.red;
	}

	public void Soviets()
	{
		Sokerpoles1.gameObject.SetActive(false);
		Sokerpolesdva.gameObject.SetActive(false);
	}
	
	public void Kubes() 
	{
		Instantiate(Kubesm);
		Kubesm.transform.Translate(0,0,120*Time.deltaTime); 
	} 
	public void Weshterwalt()
	{
		Maincameraengine.transform.Translate(-3,3,3); 
	} 

	public void Expant()
	{ 
		Welt.localScale += new Vector3(10, 0, 10);
		Debug.Log("Expanded");
	}
	
	public void Partisans()
	{
		Monkea.gameObject.SetActive(true);
		Instantiate(Monkea); 
		Monkea.transform.Translate(0, 0, 120 * Time.deltaTime);
	}

	public void Circae()
	{	  
		Instantiate(Circle);    
		Circle.transform.Translate(0,0,120*Time.deltaTime);  
	} 
	
	public void Cubescolor()
	{
		Cubesmat.color = Color.blue;
	} 

	public void Cubescolorweissen()
	{
		Cubesmat.color = Color.white;
	}

	// Update is called once per frame
	void Update () {
		Camerayaw();
	} 

	public void Camerayaw()
	{
		Tripoloski = Input.GetAxis("Mouse X") * sensitivities;
		Russkies = Input.GetAxis("Mouse Y") * sensitivities;
		transform.Rotate(-Russkies, Tripoloski, 0); 
	} 
	
	public void Spherekolor()
	{
		Spheremat.color = Color.blue;
	} 
	
	public void Spherecolorwhitesm()
	{
		Spheremat.color = Color.white;		
	}

	public void Zapad()
	{
		Cubesmat.color = Color.yellow;
	}
} 
