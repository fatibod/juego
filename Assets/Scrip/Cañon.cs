using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject CañonCabeza;
    public Camera CamaraDeJuego;
    public GameObject BalaPreFab;
    public float FuerzaDeDisparo = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PosicionDelMouse = Input.mousePosition;
        Vector3 PosicionGlobal = CamaraDeJuego.ScreenToWorldPoint(new Vector3(
            PosicionDelMouse.x,
            PosicionDelMouse.y,
            transform.position.z - CamaraDeJuego.transform.position.z
            ));

            CañonCabeza.transform.localEulerAngles = new Vector3(
                CañonCabeza.transform.localEulerAngles.x,
                CañonCabeza.transform.localEulerAngles.y,
                Mathf.Atan2((PosicionGlobal.y - CañonCabeza.transform.position.y),
                    (PosicionGlobal.x - CañonCabeza.transform.position.x)) * Mathf.Rad2Deg
            );
            if(Input.GetMouseButtonDown(0)){
                GameObject ObjetoBola = Instantiate(BalaPreFab);
                ObjetoBola.GetComponent<Rigidbody2D>().AddForce(CañonCabeza.transform.right * FuerzaDeDisparo);
                ObjetoBola.transform.SetParent(this.transform);
            }
    }
}
