#pragma strict

var Player : GameObject;
var ThirdPersonCamera : GameObject;
var LookCamera : GameObject;
var check;
 

function Start () {
 LookCamera.gameObject.active = false;
 ThirdPersonCamera.gameObject.active = true;
 check = true;
}

function Update () {
	if(Input.GetKeyDown(KeyCode.E)){
		if(check){
			ThirdPersonCamera.gameObject.active = false;
			LookCamera.gameObject.active = true;
		}
		else {
		ThirdPersonCamera.gameObject.active = true;
			LookCamera.gameObject.active = false;
			}
			check = !check;
			}
}