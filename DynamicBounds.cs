using UnityEngine;

public class DynamicBounds : MonoBehaviour
{
    [SerializeField]
    private GameObject skinnedMeshRendererGameObject;
    [SerializeField]
    private BoxCollider boxCollider;
    private SkinnedMeshRenderer smr;
    private Transform rootGO;

    private void Awake()
    {
        smr = skinnedMeshRendererGameObject.GetComponent<SkinnedMeshRenderer>();
        rootGO = skinnedMeshRendererGameObject.transform.root;
    }

    private void Update()
    {
        skinnedMeshRendererGameObject.transform.rotation = Quaternion.identity;
        skinnedMeshRendererGameObject.transform.position = rootGO.localPosition;
        boxCollider.center = smr.bounds.center - rootGO.transform.position;
        boxCollider.size = smr.bounds.size;
    }
}
