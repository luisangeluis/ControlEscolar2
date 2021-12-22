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

  public int BuscarMateria(string pCodigo){
    int posicion =-1;
    for(int i=0; i<matesDisponibles.Count;i++){
      if(matesDisponibles[i].Codigo == pCodigo)
      posicion = i;
    }
    return posicion;
  }

  public bool AgregarMateria(CMateria pMateria){
    int encontrar = BuscarMateria(pMateria.Codigo);
    
    if(encontrar>=0){
      return false;
    }
    
    matesDisponibles.Add(pMateria);
    return true;
  }
  public bool EliminarMateria(string pCodigo){
    int encontrar = BuscarMateria(pCodigo);
    if(encontrar>=0){
      matesDisponibles.RemoveAt(encontrar);
      return true;
    }

    return false;
  }

  public bool ModificarMateria(string pCodigo){
    int encontrar = BuscarMateria(pCodigo);
    int opcionesModificar =0;

    if(encontrar>=0){
      Console.WriteLine("Opciones para modificar");
      Console.WriteLine("1.-Uno para modificar todo");
      Console.WriteLine("2.-Dos para modificar codigo ");
      Console.WriteLine("3.-Tres para modificar Nombre ");
      opcionesModificar = Convert.ToInt32(Console.ReadLine());

      switch(opcionesModificar){
        case 1:
        break;
        case 2:
          string codigo="";
          int yaExiste = -1;

          try{
            Console.WriteLine("Ingresa el nuevo codigo");
            codigo = Console.ReadLine();
          }catch(Exception e){

          }
          yaExiste = BuscarMateria(codigo);
          if(yaExiste >=0)
            return false;

          matesDisponibles[encontrar].Codigo = codigo;
          return true;
        break;
        case 3:
          string nombre ="";
          yaExiste =-1;

          Console.WriteLine("Ingresa el nuevo nombre");
          nombre = Console.ReadLine();

          for(int i=0;i<matesDisponibles.Count;i++){
            if(matesDisponibles[i].Nombre == nombre)
              return false;
          }

          matesDisponibles[encontrar].Nombre = nombre;
          return true;
        break;
      }
    }
    return false;
  }

}