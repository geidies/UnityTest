using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SQLite4Unity3d;

public class Item : DBObject {
	
	[PrimaryKey, AutoIncrement]
	public int id { get; set; }
	new public string name { get; set; }
	public string description { get; set; }
	public int weight { get; set; }
	public int cost { get; set; }
	public int type_id { get; set; }

	
	public override string ToString ()
	{
		return string.Format ("[Person: Id={0}, Name={1}, Description={2}, Weight={3}, Cost={4}]", 
		                      id, name, description, weight, cost, type_id);
	}
	
	public static Item findByName (string name) {
		return _connection.Table<Item> ().Where (x => x.name == name).FirstOrDefault ();
	}

	public static ArrayList getAllItemsWithTypeId (int typeId) {
		IEnumerable<Item> itemEnum = _connection.Table<Item> ().Where ( x => x.type_id == typeId );
		ArrayList itemList = new ArrayList ();
		foreach ( Item i in itemEnum ) {
			itemList.Add(i);
		}
		return itemList;
	}

	public static IEnumerable getAllItemsWithTypeIdEnum (int typeId) {
		IEnumerable<Item> itemEnum = _connection.Table<Item> ().Where ( x => x.type_id == typeId );
		return itemEnum;
	}
}
