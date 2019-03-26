using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class TimedLevel:MonoBehaviour {

  public TimedLevelGen tlg;

   private float theTime;

  // Start is called before the first frame update
  void Start() {
    if (tlg) {
      Debug.LogError("Need a Level Gen Object"); 
    }
        theTime = Time.time;
    }

    // Update is called once per frame
    void Update() {

        theTime += Time.time;

        if(theTime >= tlg.secondsForLevel)
        {
            //end the level
        }
  }
}
