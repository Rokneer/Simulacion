using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] GameObject branchPrefab;
    [SerializeField] float rootLength;
    float currentLength;
    [SerializeField] float reductionLengthPerLevel;
    [SerializeField] int recursionDepht;

    int currentDepth = 0;
    Queue<GameObject> frontier = new Queue<GameObject>();   

    private void Start()
    {
        currentLength = rootLength;

        GameObject root = Instantiate(branchPrefab,transform);
        SetBranchLenght(root, rootLength);

        frontier.Enqueue(root);
        GenerateTree();
    }
    private void GenerateTree()
    {
        if (currentDepth >= recursionDepht) return;
        ++currentDepth;
        rootLength = rootLength - rootLength * reductionLengthPerLevel;

        List<GameObject> levelNodes = new List<GameObject>();

        while (frontier.Count > 0)
        {
            var branch = frontier.Dequeue();

            GameObject leftBranch = CreateBranch(branch, Random.Range(10f,30f));
            GameObject rigthBranch = CreateBranch(branch, -Random.Range(10f, 30f));

            levelNodes.Add(leftBranch);
            levelNodes.Add(rigthBranch);
        }
        foreach (GameObject node in levelNodes)
        {
            frontier.Enqueue(node);
        }
        GenerateTree();
    }
    private GameObject CreateBranch(GameObject previousBranch, float angle)
    {
        GameObject branch = Instantiate(branchPrefab, transform);
        
        branch.transform.position = previousBranch.transform.position + previousBranch.transform.up * currentLength;
        Quaternion previousRotation = previousBranch.transform.rotation;

        SetBranchLenght(branch, currentLength);
        previousRotation *= Quaternion.Euler(0, 0, angle);  
        branch.transform.rotation = previousRotation;
       
        return branch;
    }
    private void SetBranchLenght(GameObject branch, float length)
    {
        Transform line = branch.transform.GetChild(0);
        Transform node = branch.transform.GetChild(1);
        line.localScale = new Vector3(line.localScale.x, length, line.localScale.z);
        line.localPosition = new Vector3(0f, length * 0.5f, 0f);
        node.localPosition = new Vector3(0f, length, 0f);
    }
}
