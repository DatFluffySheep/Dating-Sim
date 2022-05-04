using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using drnick;

namespace drnick
{
    public class MouseToGrid : MonoBehaviour
    {
        MiniGame game;

        private void Awake() => game = GetComponent<MiniGame>();

        // Update is called once per frame
        void Update()
        {
            Debug.Log("object");
            if (Input.GetMouseButtonDown(0) && (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitData, 2000)))
            {
                Debug.Log("inside if");
                if (hitData.transform.TryGetComponent(out Tile tile))
                {
                    Debug.Log("inside if2");
                    game.tileClicked(tile);
                }
            }
        }
    }
}
