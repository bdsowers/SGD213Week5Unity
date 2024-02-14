public class Student
{
    private string name;
    private string ssn;
    private int age;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public int Age
    {
        set
        {
            if (age < 0 || age > 150)
            {
                // Do some error
            }
            else
            {
                age = value;
            }
        }
    }
    public void CompareStudent(Student other)
    {

    }

    public void ChangeName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return Name;
    }

    public void HaveBirthday()
    {
        age++;
    }
}
