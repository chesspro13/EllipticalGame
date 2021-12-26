using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedController : MonoBehaviour
{
	private float speed;
	public float speedModifier = 1;
	
	public Text speedText;
	public Text intensityText;
	
	public Button upButton;
	public Button downButton;
	
	public ArduinoHM10 ble;
	
	
    // Start is called before the first frame update
    void Start()
    {
	speedText.text = "Speed: " + speed.ToString();
	
	ble = GameObject.FindGameObjectsWithTag("MainCamera")[0].GetComponent<ArduinoHM10>();
	
        upButton.onClick.AddListener(increaseSpeedLocal);        
        downButton.onClick.AddListener(decreaseSpeedLocal);        
    }
    
    public void setSpeed(string curSpeed)
    {
    	speedText.text = curSpeed + "mph";
    	this.speed = float.Parse( curSpeed ) * speedModifier;
    }
    
    public void setIntensity(string intensity)
    {
    	intensityText.text = intensity + "/10";
    }
    
	public void increaseSpeedLocal()
    {
    	speed++;
	speedText.text = "Speed: " + speed.ToString();
	ble.SendString("up");
    }
    
    	public void decreaseSpeedLocal()
    {
    	speed--;
	speedText.text = "Speed: " + speed.ToString();
	ble.SendString("down");
    }
    
	public void increaseSpeedBle()
    {
    	speed++;
	speedText.text = "Speed: " + speed.ToString();
    }
    
    	public void decreaseSpeedBle()
    {
    	speed--;
	speedText.text = "Speed: " + speed.ToString();
    }
    
    public float getSpeed()
    {
    	return this.speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
