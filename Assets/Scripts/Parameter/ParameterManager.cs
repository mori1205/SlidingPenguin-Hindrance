using UnityEngine;

public class ParameterManager : MonoBehaviour
{
  // game parameters
  public static float sensitivity = 5.0f; //3
  public static int limitedTime = 60;
  public static float maximumSpeed = 50.0f;
  public static float acceleration = 1.50f;
  public static float friction = 0.9990f;

  // experiment parameters
  public static bool fish = true;
  public static bool gameAnimation = true;
  public static bool respawn = true;
  public static bool continuousPlay = false;
  public static float waitTimeNext = 5.0f;

  // for development
  public static bool usePhysics = true;
}
