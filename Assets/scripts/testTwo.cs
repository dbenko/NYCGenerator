using UnityEngine;
using System.Collections;

public class testTwo : MonoBehaviour {

	public Transform bridge;
	public float brxPos;
	public float bryPos;
	public float brzPos;
	public Transform building;
	public float blxPos;
	public float blyPos;
	public float blzPos;
	public Transform taxi;
	public float txPos;
	public float tyPos;
	public float tzPos;
	public Transform pizza;
	public float pxPos;
	public float pyPos;
	public float pzPos;
	public Transform ninjaTurtle;
	public float nxPos;
	public float nyPos;
	public float nzPos;
	public Transform money;
	public float mxPos;
	public float myPos;
	public float mzPos;


	// Use this for initialization
	void Start () {
		StartCoroutine ( NycGen() );
	}
	
	IEnumerator NycGen() {
		
		int i = 0;
		while ( i<1 )  {

			yield return new WaitForSeconds ( 1f );
			
			Instantiate(bridge, new Vector3(brxPos, bryPos, brzPos), Quaternion.identity); 
			yield return new WaitForSeconds ( 0.2f );
			
			Instantiate(building, new Vector3(blxPos, blyPos, blzPos), Quaternion.identity); 
			yield return new WaitForSeconds ( 0.2f );
			
			Instantiate(taxi, new Vector3(txPos, tyPos, tzPos), Quaternion.identity); 
			yield return new WaitForSeconds ( 0.2f );
			
			Instantiate(pizza, new Vector3(pxPos, pyPos, pzPos), Quaternion.identity); 
			yield return new WaitForSeconds ( 0.2f );
			
			Instantiate(ninjaTurtle, new Vector3(nxPos, nyPos, nzPos), Quaternion.identity); 
			yield return new WaitForSeconds ( 0.2f );
			
			Instantiate(money, new Vector3(mxPos, myPos, mzPos), Quaternion.identity); 
			yield return new WaitForSeconds ( 0.2f );
			
			i++;

		}

	}

	void Update() {



		if(Input.GetKeyDown(KeyCode.R)){
			
			Application.LoadLevel(0); //or whatever number your scene is
			
		}

	}
}
