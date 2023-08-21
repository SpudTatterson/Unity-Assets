using UnityEngine;

public class VectorUtility : MonoBehaviour
{
    static public Vector3 FlattenVector(Vector3 vectorToFlatten)
    {
        return new Vector3(vectorToFlatten.x, 0f, vectorToFlatten.z);
    }
    static public Vector3 FlattenVector(Vector3 vectorToFlatten, float desiredYValue)
    {
        return new Vector3(vectorToFlatten.x, desiredYValue, vectorToFlatten.z);
    }
}
