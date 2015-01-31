using UnityEngine;
using System.Collections;
using System.IO;

using SQLite4Unity3d;


public class DBObject {

	public static void initialize() {
		_connection.CreateTable<Player> ();
		_connection.CreateTable<Item> ();
	}
	protected static ISQLiteConnection _connection = (new Factory()).Create(@"Assets/StreamingAssets/test_db");

}
