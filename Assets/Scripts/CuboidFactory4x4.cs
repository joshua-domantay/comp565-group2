using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboidFactory4x4 : MonoBehaviour
{
    public GameObject cuboidPrefab;
    public float length;

    public void CreateCuboid(float cLength)
    {
        Vector3 position = new Vector3(1.5f, (cLength * GameController.Instance.ScaleFactor) / 2, 1.5f);
        GameObject cuboid = Instantiate(cuboidPrefab, position, Quaternion.identity);
        cuboid.tag = "Object";
        cuboid.transform.localScale = new Vector3(4 * GameController.Instance.ScaleFactor, cLength * GameController.Instance.ScaleFactor, 4 * GameController.Instance.ScaleFactor);
        cuboid.SetActive(true);
    }
}
