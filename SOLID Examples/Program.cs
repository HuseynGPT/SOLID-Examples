#region Single_Responsibility

// Her bir class bir is gormelidir!

// Bad example

//class Car
//{
//    public string? Make { get; set; }
//    public string? Model { get; set; }
//    public int Year { get; set; }


//    public void ShowCarInfo()
//    {
//        Console.WriteLine(this.Make + this.Model + this.Year.ToString());
//    }


//}


//Good examole
//class Car
//{
//    public string? Make { get; set; }
//    public string? Model { get; set; }
//    public int Year { get; set; }





//}


//class CarReport
//{

//    public void ShowCarInfo(Car car)
//    {
//        Console.WriteLine(car.Make + car.Model + car.Year.ToString());
//    }
//}



#endregion




#region Open/Close pricipe



using System.Data;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;



// Bad example
//class Rectangle
//{
//    public float Width { get; set; }
//    public float Heigth { get; set; }


//}


//class Cricle
//{
//    public float Radius { get; set; }



//}

//class Area
//{
//    public double Areaa(object obj)
//    {
//        double area = 0;

//        if (obj is Cricle)
//        {
//            Cricle newobj = (Cricle)obj;
//            area += newobj.Radius * newobj.Radius * Math.PI;
//        }
//        if (obj is Rectangle)
//        {
//            Rectangle newobj = (Rectangle)obj;
//            area += newobj.Width * newobj.Heigth;
//        }


//        return area;
//    }
//}


// Good Example

// Kodumuz deyisikliye aciq olmalidir deyisiklik edende evvelkiler silinmemelidir!


//interface IShape
//{
//    public double Area();   
//}

//class Rectangle:IShape
//{
//    public float Width { get; set; }
//    public float Heigth { get; set; }

//    public double Area()
//    {
//        return Heigth*Width;
//    }
//}


//class Cricle:IShape
//{
//    public float Radius { get; set; }

//    public double Area()
//    {
//        return Radius*Radius *Math.PI;
//    }
//}

//class AreaCalculator
//{
//    public double TotalArea(List<IShape> shapes)
//    {
//        double area = 0;

//        foreach (IShape shape in shapes)
//        {
//           area +=shape.Area();

//        }

//        return area;

//    }
//}



#endregion





#region LiskovSubstitionPricipe

//  Bizim classimizi base class evez etmelidir

/////////////////////////////////////////////////////////////////////////////////////
// Bad Ezample
//class Apple
//{
//public virtual void getColor()
//{
//    Console.WriteLine("red");
//}
//}
//class Orange:Apple
//{
//    public override void getColor()
////    {
//////        Console.WriteLine("Orange");
//    }
//}


/////////////////////////////////////////////////////////////////////////////////////
///

// Good Example

//interface IFruit
//{
//    public void getColor();
//}

//class Apple : IFruit
//{
//    public void getColor()
//    {
//        Console.WriteLine("red");
//    }
//}


//class Orange : IFruit
//{
//    public void getColor()
//    {
//        Console.WriteLine("Orange");
//    }
//}

#endregion




#region InterfaceSegregationPricipe

// Bacardigimz qeder interfacelere parcalamaliyiq

// bad example


//class Human
//{
//    public string? Name{ get; set; }
//    public string? Surname{ get; set; }
//    public DateTime? BirthDate { get; set; }

//    public int Age{ get; set; }


//}


//class Teacher
//{
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public DateTime? BirthDate { get; set; }

//    public int Age { get; set; }

//    public float Salary { get; set; }
//}


//class Policeman
//{
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public DateTime? BirthDate { get; set; }

//    public int Age { get; set; }

//    public float Salary { get; set; }


//    public string? Rutbe{ get; set; }
//}



///////////////////////////////////////////////////
///
//Good example

//interface IPerson
//{
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public DateTime? BirthDate { get; set; }

//    public int Age { get; set; }
//}

//interface IHasSalary
//{
//    public float Salary { get; set; }

//}


//class Human:IPerson
//{
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public DateTime? BirthDate { get; set; }

//    public int Age { get; set; }


//}


//class Teacher:IPerson,IHasSalary
//{
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public DateTime? BirthDate { get; set; }

//    public int Age { get; set; }

//    public float Salary { get; set; }
//}


//class Policeman: IPerson, IHasSalary
//{
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public DateTime? BirthDate { get; set; }

//    public int Age { get; set; }

//    public float Salary { get; set; }


//    public string? Rutbe { get; set; }
//}



#endregion




#region DependecyInversion

// high level classlar low level classlardan asli olmamalidir


// bad ezaple
//class CargoCompany
//{ 
//    void transport(Truck truck)
//    {
//        // win win
//        truck.Go();
//    }

//}

//class Truck
//{
//    public void Go()
//    {
//        //sdsds
//    }
//}



// good example
interface IGo
{
    public void go();
}

class CargoCompany
{
    void transport(IGo trasport)
    {
        // win win
        trasport.go();
    }

}

class Truck:IGo
{
   
    public void go()
    {
        throw new NotImplementedException();
    }
}


class Ship : IGo
{

    public void go()
    {
        throw new NotImplementedException();
    }
}




#endregion