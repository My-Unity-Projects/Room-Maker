using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object_Generator : MonoBehaviour {

	float altPilar;

    public Transform Silla;
    public Transform Mesa;
    public Transform Cama;
    public Transform Pilar;

    public Button CreaSilla;
    public Button CreaMesa;
    public Button CreaCama;
    public Button CreaPilar;

	private RuntimeGizmos.TransformGizmo tg;

    public int cont;

    void IniatiateSilla()
    {
        if (cont < 15)
        {

			tg.target = GameObject.Instantiate(Silla, new Vector3(0, 0.5f, 0), Quaternion.identity);

            cont = cont + 1;
        }

    }
    void IniatiateMesa()
    {
        if (cont < 15)
        {
			Mesa.localScale = new Vector3 (0.18f, 0.18f, 0.18f);
			tg.target = GameObject.Instantiate(Mesa, new Vector3(0, 0.5f, 0), Quaternion.identity);

            cont = cont + 1;
        }

    }
    void IniatiateCama()
    {

        if (cont < 15)
        {
			Cama.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
			tg.target = GameObject.Instantiate(Cama, new Vector3(0, 0.5f, 0), Quaternion.identity);

            cont = cont + 1;
        }

    }
    void IniatiatePilar()
	{
		float altPilar = GameObject.Find ("GO_Room").transform.localScale.y * 100;

        if (cont < 15)
		{
			Pilar.localScale = new Vector3(50.0f, altPilar, 50.0f);
            tg.target  = GameObject.Instantiate(Pilar, new Vector3(0, altPilar/2f, 0), Quaternion.identity);

            cont = cont + 1;

        }

    }


    // Use this for initialization
    void Start () {

		tg = GameObject.Find ("Orbital_Camera").GetComponent<RuntimeGizmos.TransformGizmo> ();

        cont = 0;

        Button silla = CreaSilla.GetComponent<Button>();
        silla.onClick.AddListener(IniatiateSilla);


        Button mesa = CreaMesa.GetComponent<Button>();
        mesa.onClick.AddListener(IniatiateMesa);

        Button cama = CreaCama.GetComponent<Button>();
        cama.onClick.AddListener(IniatiateCama);


        Button pilar = CreaPilar.GetComponent<Button>();
		pilar.onClick.AddListener(IniatiatePilar);
	
    }


}
