using System;
using System.Collections.Generic;
public class CMatesDisponibles{
  private List<CMateria> matesDisponibles = null;

  public CMatesDisponibles(){
    CMateria espanol = new CMateria("0000","español");
    CMateria matematicas = new CMateria("0001","matematicas");
    CMateria historia = new CMateria("0002","historia");
    CMateria ingles = new CMateria("0003","ingles");
    CMateria ciencias = new CMateria("0004","ciencias");

    matesDisponibles = new List<CMateria>();
    matesDisponibles.Add(espanol);
    matesDisponibles.Add(matematicas);
    matesDisponibles.Add(historia);
    matesDisponibles.Add(ingles);
    matesDisponibles.Add(ciencias);
  }

  public void GetAllMates(){
    foreach(CMateria mate in matesDisponibles)
      Console.WriteLine(mate);
  }
  
}