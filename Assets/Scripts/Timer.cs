// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;

// public class Timer : MonoBehaviour
// {
//    [SerializeField] TextMeshProUGUI TimerText;
//    [SerializeField] float remainingTime;

//     // Update is called once per frame
//     void Update()
//     {

//         if (remainingTime > 0){
//             remainingTime -= Time.deltaTime;
//         }
//         else if (remainingTime < 0){
//             remainingTime = 0;
//             //Gameover
//             TimerText.color = Color.red;
//         }


//         remainingTime -= Time.deltaTime;
//         int minutes = Mathf.FloorToInt(remainingTime / 60);
//         int seconds = Mathf.FloorToInt(remainingTime % 60);
//         TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

//         // TimerText.text = elapsedTime.ToString();
//     }
// }

//////////////////////////////change time (years)
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;

// public class Timer : MonoBehaviour
// {
//     [SerializeField] TextMeshProUGUI TimerText;
//     [SerializeField] float totalTime = 125f; // Total time for the count-up (adjust as needed)
//     private float elapsedTime = 0f;

//     void Update()
//     {
//         if (elapsedTime < totalTime)
//         {
//             elapsedTime += Time.deltaTime;
//         }
//         else
//         {
//             elapsedTime = totalTime; // Stop at max year (2025)
//         }

//         // Map elapsed time to years (1900 to 2025)
//         int startYear = 1900;
//         int endYear = 2025;

//         int currentYear = Mathf.FloorToInt(startYear + (elapsedTime / totalTime) * (endYear - startYear));

//         TimerText.text = currentYear.ToString(); // Display the current year
//     }
// }

//*********************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimerText;
    [SerializeField] float totalTime = 60f; // Faster transition time
    private float elapsedTime = 0f;

    public bool clockRunning = false; 
    public GameObject before2025environment;
    public GameObject after2025environment;
    public GameObject fire;



    void Update()
    {

       if (clockRunning){

        if (elapsedTime < totalTime)
        {
            elapsedTime += Time.deltaTime * 20f; // Increase speed (1.5x faster)
        }
        else
        {
            elapsedTime = totalTime; // Stop at 2025
        }

        // Map elapsed time to years (1900 to 2025)
        int startYear = 1900;
        int endYear = 2025;
        int currentYear = Mathf.FloorToInt(startYear + (elapsedTime / totalTime) * (endYear - startYear));

        // Update text
        TimerText.text = currentYear.ToString();

        // Gradually transition text color from white to red
        float t = Mathf.Clamp01((float)(currentYear - startYear) / (endYear - startYear) * 1f); // Faster transition
        TimerText.color = Color.Lerp(Color.white, Color.red, t); 

        if (currentYear < 2025)
        {
            before2025environment.SetActive(true);
            Debug.Log("2025 is coming");
            after2025environment.SetActive(false);
            
        }else{
            before2025environment.SetActive(false);
            Debug.Log("Welcome to 2025");
            after2025environment.SetActive(true);
        }
       } 




    }

    public void startTimer ()
    {
    clockRunning = true;
    fire.SetActive(true);
    }


}

