using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
using UnityEngine.UI;

public class Database : MonoBehaviour
{
    public string database_url = "";
    public Text score;
    [SerializeField] InputField username;
    [SerializeField] InputField nametoread;
    User user = new User();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void saveToFirebase()
    {
        user.Username = username.text;
        user.Score = ItemCollector.pineapples;
        RestClient.Put(database_url + "/object/" + username.text + ".json", user);
    }

    public void readData()
    {
        RestClient.Get<User>(database_url + "/object/" + nametoread.text + ".json").Then(response =>
        {
            user = response;
            score.text = "Score: " + user.Score;
        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
