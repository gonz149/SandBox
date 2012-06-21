using UnityEngine;
using System.Collections;

public class DWTest : MonoBehaviour {
	
	public string[] input = {"A","B","C","D","E"};
	
	void Awake(){
		
		TestOutPut( GetReverseArray(input) );
	}
	
	 public string[] GetReverseArray(string[] input){
		
		string[] output = new string[input.Length];
		
		int cnt = 0;
		
		for(int i=input.Length; 0 < i; i--){
			output[cnt] = input[i - 1];
			
			cnt++;
		}
		
		return output;
		
	}
	
	void TestOutPut(string[] array){
		
		foreach(string s in array){
			Debug.Log(s);
		}
		
	}
	
}
