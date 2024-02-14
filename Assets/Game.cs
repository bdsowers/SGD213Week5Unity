using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private Student memberStudent;

    List<Student> students = new List<Student>();

    // Start is called before the first frame update
    void Start()
    {
        Student newStudent = new Student();
        newStudent.HaveBirthday();
        newStudent.ChangeName("John");
        Debug.Log(newStudent.GetName());

        newStudent.Name = "Tom";
        Debug.Log(newStudent.Name);

        Student otherStudent = new Student();
        otherStudent.ChangeName("Zoe");


        // Weird crazy logic
        memberStudent = new Student();

        students.Add(newStudent);
        students.Add(otherStudent);
        students.Add(memberStudent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
