using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    //CharacterController charControl;
    public float walkSpeed;
    public GameObject akBody;
    public GameObject akMag;
    public GameObject akCube;
    public Image crossHair;
    public float playerMaxHealth;
    private float playerCurrentHealth;
    public Image healthBar;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerCurrentHealth = playerMaxHealth;
    }
    void Update()
    {
        MovePlayer();
        if (transform.tag == "Player_with_ak")
        {
            akBody.GetComponentInChildren<Renderer>().enabled = true;
            akMag.GetComponentInChildren<Renderer>().enabled = true;
            akCube.GetComponentInChildren<Renderer>().enabled = true;
            
        }

        if (transform.tag != "Player")
        {
            crossHair.enabled = true;
        }
        
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            SceneManager.LoadScene("win");
        }
    }

    void MovePlayer()
    {
        
        float translation = Input.GetAxis("Vertical") * walkSpeed;
        float straffe = Input.GetAxis("Horizontal") * walkSpeed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);
    }

    private void OnGUI()
    {
        if (transform.tag == "Player")
        {
            GUI.Label(new Rect(0, 0, 100, 100), "select a weapon");

        }
    }

    public void takeDamage (float damage)
    {
        playerCurrentHealth -= damage;
        healthBar.fillAmount = playerCurrentHealth / playerMaxHealth;
        Debug.Log(playerCurrentHealth);
        if (playerCurrentHealth <= 0f)
        {
            SceneManager.LoadScene("loss");
        }
    }
}
