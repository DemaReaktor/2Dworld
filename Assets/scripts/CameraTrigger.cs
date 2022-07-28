using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        Mesh mesh = collision.gameObject.GetComponent<MeshFilter>().mesh;
        collision.gameObject.GetComponent<Viewer>().SetSquare(GeometryOperations.FindArea(collision.gameObject.GetComponent<MeshFilter>().mesh,
            transform.lossyScale,transform.localPosition,transform));
    }
}
