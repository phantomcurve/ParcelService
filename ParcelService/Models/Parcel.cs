using System;
using System.Collections.Generic;

namespace ParcelService.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Weight { get; set; }

    // public int Volume { get; set; }

    private static List<Parcel> _instances = new List<Parcel> { };
    
    public Parcel(int length, int height, int width, int weight)
    {
      Length = length;
      Height = height;
      Width = width;
      Weight = weight;
      // _instances = this
      _instances.Add(this);
    //   Volume = (length * height * width); 👈 cool kids coder club way...
    }

    public static List<Parcel> GetAll(){
        return _instances;
    }
    
    public int Volume(){
        return (Length * Width * Height);
        // Parcel myParcel = new Parcel(width, length, height);
        // int volume = Parcel.Volume() || Parcel.Volume;
    }

    public int CostToShip(){
          Random rnd = new Random();
          return (Length * Width * Height * Weight) + rnd.Next(-10, 100);
    }
  }
}