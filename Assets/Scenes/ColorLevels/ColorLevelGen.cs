using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public enum coloredBlocks {red, blue, yellow, purple, green}; 

[CreateAssetMenu(fileName = "ColorLevelGen", menuName = "NewLevels/ColorGen", order = 0)]
public class ColorLevelGen:ScriptableObject {

  public string levelName; 
  [System.Serializable]
  public struct BlockRules {
    public coloredBlocks name; 
    public List < coloredBlocks > nonBlocks; 
  }

  public List < BlockRules > blocks; 

}
