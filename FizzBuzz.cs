using UnityEngine;
using System.Collections;

public class FizzBuzz : MonoBehaviour{
	
	void Awake(){
		ExecFizzBuzz(100);
	}
	
	 public void ExecFizzBuzz(int destination){
		
		//Check Argument
		if(destination < 0 ){
			System.Console.WriteLine("ERROR:INVALID ARGUMENT...");
			return;
		}
		
		string answer = "";
		
		for(int i=1; i <= destination; i++){
			
			if(CheckFizzBuzz(i) == true){
				answer = "FIzz Buzz";
			}
			else if(CheckFizz(i) == true){
				answer = "Fizz";
			}
			else if(CheckBuzz(i) == true){
				answer = "Buzz";
			}else{
				answer = i.ToString();
			}
			
			Debug.Log(answer);
			//System.Console.WriteLine(answer);
		}
		
		
	}
	
	private bool CheckFizzBuzz(int n){
		if((n % 15) == 0){
			return true;
		}
		
		return false;
	}
	
	private bool CheckFizz(int n){
		if((n % 3) == 0){
			return true;
		}
		
		return false;
	}
	
	private bool CheckBuzz(int n){
		if((n % 5) == 0){
			return true;
		}
		
		return false;
	}
}
