using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

[CreateAssetMenu(fileName = "LevelTimedGen", menuName = "NewLevels/TimedGen", order = 0)]
public class TimedLevelGen:ScriptableObject {

  public string levelName; 

  [Range(0, 300)]
  public int secondsForLevel; 
}
