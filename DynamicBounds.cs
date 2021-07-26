using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicBounds : MonoBehaviour
{
    public bool debugbool;

    public GameObject skinnedMeshRendererGameObject;
    private SkinnedMeshRenderer smr;
    public BoxCollider boxCollider;

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
