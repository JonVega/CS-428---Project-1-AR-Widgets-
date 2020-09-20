using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour
{
	
	int modelNum;
	public GameObject [] modelArray;

    // Start is called before the first frame update
    void Start()
    {
        modelNum = 0;
		modelArray[1].SetActive(false);
		modelArray[2].SetActive(false);
		modelArray[3].SetActive(false);
		modelArray[4].SetActive(false);
		modelArray[5].SetActive(false);
		modelArray[6].SetActive(false);
		modelArray[7].SetActive(false);
		modelArray[8].SetActive(false);
		
	}

	void ModelSwitchUp() {
		
		modelArray[modelNum-1].SetActive(false);
		if(modelNum > 8) {
			modelNum = 0;
		}
		modelArray[modelNum].SetActive(true);
	}
	
	void ModelSwitchDown() {
		
		modelArray[modelNum+1].SetActive(false);
		if(modelNum < 0) {
			modelNum = 8;
		}
		modelArray[modelNum].SetActive(true);
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)) {
        	modelNum++;
			ModelSwitchUp();
        }
		
		else if(Input.GetKeyDown(KeyCode.LeftArrow)) {
			modelNum--;
			ModelSwitchDown();
		}
    }
}
