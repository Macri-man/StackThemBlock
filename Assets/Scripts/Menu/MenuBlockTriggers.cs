using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.Events; 
using UnityEngine.SceneManagement; 

public class MenuBlockTriggers:MonoBehaviour {

  public UnityEvent eventTrigger; 

  // Start is called before the first frame update
  void Start() {
    if (eventTrigger == null)
      eventTrigger = new UnityEvent(); 
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        switch (other.tag) {
            case "Hand":
                eventTrigger.Invoke(); 
                if (this.gameObject.tag == "Sandbox" || this.gameObject.tag == "Timed" || this.gameObject.tag == "Height") {
                    SceneManager.LoadScene(this.gameObject.tag); 
                }
              break; 
        }
    }
}
