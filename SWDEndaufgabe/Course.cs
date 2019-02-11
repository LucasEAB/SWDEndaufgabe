using System.Collections.Generic;

public class Course
{
    public string name;
    public string description;
    public int studentAmount;
    public bool courseUsed;
    public Prof prof;
    public Block block;
    public Room room;

    public List<string> equipment;
    public List<CourseOfStudy> coursesOfStudy = new List<CourseOfStudy>();
}