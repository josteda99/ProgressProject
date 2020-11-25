using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class Inicializador : MonoBehaviour
{

    public GameObject Login;
    public GameObject Registro;
    public GameObject Inicio;
    public GameObject Crear;
    public GameObject ManejarProyecto;
    public GameObject Buscador;
    //login
    public InputField usuarioIF;
    public InputField contraseñaIF;
    //Registro
    public InputField nombreComIF;
    public InputField usuarioIFR;
    public InputField contraseñaIFR;
    public InputField repContraIFR;
    //manejo
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    //barra
    public ProgressBar Pb;
    //tareas y dificultades
    public int total;
    public int[] tareas = new int[5];
    int[] porcentajes = new int[5];
    bool[] tareasBandera = new bool[5];
    //red
    public GameObject network;

    void Start()
    {
        Login.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        int suma = 0;
        for (int i = 0; i < 5; i++)
        {
            suma = tareas[i] + suma;
        }
        Debug.Log(suma);
        //porcentajes en la barra

        for (int i = 0; i < 5; i++)
        {
            porcentajes[i] = (tareas[i] * 100) / suma;
            Debug.Log(porcentajes[i]);
        }

        for (int i = 0; i < 5; i++)
        {
            tareasBandera[i] = false;
        }
        network = GameObject.Find("NetworkManager");
        network.GetComponent<NetworkManagerHUD>().showGUI = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EntrarLogin()
    {
        /*
        if (!(usuarioIF.text.Equals("") || contraseñaIF.text.Equals("")))
        {
            if (usuarioIF.text.Equals("josteda99") && contraseñaIF.text.Equals("johan"))
            {
                Login.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
                Inicio.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            }
        }
        */
        Login.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
        Inicio.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }

    public void Registrar()
    {
        Login.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
        Registro.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }

    public void Atras(string name)
    {
        if (name.Equals("atrasreg"))
        {
            Login.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            Registro.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
        }
        if (name.Equals("atrascrear"))
        {
            Inicio.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            Crear.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
        }
        if (name.Equals("atrasbuscar"))
        {
            Inicio.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            Buscador.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
            network.GetComponent<NetworkManagerHUD>().showGUI = false;
            ManejarProyecto.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
        }
        if (name.Equals("atrasmanejar"))
        {
            Inicio.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            ManejarProyecto.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
            network.GetComponent<NetworkManagerHUD>().showGUI = false;
        }
    }

    public void CrearProyecto()
    {
        Inicio.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
        Crear.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }

    public void BuscarProyecto()
    {
        Inicio.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
        Buscador.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        // Instantiate(NetworkManager, new Vector2(0, 0), Quaternion.identity);
        network.GetComponent<NetworkManagerHUD>().showGUI = true;
        ManejarProyecto.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }


    public void ManejarProyectopa()
    {
        Inicio.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
        ManejarProyecto.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        network.GetComponent<NetworkManagerHUD>().showGUI = true;
    }

    public void Tareas(string tarea)
    {

        switch (tarea)
        {
            case "btn1":
                if (!tareasBandera[0])
                {
                    Pb.BarValue = Pb.BarValue + porcentajes[0];
                    btn1.GetComponent<Image>().color = new Color32(150, 255, 158, 255);
                    tareasBandera[0] = true;
                }
                else
                {
                    Pb.BarValue = Pb.BarValue - porcentajes[0];
                    btn1.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                    tareasBandera[0] = false;
                }
                break;
            case "btn2":
                if (!tareasBandera[1])
                {
                    Pb.BarValue = Pb.BarValue + porcentajes[1];
                    btn2.GetComponent<Image>().color = new Color32(150, 255, 158, 255);
                    tareasBandera[1] = true;
                }
                else
                {
                    Pb.BarValue = Pb.BarValue - porcentajes[1];
                    btn2.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                    tareasBandera[1] = false;
                }
                break;
            case "btn3":
                if (!tareasBandera[2])
                {
                    Pb.BarValue = Pb.BarValue + porcentajes[2];
                    btn3.GetComponent<Image>().color = new Color32(150, 255, 158, 255);
                    tareasBandera[2] = true;
                }
                else
                {
                    Pb.BarValue = Pb.BarValue - porcentajes[2];
                    btn3.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                    tareasBandera[2] = false;
                }
                break;
            case "btn4":
                if (!tareasBandera[3])
                {
                    Pb.BarValue = Pb.BarValue + porcentajes[3];
                    btn4.GetComponent<Image>().color = new Color32(150, 255, 158, 255);
                    tareasBandera[3] = true;
                }
                else
                {
                    Pb.BarValue = Pb.BarValue - porcentajes[3];
                    btn4.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                    tareasBandera[3] = false;
                }
                break;
            case "btn5":
                if (!tareasBandera[4])
                {
                    Pb.BarValue = Pb.BarValue + porcentajes[4];
                    btn5.GetComponent<Image>().color = new Color32(150, 255, 158, 255);
                    tareasBandera[4] = true;
                }
                else
                {
                    Pb.BarValue = Pb.BarValue - porcentajes[4];
                    btn5.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
                    tareasBandera[4] = false;
                }
                break;


        }
    }

}
