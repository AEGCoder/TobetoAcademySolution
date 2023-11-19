using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        //CourseTest();
       // CategoryTest();

    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void CourseTest()
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());
        foreach (var course in courseManager.GetAll().Data)
        {
            Console.WriteLine(course.CourseName);
        }
    }
}