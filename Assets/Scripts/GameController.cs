using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Button[] buttonList;
    private bool letraO;
    public Text p1, p2;
    public GameObject pl1, pl2;

	public GameObject gameOverPanel;
	public Text gameOverText;

    private int moveCount, player;
    private double puntos1, puntos2;

	public Button restartButton;

	void Awake(){
        SetGameControllerReferenceOnButtons();
        moveCount = 0;
        gameOverPanel.SetActive(false);
        player = 1;
        letraO = true;
        SetBoardInteractable(true);
        pl2.SetActive(false);
        puntos1 = 0;
        puntos2 = 0;
        p1.text = "0 p";
        p2.text = "0 p";
    }

    public void SetGameControllerReferenceOnButtons()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }

    public void Move(int i, bool b)
    {
        if (b)
        {
            if (i != 25 && i != 26)
            {
                if (letraO)
                    buttonList[i].image.sprite = Resources.Load<Sprite>("o");
                else
                    buttonList[i].image.sprite = Resources.Load<Sprite>("s");

                buttonList[i].interactable = false;
                EndTurn(i);
            }
            else if (i == 25)
                letra(0);
            else
                letra(1);
        }
        else
        {
            if (i != 81 && i != 82)
            {
                if (letraO)
                    buttonList[i].image.sprite = Resources.Load<Sprite>("o");
                else
                    buttonList[i].image.sprite = Resources.Load<Sprite>("s");

                buttonList[i].interactable = false;
                EndTurn2(i);
            }
            else if (i == 81)
                letra(0);
            else
                letra(1);
        }
    }

    public void EndTurn(int pos)
    {
        moveCount++;

        int fila = pos / 5;
        int columna = pos % 5;

        if (letraO)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (buttonList[(((fila + i) + 5) % 5) * 5 + ((columna + j) + 5) % 5].image.sprite == Resources.Load<Sprite>("s"))
                    {
                        if (buttonList[(((fila + 2 * i) + 5) % 5) * 5 + ((columna + 2 * j) + 5) % 5].image.sprite == Resources.Load<Sprite>("o"))
                        {
                            if (player == 1)
                            {
                                puntos1 += 1;
                            }
                            else if (player == 2)
                            {
                                puntos2 += 1;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            for (int i = -1; i <= 1; i++)
            {
             for (int j = -1; j <= 1; j++)
                {
                    if (buttonList[(((fila + i) + 5) % 5) * 5 + ((columna + j) + 5) % 5].image.sprite == Resources.Load<Sprite>("o"))
                    {
                        if (buttonList[(((fila - i) + 5) % 5) * 5 + ((columna - j) + 5) % 5].image.sprite == Resources.Load<Sprite>("o"))
                        {
                            if (player == 1)
                            {
                                puntos1 += 0.5;
                            }
                            else if (player == 2)
                            {
                                puntos2 += 0.5;
                            }
                        }
                    }
                }  
            }
        }

        if (moveCount == 25)
        {
            if (puntos1 > puntos2)
                GameOver("¡¡El Jugador 1\n aprueba Taller!!");
            else if (puntos2 > puntos1)
                GameOver("¡¡El Jugador 2\n aprueba Taller!!");
            else
                GameOver("Los dos\n jugadores\n suspenden.");
        }

        ChangeSides();
    }

    public void EndTurn2(int pos)
    {
        moveCount++;

        int fila = pos / 9;
        int columna = pos % 9;

        if (letraO)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int c = i, d = j;
                    while (buttonList[(((fila + c) + 9) % 9) * 9 + ((columna + d) + 9) % 9].name == "0")
                    {
                        if (columna == 3)
                            d--;
                        else if (columna == 5)
                            d++;
                        else if (fila == 3)
                            c--;
                        else if (fila == 5)
                            c++;
                    }

                    if (buttonList[(((fila + c) + 9) % 9) * 9 + ((columna + d) + 9) % 9].image.sprite == Resources.Load<Sprite>("s"))
                    {
                        if (fila == 3 && columna == 3 && i == -1 && j == -1)
                        {
                        }

                        else if (fila == 3 && columna == 5 && i == -1 && j == 1)
                        {
                        }

                        else if (fila == 5 && columna == 3 && i == 1 && j == -1)
                        {
                        }

                        else if (fila == 5 && columna == 5 && i == 1 && j == 1)
                        {
                        }

                        else
                        {
                            c += i;
                            d += j;
                            int e = c, f = d;
                            while (buttonList[(((fila + e) + 9) % 9) * 9 + ((columna + f) + 9) % 9].name == "0")
                            {
                                if (columna == 3)
                                    f--;
                                else if (columna == 5)
                                    f++;
                                else if (fila == 3)
                                    e--;
                                else if (fila == 5)
                                    e++;
                                else if (columna == 4)
                                    f += j;
                                else if (fila == 4)
                                    e += i;
                            }

                            if (buttonList[(((fila + e) + 9) % 9) * 9 + ((columna + f) + 9) % 9].image.sprite == Resources.Load<Sprite>("o"))
                            {
                                if (player == 1)
                                {
                                    puntos1 += 1;
                                }
                                else if (player == 2)
                                {
                                    puntos2 += 1;
                                }
                            }
                        }
                    }
                }
            }
        }
        else
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int c = i, d = j;
                    while (buttonList[(((fila + c) + 9) % 9) * 9 + ((columna + d) + 9) % 9].name == "0")
                    {
                        if (columna == 3)
                            d--;
                        else if (columna == 5)
                            d++;
                        else if (fila == 3)
                            c--;
                        else if (fila == 5)
                            c++;
                    }

                    if (buttonList[(((fila + c) + 9) % 9) * 9 + ((columna + d) + 9) % 9].image.sprite == Resources.Load<Sprite>("o"))
                    {
                        if (buttonList[(((fila - i) + 9) % 9) * 9 + ((columna - j) + 9) % 9].image.sprite == Resources.Load<Sprite>("o"))
                        {
                            if (player == 1)
                            {
                                if ((columna == 2 && fila == 3) || (columna == 3 && fila == 2) && ((j == 1 && i == -1) || (j == -1 && i == 1)))
                                {
                                    puntos1 += 0.5;
                                }
                                else if ((fila == 2 && columna == 5) || (fila == 3 && columna == 6) && ((j == -1 && i == -1) || (j == 1 && i == 1)))
                                {
                                    puntos1 += 0.5;
                                }
                                else if ((fila == 5 && columna == 2) || (fila == 6 && columna == 3) && ((j == -1 && i == -1) || (j == 1 && i == 1)))
                                {
                                    puntos1 += 0.5;
                                }
                                else if ((columna == 5 && fila == 6) || (columna == 6 && fila == 5) && ((j == 1 && i == -1) || (j == -1 && i == 1)))
                                {
                                    puntos1 += 0.5;
                                }
                                else if ((fila == 3 && (columna != 2 || columna != 6)) || 
                                          fila == 5 && (columna != 2 || columna != 6) ||
                                          columna == 3 && (fila != 2 || fila != 6) ||
                                          columna == 5 && (fila != 2 || fila != 6))
                                {
                                    puntos1 += 1;
                                }
                                else
                                    puntos1 += 0.5;
                            }
                            else if (player == 2)
                            {
                                if ((columna == 2 && fila == 3) || (columna == 3 && fila == 2) && ((j == 1 && i == -1) || (j == -1 && i == 1)))
                                {
                                    puntos2 += 0.5;
                                }
                                else if ((fila == 2 && columna == 5) || (fila == 3 && columna == 6) && ((j == -1 && i == -1) || (j == 1 && i == 1)))
                                {
                                    puntos2 += 0.5;
                                }
                                else if ((fila == 5 && columna == 2) || (fila == 6 && columna == 3) && ((j == -1 && i == -1) || (j == 1 && i == 1)))
                                {
                                    puntos2 += 0.5;
                                }
                                else if ((columna == 5 && fila == 6) || (columna == 6 && fila == 5) && ((j == 1 && i == -1) || (j == -1 && i == 1)))
                                {
                                    puntos2 += 0.5;
                                }
                                else if ((fila == 3 && (columna != 2 || columna != 6)) || 
                                          fila == 5 && (columna != 2 || columna != 6) ||
                                          columna == 3 && (fila != 2 || fila != 6) ||
                                          columna == 5 && (fila != 2 || fila != 6))
                                {
                                    puntos2 += 1;
                                }
                                else
                                    puntos2 += 0.5;
                            }
                        }
                    }
                }
            }
        }

        if (moveCount == 45)
        {
            if (puntos1 > puntos2)
                GameOver("¡¡El Jugador 1\n aprueba Taller!!");
            else if (puntos2 > puntos1)
                GameOver("¡¡El Jugador 2\n aprueba Taller!!");
            else
                GameOver("Los dos\n jugadores\n suspenden.");
        }

        ChangeSides();
    }

    void SetBoardInteractable(bool b)
    {
        for (int i = 0; i < buttonList.Length; i++)
            buttonList[i].GetComponentInParent<Button>().interactable = b;
    }

    void GameOver(string s)
    {
        SetBoardInteractable(false);
        restartButton.interactable = true;
        SetGameOverText(s);
    }

    void SetGameOverText(string s)
    {
        gameOverPanel.SetActive(true);
        gameOverText.text = s;
    }

    void ChangeSides()
    {
        if (player == 1)
        {
            player = 2;
            pl1.SetActive(false);
            pl2.SetActive(true);
        }

        else
        {
            player = 1;
            pl1.SetActive(true);
            pl2.SetActive(false);
        }

        p1.text = puntos1.ToString() + " p";
        p2.text = puntos2.ToString() + " p";
    }

    public void RestartGame()
    {
        /*player = 1;
        moveCount = 0;
        puntos1 = 0;
        puntos2 = 0;
        gameOverPanel.SetActive(false);

        SetBoardInteractable(true);

        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].image.sprite = Resources.Load<Sprite>(""); ;
        }

        restartButton.interactable = false;*/

        SceneManager.LoadScene(0);
    }

    public void letra (int i)
    {
        if (i == 0)
            letraO = true;
        if (i == 1)
            letraO = false;
    }
}
