using UnityEngine;
using UnityEngine.UI;

public class scrip : MonoBehaviour
{
    public Transform[] punkter;

    public float snabb = 2f;
    public float snabbgånger = 1f;

    public float timer = 0f;
    public int vilkenpunkt = 0; //punkten den ska till

    public Text text;

    void Update()
    {
        Rör();

        timer += snabb * snabbgånger * Time.deltaTime;

        text.text = timer.ToString(); // visar timern på min text över fienden så jag kan testa prioritetsgrejer senare
    }

    void Rör()
    {
        
        

        if (vilkenpunkt >= punkter.Length)
        {
            vilkenpunkt = 0; //loopar runt banan för nu
        }

        Transform mål = punkter[vilkenpunkt];//tranform variabel som då används för att få positionen av den valda punktne  i listan

        transform.position = Vector3.MoveTowards( transform.position,    mål.position,
                        snabb * snabbgånger * Time.deltaTime //gå till dit
        );

        if (Vector3.Distance(transform.position, mål.position) < 0.00001f) // väldigt lite
        {
            

            vilkenpunkt++; 
        }
    }
}