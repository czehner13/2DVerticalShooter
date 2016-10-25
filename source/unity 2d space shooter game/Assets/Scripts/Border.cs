using UnityEngine;
using System.Collections;

public class Border : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.name != "PlayerShip")
            Destroy(coll.gameObject);
    }
}
