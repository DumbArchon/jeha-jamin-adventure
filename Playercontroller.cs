using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playercontroller : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;
    [SerializeField]
    private ¹è°æ stageData;
    [SerializeField]
    private KeyCode keycodeAttack = KeyCode.Space;
    [SerializeField]
    private KeyCode keycodeBoom = KeyCode.Z;
    private bool isDie = false;
    private Movement2D movement2D;
    private Weapon weapon;
    private Animator animator;

    private int score;
    public int Score
    {
        set => score = Mathf.Max(0, value);
        get => score;
    }


    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
        weapon = GetComponent<Weapon>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (isDie == true) return;    

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement2D.MoveTo(new Vector3(x, y, 0));

        if (Input.GetKeyDown(keycodeAttack))
        {
            weapon.StartFiring();
        }
        else if (Input.GetKeyUp(keycodeAttack))
        {
            weapon.StopFiring();
        }

        if (Input.GetKeyDown(keycodeBoom))
        {
            weapon.StartBoom();
        }

        if(Input.GetButtonDown("Horizontal") ||
        Input.GetButtonUp("Horizontal") )  {
            animator.SetInteger("x", (int)x);
        }
        
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }
    public void OnDie()
    {
        movement2D.MoveTo(Vector3.zero);

        animator.SetTrigger("OnDie");

        Destroy(GetComponent<CircleCollider2D>());

        isDie = true;
    }

    public void OnDieEvent()
    {
        PlayerPrefs.SetInt("Score", score);

        SceneManager.LoadScene(nextSceneName);
    }
}
    



