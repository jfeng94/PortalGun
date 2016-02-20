using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System.Collections;

public class InfoScreenManager : MonoBehaviour {
	public Text helpText;

	// Use this for initialization
	void Start () {
    	int sectorValue = Master.instance.secVal;
    	string sectorName = Master.instance.secName;

    	string path = Master.instance.sAssets;
    	string type = "";
    	switch (sectorValue) {
    		case (0):
    			type = "/CoR.txt";
    			break;
    		case (1):
    			type = "/CoR.txt";
    			break;
    		case (2):
    			type = "/CoR.txt";
    			break;
    		case (3):
    			type = "/EvilRick.txt";
    			break;
    		case (4):
    			type = "/CoR.txt";
    			break;
    		case (5):
    			type = "/CoR.txt";
    			break;
    		default:
    			type = "/NormalRick.txt";
    			break;
    	}
    	path += type;

    	Debug.Log(path);

	    helpText.text = "";
    	if (path != null) {
    		if (File.Exists(path)) {
    			StringBuilder text = new StringBuilder();
    			using (StreamReader sr = File.OpenText(path)) {
    				string s = "";
    				while ((s = sr.ReadLine()) != null) {
    					text.Append(s);
    					text.Append("\n");
    				}
    			}
    			helpText.text += text;
    		}
    	}
	}

}
