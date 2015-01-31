using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SQLite4Unity3d;

public class Player : DBObject {

  [PrimaryKey, AutoIncrement]
  public int id { get; set; }
  new public string name { get; set; }
  public string description { get; set; }
  public int strength { get; set; }

  public override string ToString ()
  {
    return string.Format ("[Person: Id={0}, Name={1}, Surname={2}, Age={3}]", id, name, description, strength);
  }
	
	public Player findByName (string name) {
		return _connection.Table<Player> ().Where (x => x.name == name).FirstOrDefault();

	}
}
