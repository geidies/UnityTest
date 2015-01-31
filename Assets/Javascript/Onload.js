#pragma strict

function Start () {
    DBObject.initialize();
    var parent_item = GameObject.Find("menu_item_1");
    parent_item.name = "parent_item";
    //for ( var i = 0; i < 3; i++ ) {
    var items : ArrayList = Item.getAllItemsWithTypeId(1);
    for ( var i = 0; i < items.Count; i++ ) {
        var item_obj : Item = items[i];
        var new_item : GameObject = GameObject.Instantiate(parent_item, Vector3(-6,i,0),Quaternion.identity);
        new_item.name = "menu_item_" + i;
        var text_mesh : TextMesh = new_item.GetComponent(TextMesh);
        text_mesh.text = item_obj.name;
    }
    GameObject.DestroyImmediate(parent_item);
}

function Update () {

}