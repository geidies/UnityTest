#pragma strict

import System.Collections;

function Start () {
    // for ( var item : Item = ContextMenuItemAttribute.getAllItemsWithTypeIdEnum(1) ) {
        //Debug.Log("Got Object: " + item.ToString() );
    //}    
}

function Update () {
}

function OnMouseDown() {
    Debug.Log("Hi, my name is " + this.name);
}