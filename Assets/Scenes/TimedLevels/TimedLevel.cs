using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class TimedLevel:MonoBehaviour {

  public TimedLevelGen tlg; 

  // Start is called before the first frame update
  void Start() {
    if (tlg) {
      Debug.LogError("Need a Level Gen Object"); 
    }
    }

    // Update is called once per frame
    void Update() {
    tlg.secondsForLevel--; 
  }
}
