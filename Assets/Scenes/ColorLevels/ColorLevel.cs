using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class ColorLevel:MonoBehaviour {

  public ColorLevelGen clg; 
  // Start is called before the first frame update
  void Start() {
    
      if (clg) {
        Debug.LogError("Need a Level Gen Object"); 
      }
    }

    // Update is called once per frame
    void Update() {
        
    }

  bool checkValidTop(coloredBlocks block, coloredBlocks block2) {
    return (clg.blocks.Find(c => c.name == block)).nonBlocks.Contains(this.block2); 
  }

}
