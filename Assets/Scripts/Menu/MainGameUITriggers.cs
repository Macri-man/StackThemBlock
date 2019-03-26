using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using TMPro; 

public class MainGameUITriggers:MonoBehaviour {

    public TextMeshPro text; 
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void setText(string tag) {
        switch (tag) {
            case "StartText":
            break; 
            case "SandboxText":
                text.text = "The Sandbox mode where the user build whatever they want with the blocks provided"; 
            break; 
            case "TimedText":
        text.text = "The Time mode is where there is a timer counting down until you complete the heighest block combo"; 
        break; 
            case "HeightText":
        text.text = "get a random set of blocks to get the highest height"; 
        break; 
            case "QuitText":
                break; 
         
        }
    }
}
