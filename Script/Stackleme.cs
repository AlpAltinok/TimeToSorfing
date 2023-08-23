using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stackleme : MonoBehaviour
{

    public List<GameObject> blockList = new List<GameObject>();
    private GameObject lastBlock;
    void Start()
    {
        UpdateLastBlock();
    }

  public void Stack(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlock.transform.position.x, lastBlock.transform.position.y - 2, lastBlock.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blockList.Add(_gameObject);
        UpdateLastBlock();
       
    }
    public void DecreaseBlock(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlock();
    }
    private void UpdateLastBlock()
    {
        lastBlock = blockList[blockList.Count - 1];
    }
}
