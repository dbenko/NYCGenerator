using UnityEngine;
using System.Collections;

public class testThree : MonoBehaviour {


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
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){
			
			//yield return new WaitForSeconds ( 5f );
			
			Instantiate(bridge, new Vector3(brxPos, bryPos, brzPos), Quaternion.identity); 

			Instantiate(building, new Vector3(blxPos, blyPos, blzPos), Quaternion.identity); 
			
			Instantiate(taxi, new Vector3(txPos, tyPos, tzPos), Quaternion.identity); 
			
			Instantiate(pizza, new Vector3(pxPos, pyPos, pzPos), Quaternion.identity); 
			
			Instantiate(ninjaTurtle, new Vector3(nxPos, nyPos, nzPos), Quaternion.identity); 

			Instantiate(money, new Vector3(mxPos, myPos, mzPos), Quaternion.identity); 
			

			
		}

		
		if(Input.GetKeyDown(KeyCode.R)){
			
			Application.LoadLevel(0); //or whatever number your scene is
			
		}

	
	}
}
