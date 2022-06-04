using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField]
    private GameObject stage01;

    [SerializeField]
    private GameObject stage02;

    [SerializeField]
    private List<GameObject> stageList;
    private List<int> tempList = new List<int>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //追加
        tempList.Add(0);
        tempList.Add(10);
        tempList.Add(5);
        //削除
        tempList.RemoveAt(1);
        //ソート
        tempList.Sort();
        //セット
        tempList[0] = 1;
        //for
        for (int i = 0; i < tempList.Count; i++)
        {
            tempList[i] = 1;
        }
        //全消し
        tempList.Clear();

        //var st01 = Instantiate(stage01, parent);
        //st01.transform.localPosition = Vector3.zero;
        //var st02 = Instantiate(stage02, parent);
        //st02.transform.localPosition = st01.transform.localPosition + Vector3.forword * 25;
        //for (int i = 0; i < MaxStageCount; i++)
        //{
        //    var index = Random.Range(0.10);
        //    var stage = Instantiate(stageList[index], parent);
        //}
    }
}
