using UnityEngine;
using System.Collections;

public class nycGenerator : MonoBehaviour {

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
	public TextMesh nyc;
	//public AudioClip nycSong;
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

			int j = 0;
			while ( j<20 ) {
				Instantiate(building, new Vector3(j*blxPos, blyPos, blzPos), Quaternion.identity); 
				yield return new WaitForSeconds ( 0.2f );
				j++;
			}
			
			Instantiate(taxi, new Vector3(txPos, tyPos, tzPos), Quaternion.identity); 
			yield return new WaitForSeconds ( 0.2f );
			
			Instantiate(pizza, new Vector3(pxPos, pyPos, pzPos), Quaternion.identity); 
			yield return new WaitForSeconds ( 0.2f );
			
			Instantiate(ninjaTurtle, new Vector3(nxPos, nyPos, nzPos), Quaternion.identity); 
			yield return new WaitForSeconds ( 0.2f );

			int k = 0;
			while ( k<40 ) {
				Instantiate(money, new Vector3(Random.Range(-4, 4),Random.Range(-4, 4), Random.Range(-4, 4)), Quaternion.identity); 
				yield return new WaitForSeconds ( 0.2f );
			}
			
			i++;
			
		}
		
	}
	
	void Update() {

		//audio.PlayOneShot(nycSong);
		nyc.transform.Translate(Vector3.right * .5f * Time.deltaTime);
		
		if(Input.GetKeyDown(KeyCode.R)){
			
			Application.LoadLevel(0); //or whatever number your scene is
			
		}
		
	}

}
