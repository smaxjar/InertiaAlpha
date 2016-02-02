#pragma strict

var horizontalSpeed : float = 2;
var verticalSpeed : float = 2;

function Update () {
var h : float = horizontalSpeed * Input.GetAxis ("Mouse X");
var v : float = verticalSpeed * Input.GetAxis ("Mouse Y");
transform.Rotate(v,h,0);

}