using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Shield : MonoBehaviour
{
    //public GameObject shield;
    //public float startAngle;
    //public float endAngle;
    //public float segments;
    //public float radius;


    public int vertexCount = 20;
    public int segments = 20;
    public float lineWidth = 0.2f;
    private float xold = 0f;
    private float yold = 0f;
    public float radius;
    public float rad2;
    public bool circleFillscreen;
    public float startAngle;
    public float endAngle;

    private LineRenderer lineRenderer;

    public EdgeCollider2D edgeCollider;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        SetupCircle();
    }

    private void SetupCircle()
    {
        startAngle -= 1;
        endAngle -= 1;
        lineRenderer.widthMultiplier = lineWidth;

        float deltaTheta = (2f * Mathf.PI / vertexCount);
        //float theta = 0f;

        Vector3 oldPos = Vector3.zero;

        List<Vector2> arcPoints = new List<Vector2>();
        float angle = startAngle;
        float arcLength = endAngle - startAngle;
        lineRenderer.positionCount = vertexCount;
        for (int i = 0; i <= segments; i++)
        {
            float x = Mathf.Sin(Mathf.Deg2Rad * angle) * rad2;
            float y = Mathf.Cos(Mathf.Deg2Rad * angle) * rad2;

            Vector3 pos = new Vector3(x, y, 0f);
            arcPoints.Add(new Vector2(-x, -y));
            lineRenderer.SetPosition(i,pos);
            angle += (arcLength / segments);
            oldPos = transform.position + pos;

            float xold = x;
            float yold = y;
        }
        edgeCollider.points = arcPoints.ToArray();
    }
//#if UNITY_EDITOR

//    private void OnDrawGizmos()
//    {
//        float deltaTheta = (2f * Mathf.PI / vertexCount);
//        float theta = 0f;

//        Vector3 oldPos = Vector3.zero;
      
//        List<Vector2> arcPoints = new List<Vector2>();
//        float angle = startAngle;
//        float arcLength = endAngle - startAngle;

//        for (int i = 0; i <= segments; i++)
//        {
//            float x = Mathf.Sin(Mathf.Deg2Rad * angle) * rad2;
//            float y = Mathf.Cos(Mathf.Deg2Rad * angle) * rad2;

//            Vector3 pos = new Vector3(x,y, 0f) ;
//            arcPoints.Add(new Vector2(x, y));
//            Gizmos.DrawLine(oldPos, transform.position + pos);
//            angle += (arcLength / segments);
//            oldPos = transform.position + pos;
        
//            float xold = x;
//            float yold = y;
//        }
//    }
//#endif
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetupCircle();
    }

    //GameObject ShieldSegment
    //{
    //    get
    //    {
    //        List<Vector2> arcPoints = new List<Vector2>();
    //        float angle = startAngle;
    //        float arcLength = endAngle - startAngle;
    //        for (int i = 0; i <= segments; i++)
    //        {
    //            float x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
    //            float y = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;

    //            arcPoints.Add(new Vector2(x, y));

    //            angle += (arcLength / segments);
    //        }
    //    }
    //}

}
